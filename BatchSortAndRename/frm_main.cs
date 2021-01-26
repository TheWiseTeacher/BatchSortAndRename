using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            // Append version to form title
            this.Text = this.Text + " v" + Application.ProductVersion;

            // Hide dummy button behind the files table
            btn_dummy.SendToBack();

            dgv_files.Columns[dgv_filename.Index].ValueType = typeof(string);
            dgv_files.Columns[dgv_newfilename.Index].ValueType = typeof(string);

            // Default selected values
            rad_sortDateModified.Checked = rad_sortAscending.Checked = true;
            cb_enableLog.Checked = true;

            // Default unchecked radio
            rad_sortDateCreated.Checked = rad_sortType.Checked = rad_sortName.Checked = 
                rad_sortSize.Checked = rad_sortDescending.Checked = false;
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

            foreach (string f in files)
            {
                // Update list of files
                fileName = Path.GetFileName(f);

                if (fileName.StartsWith("_bsnr_"))
                    continue;

                if (rad_sortDateModified.Checked)
                    sortingValue = File.GetLastWriteTime(f);

                if (rad_sortDateCreated.Checked)
                    sortingValue = File.GetCreationTime(f);

                if(rad_sortType.Checked)
                    sortingValue = Path.GetExtension(f);

                if(rad_sortSize.Checked)
                    sortingValue = new FileInfo(f).Length;

                if(rad_sortName.Checked)
                    sortingValue = Path.GetFileNameWithoutExtension(f);

                dgv_files.Rows.Add(new object[] {fileName, sortingValue, ""});

                dgv_files.Sort(
                    dgv_files.Columns[dgv_Sortedby.Index], 
                    rad_sortAscending.Checked ? ListSortDirection.Ascending : ListSortDirection.Descending
                );
            }

            // Size is independent since we skip our logs now
            lab_numFiles.Text = $"{dgv_files.Rows.Count} Files";
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
            if (!Directory.Exists(currentDirectory))
                return;

            tb_directory.Text = currentDirectory;
            files = Directory.GetFiles(currentDirectory);
            LoadDirectoryFiles();
        }

        private void btn_selectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the working folder where your files you want to batch rename are located :";
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                fbd.SelectedPath = currentDirectory;

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

            if (rad_sortName.Checked)
            { 
                dgv_Sortedby.HeaderText = "Name";
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

        private void btn_process_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;

            if (dgv_files.Rows.Count <= 0)
            {
                MessageBox.Show("Nothing to process !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update progress bar maximum
            pb_mainProgress.Maximum = dgv_files.Rows.Count * 2;

            // Let's save a history file too
            if (cb_enableLog.Checked)
            {
                string logFile = currentDirectory + "\\_bsnr_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".log";
                sw = File.CreateText(logFile);

                if(!File.Exists(logFile))
                {
                    if (MessageBox.Show("The log file was not created, do you want to continue without a log of name changes ?",
                        "Something is wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                }
            }

            try
            {
                foreach (DataGridViewRow r in dgv_files.Rows)
                {
                    
                    File.Move(
                        // Source file
                        currentDirectory + "\\" + r.Cells[dgv_filename.Index].Value,

                        // Add this extension to prevent overwriting something else (still not safe at all - simple program)
                        currentDirectory + "\\" + r.Cells[dgv_newfilename.Index].Value + "._snr_"
                    );
                    
                    // Increment progress bar
                    pb_mainProgress.Value++;
                }

                foreach (DataGridViewRow r in dgv_files.Rows)
                {
                    
                    File.Move(
                        // Source file now as renamed before using the (._snr_) extension
                        currentDirectory + "\\" + r.Cells[dgv_newfilename.Index].Value + "._snr_",

                        // Now safely rename files as they should be
                        currentDirectory + "\\" + r.Cells[dgv_newfilename.Index].Value
                    );
                    
                    // Log file old name
                    if(cb_enableLog.Checked && sw != null)
                        sw.WriteLine(r.Cells[dgv_newfilename.Index].Value + "  >>>  " + r.Cells[dgv_filename.Index].Value);

                    // Increment progress bar
                    pb_mainProgress.Value++;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error renaming files !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pb_mainProgress.Value = 0;
                return;
            }

            pb_mainProgress.Value = 0;

            if (cb_enableLog.Checked && sw != null)
                sw.Close();

            MessageBox.Show(
                "All files renamed successfully!\nThe program will reload current directory files!", 
                "Job's done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Now everything is renamed so let's reload the directory
            UpdateFilesList();
        }

        private void tsm_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Tool developed by TheWiseTeacher, 2021 \n" +
                "Tool Icon by DiemenDesign",
                "About tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenLink(string link)
        {
            Process myProcess = new Process();

            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = link;
                myProcess.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't open link : " + e.Message);
            }

        }

        private void tsm_github_Click(object sender, EventArgs e)
        {
            OpenLink("https://github.com/TheWiseTeacher/BatchSortAndRename");
        }

        private void tsm_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_directory_Validated(object sender, EventArgs e)
        {
            if(Directory.Exists(tb_directory.Text))
            {
                // Clean the user written path of course
                tb_directory.Text = Path.GetFullPath(tb_directory.Text).TrimEnd('\\', '/');
                currentDirectory = tb_directory.Text;
                UpdateFilesList();
            }
            else
            {
                tb_directory.Text = currentDirectory;
            }
        }
    }
}
