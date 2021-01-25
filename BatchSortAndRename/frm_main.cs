using System;
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
            dgv_files.Columns[dgv_Sortedby.Index].ValueType = typeof(DateTime);
            dgv_files.Columns[dgv_newfilename.Index].ValueType = typeof(string);

            rad_sortAscending.Checked = true;
            rad_sortDescending.Checked = false;

            // DEBUG
            currentDirectory = @"D:\Test";
            UpdateFilesList();
        }

        private void LoadDirectoryFiles()
        {
            // Clear rows
            dgv_files.Rows.Clear();
            string fileName = "";

            if (files.Length <= 0)
                return;

            foreach(string f in files)
            {
                fileName = Path.GetFileName(f);
                dgv_files.Rows.Add(new object[] {fileName, File.GetLastWriteTime(f), ""});
                dgv_files.Sort(
                    dgv_files.Columns[dgv_Sortedby.Index], 
                    rad_sortAscending.Checked ? ListSortDirection.Ascending : ListSortDirection.Descending
                );
            }

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
    }
}
