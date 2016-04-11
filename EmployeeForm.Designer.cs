namespace LoginForm
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Employee_GB = new System.Windows.Forms.GroupBox();
            this.mcmb_status = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_compid = new System.Windows.Forms.TextBox();
            this.txt_eid = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mlbl_fname = new MetroFramework.Controls.MetroLabel();
            this.mlbl_lname = new MetroFramework.Controls.MetroLabel();
            this.mlbl_status = new MetroFramework.Controls.MetroLabel();
            this.rd_all = new MetroFramework.Controls.MetroRadioButton();
            this.rd_inactive = new MetroFramework.Controls.MetroRadioButton();
            this.rd_active = new MetroFramework.Controls.MetroRadioButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employee_grid = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_GB.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee_GB
            // 
            this.Employee_GB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Employee_GB.Controls.Add(this.mcmb_status);
            this.Employee_GB.Controls.Add(this.metroLabel1);
            this.Employee_GB.Controls.Add(this.label2);
            this.Employee_GB.Controls.Add(this.txt_fname);
            this.Employee_GB.Controls.Add(this.btn_cancel);
            this.Employee_GB.Controls.Add(this.btn_save);
            this.Employee_GB.Controls.Add(this.btn_add);
            this.Employee_GB.Controls.Add(this.txt_compid);
            this.Employee_GB.Controls.Add(this.txt_eid);
            this.Employee_GB.Controls.Add(this.txt_lname);
            this.Employee_GB.Controls.Add(this.label4);
            this.Employee_GB.Controls.Add(this.label3);
            this.Employee_GB.Controls.Add(this.mlbl_fname);
            this.Employee_GB.Controls.Add(this.mlbl_lname);
            this.Employee_GB.Controls.Add(this.mlbl_status);
            this.Employee_GB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employee_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_GB.Location = new System.Drawing.Point(20, 60);
            this.Employee_GB.Margin = new System.Windows.Forms.Padding(4);
            this.Employee_GB.Name = "Employee_GB";
            this.Employee_GB.Padding = new System.Windows.Forms.Padding(4);
            this.Employee_GB.Size = new System.Drawing.Size(1085, 143);
            this.Employee_GB.TabIndex = 1;
            this.Employee_GB.TabStop = false;
            this.Employee_GB.Text = "Employee Details";
            // 
            // mcmb_status
            // 
            this.mcmb_status.FormattingEnabled = true;
            this.mcmb_status.ItemHeight = 23;
            this.mcmb_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.mcmb_status.Location = new System.Drawing.Point(582, 80);
            this.mcmb_status.Name = "mcmb_status";
            this.mcmb_status.PromptText = "Select Status";
            this.mcmb_status.Size = new System.Drawing.Size(138, 29);
            this.mcmb_status.TabIndex = 3;
            this.mcmb_status.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mcmb_status.UseSelectable = true;
            this.mcmb_status.SelectedIndexChanged += new System.EventHandler(this.mcmb_status_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(516, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Status";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firstname";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(214, 44);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fname.MaxLength = 30;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(207, 22);
            this.txt_fname.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Cyan;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::LoginForm.Properties.Resources.Cancel_2_Filled_25;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(938, 93);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 34);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "    Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Cyan;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::LoginForm.Properties.Resources.Save_25;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(938, 55);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(130, 34);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "  Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Cyan;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::LoginForm.Properties.Resources.Add_User_Group_25;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(938, 18);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 34);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "       Add New";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_compid
            // 
            this.txt_compid.Location = new System.Drawing.Point(582, 44);
            this.txt_compid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_compid.MaxLength = 10;
            this.txt_compid.Name = "txt_compid";
            this.txt_compid.Size = new System.Drawing.Size(138, 22);
            this.txt_compid.TabIndex = 2;
            // 
            // txt_eid
            // 
            this.txt_eid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_eid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_eid.Location = new System.Drawing.Point(214, 44);
            this.txt_eid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_eid.Name = "txt_eid";
            this.txt_eid.ReadOnly = true;
            this.txt_eid.Size = new System.Drawing.Size(138, 22);
            this.txt_eid.TabIndex = 0;
            this.txt_eid.Visible = false;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(214, 80);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lname.MaxLength = 30;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(207, 22);
            this.txt_lname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Company ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lastname";
            // 
            // mlbl_fname
            // 
            this.mlbl_fname.AutoSize = true;
            this.mlbl_fname.ForeColor = System.Drawing.Color.Red;
            this.mlbl_fname.Location = new System.Drawing.Point(418, 33);
            this.mlbl_fname.Name = "mlbl_fname";
            this.mlbl_fname.Size = new System.Drawing.Size(15, 19);
            this.mlbl_fname.TabIndex = 0;
            this.mlbl_fname.Text = "*";
            this.mlbl_fname.UseCustomBackColor = true;
            this.mlbl_fname.UseCustomForeColor = true;
            // 
            // mlbl_lname
            // 
            this.mlbl_lname.AutoSize = true;
            this.mlbl_lname.ForeColor = System.Drawing.Color.Red;
            this.mlbl_lname.Location = new System.Drawing.Point(418, 71);
            this.mlbl_lname.Name = "mlbl_lname";
            this.mlbl_lname.Size = new System.Drawing.Size(15, 19);
            this.mlbl_lname.TabIndex = 0;
            this.mlbl_lname.Text = "*";
            this.mlbl_lname.UseCustomBackColor = true;
            this.mlbl_lname.UseCustomForeColor = true;
            // 
            // mlbl_status
            // 
            this.mlbl_status.AutoSize = true;
            this.mlbl_status.ForeColor = System.Drawing.Color.Red;
            this.mlbl_status.Location = new System.Drawing.Point(719, 71);
            this.mlbl_status.Name = "mlbl_status";
            this.mlbl_status.Size = new System.Drawing.Size(15, 19);
            this.mlbl_status.TabIndex = 0;
            this.mlbl_status.Text = "*";
            this.mlbl_status.UseCustomBackColor = true;
            this.mlbl_status.UseCustomForeColor = true;
            // 
            // rd_all
            // 
            this.rd_all.AutoSize = true;
            this.rd_all.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rd_all.Location = new System.Drawing.Point(912, 34);
            this.rd_all.Name = "rd_all";
            this.rd_all.Size = new System.Drawing.Size(40, 19);
            this.rd_all.TabIndex = 0;
            this.rd_all.Text = "All";
            this.rd_all.UseCustomBackColor = true;
            this.rd_all.UseSelectable = true;
            this.rd_all.CheckedChanged += new System.EventHandler(this.rd_all_CheckedChanged);
            // 
            // rd_inactive
            // 
            this.rd_inactive.AutoSize = true;
            this.rd_inactive.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rd_inactive.Location = new System.Drawing.Point(834, 34);
            this.rd_inactive.Name = "rd_inactive";
            this.rd_inactive.Size = new System.Drawing.Size(72, 19);
            this.rd_inactive.TabIndex = 0;
            this.rd_inactive.Text = "Inactive";
            this.rd_inactive.UseCustomBackColor = true;
            this.rd_inactive.UseSelectable = true;
            this.rd_inactive.CheckedChanged += new System.EventHandler(this.rd_inactive_CheckedChanged);
            // 
            // rd_active
            // 
            this.rd_active.AutoSize = true;
            this.rd_active.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rd_active.Location = new System.Drawing.Point(757, 34);
            this.rd_active.Name = "rd_active";
            this.rd_active.Size = new System.Drawing.Size(62, 19);
            this.rd_active.TabIndex = 0;
            this.rd_active.Text = "Active";
            this.rd_active.UseCustomBackColor = true;
            this.rd_active.UseSelectable = true;
            this.rd_active.CheckedChanged += new System.EventHandler(this.rd_active_CheckedChanged);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(119, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.Fuchsia;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // employee_grid
            // 
            this.employee_grid.AllowUserToResizeColumns = false;
            this.employee_grid.AllowUserToResizeRows = false;
            this.employee_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.employee_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employee_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.employee_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.employee_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.employee_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5});
            this.employee_grid.ContextMenuStrip = this.metroContextMenu1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employee_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.employee_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employee_grid.EnableHeadersVisualStyles = false;
            this.employee_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.employee_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.employee_grid.Location = new System.Drawing.Point(20, 203);
            this.employee_grid.Name = "employee_grid";
            this.employee_grid.ReadOnly = true;
            this.employee_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.employee_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employee_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employee_grid.Size = new System.Drawing.Size(1085, 431);
            this.employee_grid.Style = MetroFramework.MetroColorStyle.Teal;
            this.employee_grid.TabIndex = 0;
            this.employee_grid.TabStop = false;
            this.employee_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_grid_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Firstname";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lastname";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Company ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 654);
            this.ContextMenuStrip = this.metroContextMenu1;
            this.ControlBox = false;
            this.Controls.Add(this.employee_grid);
            this.Controls.Add(this.rd_all);
            this.Controls.Add(this.Employee_GB);
            this.Controls.Add(this.rd_inactive);
            this.Controls.Add(this.rd_active);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Movable = false;
            this.Name = "EmployeeForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.EmployeeForm_Load_1);
            this.Employee_GB.ResumeLayout(false);
            this.Employee_GB.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Employee_GB;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_compid;
        private System.Windows.Forms.TextBox txt_eid;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private MetroFramework.Controls.MetroRadioButton rd_inactive;
        private MetroFramework.Controls.MetroRadioButton rd_active;
        private MetroFramework.Controls.MetroRadioButton rd_all;
        private MetroFramework.Controls.MetroLabel mlbl_lname;
        private MetroFramework.Controls.MetroLabel mlbl_fname;
        private MetroFramework.Controls.MetroComboBox mcmb_status;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroLabel mlbl_status;
        public MetroFramework.Controls.MetroGrid employee_grid;
    }
}