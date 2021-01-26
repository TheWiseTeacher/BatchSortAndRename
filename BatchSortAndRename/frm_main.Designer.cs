
namespace BatchSortAndRename
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_files = new System.Windows.Forms.DataGridView();
            this.dgv_filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Sortedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_newfilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_selectFolder = new System.Windows.Forms.Button();
            this.rad_sortAscending = new System.Windows.Forms.RadioButton();
            this.rad_sortDescending = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_directory = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.num_filename_numberPadding = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_extension = new System.Windows.Forms.CheckBox();
            this.tb_extension = new System.Windows.Forms.TextBox();
            this.tb_filename_end = new System.Windows.Forms.TextBox();
            this.tb_filename_begin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_filename_numberStartFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rad_sortSize = new System.Windows.Forms.RadioButton();
            this.rad_sortType = new System.Windows.Forms.RadioButton();
            this.rad_sortDateCreated = new System.Windows.Forms.RadioButton();
            this.rad_sortDateModified = new System.Windows.Forms.RadioButton();
            this.btn_process = new System.Windows.Forms.Button();
            this.formStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lab_task = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb_mainProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lab_numFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.cb_enableLog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_files)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_filename_numberPadding)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_filename_numberStartFrom)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.formStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_files
            // 
            this.dgv_files.AllowUserToAddRows = false;
            this.dgv_files.AllowUserToDeleteRows = false;
            this.dgv_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_files.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_files.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_files.ColumnHeadersHeight = 24;
            this.dgv_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_filename,
            this.dgv_Sortedby,
            this.dgv_newfilename});
            this.dgv_files.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_files.Location = new System.Drawing.Point(351, 12);
            this.dgv_files.MultiSelect = false;
            this.dgv_files.Name = "dgv_files";
            this.dgv_files.ReadOnly = true;
            this.dgv_files.RowHeadersVisible = false;
            this.dgv_files.RowTemplate.Height = 24;
            this.dgv_files.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_files.ShowEditingIcon = false;
            this.dgv_files.Size = new System.Drawing.Size(461, 406);
            this.dgv_files.TabIndex = 0;
            this.dgv_files.TabStop = false;
            // 
            // dgv_filename
            // 
            this.dgv_filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_filename.HeaderText = "File Name";
            this.dgv_filename.Name = "dgv_filename";
            this.dgv_filename.ReadOnly = true;
            this.dgv_filename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgv_Sortedby
            // 
            this.dgv_Sortedby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Sortedby.HeaderText = "SortedBy";
            this.dgv_Sortedby.Name = "dgv_Sortedby";
            this.dgv_Sortedby.ReadOnly = true;
            this.dgv_Sortedby.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgv_newfilename
            // 
            this.dgv_newfilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_newfilename.HeaderText = "New File Name";
            this.dgv_newfilename.Name = "dgv_newfilename";
            this.dgv_newfilename.ReadOnly = true;
            this.dgv_newfilename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btn_selectFolder
            // 
            this.btn_selectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selectFolder.Location = new System.Drawing.Point(252, 47);
            this.btn_selectFolder.Name = "btn_selectFolder";
            this.btn_selectFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_selectFolder.TabIndex = 2;
            this.btn_selectFolder.Text = "Select folder";
            this.btn_selectFolder.UseVisualStyleBackColor = true;
            this.btn_selectFolder.Click += new System.EventHandler(this.btn_selectFolder_Click);
            // 
            // rad_sortAscending
            // 
            this.rad_sortAscending.AutoSize = true;
            this.rad_sortAscending.Location = new System.Drawing.Point(9, 19);
            this.rad_sortAscending.Name = "rad_sortAscending";
            this.rad_sortAscending.Size = new System.Drawing.Size(105, 17);
            this.rad_sortAscending.TabIndex = 3;
            this.rad_sortAscending.TabStop = true;
            this.rad_sortAscending.Text = "Ascending (A-Z)";
            this.rad_sortAscending.UseVisualStyleBackColor = true;
            this.rad_sortAscending.CheckedChanged += new System.EventHandler(this.rad_sortAscending_CheckedChanged);
            // 
            // rad_sortDescending
            // 
            this.rad_sortDescending.AutoSize = true;
            this.rad_sortDescending.Location = new System.Drawing.Point(171, 21);
            this.rad_sortDescending.Name = "rad_sortDescending";
            this.rad_sortDescending.Size = new System.Drawing.Size(112, 17);
            this.rad_sortDescending.TabIndex = 3;
            this.rad_sortDescending.TabStop = true;
            this.rad_sortDescending.Text = "Descending (Z-A)";
            this.rad_sortDescending.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_sortDescending);
            this.groupBox2.Controls.Add(this.rad_sortAscending);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 45);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorting direction";
            // 
            // tb_directory
            // 
            this.tb_directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_directory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_directory.Location = new System.Drawing.Point(6, 21);
            this.tb_directory.Name = "tb_directory";
            this.tb_directory.ReadOnly = true;
            this.tb_directory.Size = new System.Drawing.Size(321, 22);
            this.tb_directory.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_enableLog);
            this.groupBox1.Controls.Add(this.tb_directory);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.btn_selectFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Working directory";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(171, 47);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // num_filename_numberPadding
            // 
            this.num_filename_numberPadding.Location = new System.Drawing.Point(171, 42);
            this.num_filename_numberPadding.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_filename_numberPadding.Name = "num_filename_numberPadding";
            this.num_filename_numberPadding.Size = new System.Drawing.Size(156, 22);
            this.num_filename_numberPadding.TabIndex = 2;
            this.num_filename_numberPadding.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_filename_numberPadding.ValueChanged += new System.EventHandler(this.num_filename_number_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number padding";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_extension);
            this.groupBox3.Controls.Add(this.tb_extension);
            this.groupBox3.Controls.Add(this.tb_filename_end);
            this.groupBox3.Controls.Add(this.tb_filename_begin);
            this.groupBox3.Controls.Add(this.num_filename_numberPadding);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.num_filename_numberStartFrom);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 151);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Naming configuration";
            // 
            // cb_extension
            // 
            this.cb_extension.Location = new System.Drawing.Point(9, 122);
            this.cb_extension.Name = "cb_extension";
            this.cb_extension.Size = new System.Drawing.Size(156, 20);
            this.cb_extension.TabIndex = 5;
            this.cb_extension.Text = "Use same file extension";
            this.cb_extension.UseVisualStyleBackColor = true;
            this.cb_extension.CheckedChanged += new System.EventHandler(this.cb_extension_CheckedChanged);
            // 
            // tb_extension
            // 
            this.tb_extension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_extension.Enabled = false;
            this.tb_extension.Location = new System.Drawing.Point(171, 122);
            this.tb_extension.Name = "tb_extension";
            this.tb_extension.Size = new System.Drawing.Size(156, 22);
            this.tb_extension.TabIndex = 6;
            this.tb_extension.Validated += new System.EventHandler(this.tb_extension_Validated);
            // 
            // tb_filename_end
            // 
            this.tb_filename_end.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filename_end.Location = new System.Drawing.Point(171, 96);
            this.tb_filename_end.Name = "tb_filename_end";
            this.tb_filename_end.Size = new System.Drawing.Size(156, 22);
            this.tb_filename_end.TabIndex = 4;
            this.tb_filename_end.Validated += new System.EventHandler(this.tb_filename_Validated);
            // 
            // tb_filename_begin
            // 
            this.tb_filename_begin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filename_begin.Location = new System.Drawing.Point(171, 70);
            this.tb_filename_begin.Name = "tb_filename_begin";
            this.tb_filename_begin.Size = new System.Drawing.Size(156, 22);
            this.tb_filename_begin.TabIndex = 3;
            this.tb_filename_begin.Validated += new System.EventHandler(this.tb_filename_Validated);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "File name should end with";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "File name should begin with";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_filename_numberStartFrom
            // 
            this.num_filename_numberStartFrom.Location = new System.Drawing.Point(171, 16);
            this.num_filename_numberStartFrom.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.num_filename_numberStartFrom.Name = "num_filename_numberStartFrom";
            this.num_filename_numberStartFrom.Size = new System.Drawing.Size(156, 22);
            this.num_filename_numberStartFrom.TabIndex = 1;
            this.num_filename_numberStartFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_filename_numberStartFrom.ValueChanged += new System.EventHandler(this.num_filename_number_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number padding";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rad_sortSize);
            this.groupBox4.Controls.Add(this.rad_sortType);
            this.groupBox4.Controls.Add(this.rad_sortDateCreated);
            this.groupBox4.Controls.Add(this.rad_sortDateModified);
            this.groupBox4.Location = new System.Drawing.Point(12, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 66);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sort by";
            // 
            // rad_sortSize
            // 
            this.rad_sortSize.AutoSize = true;
            this.rad_sortSize.Location = new System.Drawing.Point(171, 42);
            this.rad_sortSize.Name = "rad_sortSize";
            this.rad_sortSize.Size = new System.Drawing.Size(45, 17);
            this.rad_sortSize.TabIndex = 3;
            this.rad_sortSize.TabStop = true;
            this.rad_sortSize.Text = "Size";
            this.rad_sortSize.UseVisualStyleBackColor = true;
            this.rad_sortSize.CheckedChanged += new System.EventHandler(this.rad_sortBy_CheckedChanged);
            // 
            // rad_sortType
            // 
            this.rad_sortType.AutoSize = true;
            this.rad_sortType.Location = new System.Drawing.Point(9, 42);
            this.rad_sortType.Name = "rad_sortType";
            this.rad_sortType.Size = new System.Drawing.Size(68, 17);
            this.rad_sortType.TabIndex = 3;
            this.rad_sortType.TabStop = true;
            this.rad_sortType.Text = "File type";
            this.rad_sortType.UseVisualStyleBackColor = true;
            this.rad_sortType.CheckedChanged += new System.EventHandler(this.rad_sortBy_CheckedChanged);
            // 
            // rad_sortDateCreated
            // 
            this.rad_sortDateCreated.AutoSize = true;
            this.rad_sortDateCreated.Location = new System.Drawing.Point(171, 19);
            this.rad_sortDateCreated.Name = "rad_sortDateCreated";
            this.rad_sortDateCreated.Size = new System.Drawing.Size(90, 17);
            this.rad_sortDateCreated.TabIndex = 3;
            this.rad_sortDateCreated.TabStop = true;
            this.rad_sortDateCreated.Text = "Date created";
            this.rad_sortDateCreated.UseVisualStyleBackColor = true;
            this.rad_sortDateCreated.CheckedChanged += new System.EventHandler(this.rad_sortBy_CheckedChanged);
            // 
            // rad_sortDateModified
            // 
            this.rad_sortDateModified.AutoSize = true;
            this.rad_sortDateModified.Location = new System.Drawing.Point(9, 19);
            this.rad_sortDateModified.Name = "rad_sortDateModified";
            this.rad_sortDateModified.Size = new System.Drawing.Size(98, 17);
            this.rad_sortDateModified.TabIndex = 3;
            this.rad_sortDateModified.TabStop = true;
            this.rad_sortDateModified.Text = "Date modified";
            this.rad_sortDateModified.UseVisualStyleBackColor = true;
            this.rad_sortDateModified.CheckedChanged += new System.EventHandler(this.rad_sortBy_CheckedChanged);
            // 
            // btn_process
            // 
            this.btn_process.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_process.Location = new System.Drawing.Point(12, 375);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(333, 44);
            this.btn_process.TabIndex = 5;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // formStatusStrip
            // 
            this.formStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lab_task,
            this.pb_mainProgress,
            this.lab_numFiles});
            this.formStatusStrip.Location = new System.Drawing.Point(0, 426);
            this.formStatusStrip.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.formStatusStrip.Name = "formStatusStrip";
            this.formStatusStrip.Size = new System.Drawing.Size(824, 22);
            this.formStatusStrip.TabIndex = 6;
            this.formStatusStrip.Text = "statusStrip1";
            // 
            // lab_task
            // 
            this.lab_task.Name = "lab_task";
            this.lab_task.Size = new System.Drawing.Size(621, 17);
            this.lab_task.Spring = true;
            this.lab_task.Text = "Ready";
            this.lab_task.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_mainProgress
            // 
            this.pb_mainProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb_mainProgress.Name = "pb_mainProgress";
            this.pb_mainProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // lab_numFiles
            // 
            this.lab_numFiles.Name = "lab_numFiles";
            this.lab_numFiles.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lab_numFiles.Size = new System.Drawing.Size(49, 17);
            this.lab_numFiles.Text = "0 Files";
            this.lab_numFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_enableLog
            // 
            this.cb_enableLog.Location = new System.Drawing.Point(6, 49);
            this.cb_enableLog.Name = "cb_enableLog";
            this.cb_enableLog.Size = new System.Drawing.Size(159, 20);
            this.cb_enableLog.TabIndex = 5;
            this.cb_enableLog.Text = "Log name changes";
            this.cb_enableLog.UseVisualStyleBackColor = true;
            this.cb_enableLog.CheckedChanged += new System.EventHandler(this.cb_extension_CheckedChanged);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 448);
            this.Controls.Add(this.formStatusStrip);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_files);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(840, 486);
            this.Name = "frm_main";
            this.Text = "Batch Sort And Rename v1.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_files)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_filename_numberPadding)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_filename_numberStartFrom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.formStatusStrip.ResumeLayout(false);
            this.formStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_files;
        private System.Windows.Forms.Button btn_selectFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Sortedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_newfilename;
        private System.Windows.Forms.RadioButton rad_sortAscending;
        private System.Windows.Forms.RadioButton rad_sortDescending;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_directory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_filename_numberPadding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_filename_begin;
        private System.Windows.Forms.TextBox tb_filename_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_extension;
        private System.Windows.Forms.TextBox tb_extension;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.NumericUpDown num_filename_numberStartFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rad_sortDateCreated;
        private System.Windows.Forms.RadioButton rad_sortDateModified;
        private System.Windows.Forms.RadioButton rad_sortType;
        private System.Windows.Forms.RadioButton rad_sortSize;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.StatusStrip formStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lab_task;
        private System.Windows.Forms.ToolStripProgressBar pb_mainProgress;
        private System.Windows.Forms.ToolStripStatusLabel lab_numFiles;
        private System.Windows.Forms.CheckBox cb_enableLog;
    }
}

