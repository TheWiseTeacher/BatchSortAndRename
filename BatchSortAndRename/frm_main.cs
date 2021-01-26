﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BatchSortAndRename
{
    public partial class frm_main : Form
    {
        string currentDirectory = "";
        string[] files = new string[] { };

        public frm_main()
        {
            InitializeComponent();

            dgv_files.Columns[dgv_filename.Index].ValueType = typeof(string);
            dgv_files.Columns[dgv_newfilename.Index].ValueType = typeof(string);

            // Default selected values
            rad_sortDateModified.Checked = rad_sortAscending.Checked = true;

            // Default unchecked radio
            rad_sortDateCreated.Checked = rad_sortType.Checked = 
                rad_sortSize.Checked = rad_sortDescending.Checked = false;

            // DEBUG
            currentDirectory = @"D:\Test";
            UpdateFilesList();
        }

        private void LoadDirectoryFiles()
        {
            // Some buffers
            string fileName = "";
            object sortingValue = "";

            // Clear rows
            dgv_files.Rows.Clear();

            if (files.Length <= 0)
                return;

            lab_numFiles.Text = $"{files.Length} Files";
            pb_mainProgress.Maximum = files.Length;
            pb_mainProgress.Value = 0;

            foreach (string f in files)
            {
                // Update list of files
                fileName = Path.GetFileName(f);

                if (rad_sortDateModified.Checked)
                    sortingValue = File.GetLastWriteTime(f);

                if (rad_sortDateCreated.Checked)
                    sortingValue = File.GetCreationTime(f);

                if(rad_sortType.Checked)
                    sortingValue = Path.GetExtension(f);

                if(rad_sortSize.Checked)
                    sortingValue = new FileInfo(f).Length;

                dgv_files.Rows.Add(new object[] {fileName, sortingValue, ""});

                dgv_files.Sort(
                    dgv_files.Columns[dgv_Sortedby.Index], 
                    rad_sortAscending.Checked ? ListSortDirection.Ascending : ListSortDirection.Descending
                );

                // Increment progress bar
                pb_mainProgress.Value += 1;
            }

            pb_mainProgress.Value = 0;
            GenerateFilesNewNames();
        }

        private void GenerateFilesNewNames()
        {
            int fileCounter = (int)num_filename_numberStartFrom.Value;

            foreach (DataGridViewRow r in dgv_files.Rows)
            {
                r.Cells[dgv_newfilename.Index].Value = 
                    tb_filename_begin.Text +
                    fileCounter.ToString().PadLeft((int)num_filename_numberPadding.Value, '0') +
                    tb_filename_end.Text +
                    (tb_extension.Enabled ? 
                        tb_extension.Text : Path.GetExtension(r.Cells[dgv_filename.Index].Value.ToString()));

                fileCounter++;
            }
        }

        private void UpdateFilesList()
        {
            tb_directory.Text = currentDirectory;
            files = Directory.GetFiles(currentDirectory);
            LoadDirectoryFiles();
        }

        private void btn_selectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    currentDirectory = fbd.SelectedPath;
                    UpdateFilesList();
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UpdateFilesList();
        }

        private void rad_sortAscending_CheckedChanged(object sender, EventArgs e)
        {
            LoadDirectoryFiles();
        }

        private void num_filename_number_ValueChanged(object sender, EventArgs e)
        {
            GenerateFilesNewNames();
        }

        private void cb_extension_CheckedChanged(object sender, EventArgs e)
        {
            tb_extension.Enabled = cb_extension.Checked;
        }

        private void tb_extension_Validated(object sender, EventArgs e)
        {
            if(!tb_extension.Text.StartsWith(".") && !string.IsNullOrEmpty(tb_extension.Text))
            {
                tb_extension.Text = "." + tb_extension.Text;
            }

            GenerateFilesNewNames();
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActiveControl = dgv_files;
        }

        private void tb_filename_Validated(object sender, EventArgs e)
        {
            GenerateFilesNewNames();
        }

        private void rad_sortBy_CheckedChanged(object sender, EventArgs e)
        {
            // Clear rows before changing value types
            dgv_files.Rows.Clear();

            // Default options
            dgv_files.Columns[dgv_Sortedby.Index].DefaultCellStyle.Format = "";
            dgv_files.Columns[dgv_Sortedby.Index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            if (rad_sortDateModified.Checked)
            {
                dgv_Sortedby.HeaderText = "Date modified";
                dgv_files.Columns[dgv_Sortedby.Index].ValueType = typeof(DateTime);
            }

            if (rad_sortDateCreated.Checked)
            { 
                dgv_Sortedby.HeaderText = "Date created";
                dgv_files.Columns[dgv_Sortedby.Index].ValueType = typeof(DateTime);
            }
            
            if (rad_sortType.Checked)
            { 
                dgv_Sortedby.HeaderText = "Type";
                dgv_files.Columns[dgv_Sortedby.Index].ValueType = typeof(string);
            }

            if (rad_sortSize.Checked)
            {
                dgv_Sortedby.HeaderText = "Size (Bytes)";
                dgv_files.Columns[dgv_Sortedby.Index].ValueType = typeof(long);
                dgv_files.Columns[dgv_Sortedby.Index].DefaultCellStyle.Format = "N0";
                dgv_files.Columns[dgv_Sortedby.Index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Update
            LoadDirectoryFiles();
        }
    }
}
