namespace LoginForm
{
    partial class AddEmployee
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
            this.Employee_GB = new System.Windows.Forms.GroupBox();
            this.mcmb_status = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_compid = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mlbl_lname = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mlbl_status = new MetroFramework.Controls.MetroLabel();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_eid = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_fname = new MetroFramework.Controls.MetroLabel();
            this.Employee_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employee_GB
            // 
            this.Employee_GB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Employee_GB.Controls.Add(this.mcmb_status);
            this.Employee_GB.Controls.Add(this.metroLabel1);
            this.Employee_GB.Controls.Add(this.label2);
            this.Employee_GB.Controls.Add(this.btn_cancel);
            this.Employee_GB.Controls.Add(this.btn_save);
            this.Employee_GB.Controls.Add(this.txt_compid);
            this.Employee_GB.Controls.Add(this.txt_lname);
            this.Employee_GB.Controls.Add(this.label4);
            this.Employee_GB.Controls.Add(this.label3);
            this.Employee_GB.Controls.Add(this.mlbl_lname);
            this.Employee_GB.Controls.Add(this.metroLabel2);
            this.Employee_GB.Controls.Add(this.mlbl_status);
            this.Employee_GB.Controls.Add(this.txt_fname);
            this.Employee_GB.Controls.Add(this.txt_eid);
            this.Employee_GB.Controls.Add(this.mlbl_fname);
            this.Employee_GB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employee_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_GB.Location = new System.Drawing.Point(20, 30);
            this.Employee_GB.Margin = new System.Windows.Forms.Padding(4);
            this.Employee_GB.Name = "Employee_GB";
            this.Employee_GB.Padding = new System.Windows.Forms.Padding(4);
            this.Employee_GB.Size = new System.Drawing.Size(890, 143);
            this.Employee_GB.TabIndex = 2;
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
            this.mcmb_status.Location = new System.Drawing.Point(499, 70);
            this.mcmb_status.Name = "mcmb_status";
            this.mcmb_status.PromptText = "Select Status";
            this.mcmb_status.Size = new System.Drawing.Size(138, 29);
            this.mcmb_status.TabIndex = 3;
            this.mcmb_status.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mcmb_status.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(433, 73);
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
            this.label2.Location = new System.Drawing.Point(65, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firstname";
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
            this.btn_cancel.Location = new System.Drawing.Point(736, 64);
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
            this.btn_save.Location = new System.Drawing.Point(736, 26);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(130, 34);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "  Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_compid
            // 
            this.txt_compid.Location = new System.Drawing.Point(499, 34);
            this.txt_compid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_compid.MaxLength = 10;
            this.txt_compid.Name = "txt_compid";
            this.txt_compid.Size = new System.Drawing.Size(138, 22);
            this.txt_compid.TabIndex = 2;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(155, 77);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lname.MaxLength = 30;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(207, 22);
            this.txt_lname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Company ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lastname";
            // 
            // mlbl_lname
            // 
            this.mlbl_lname.AutoSize = true;
            this.mlbl_lname.ForeColor = System.Drawing.Color.Red;
            this.mlbl_lname.Location = new System.Drawing.Point(359, 68);
            this.mlbl_lname.Name = "mlbl_lname";
            this.mlbl_lname.Size = new System.Drawing.Size(15, 19);
            this.mlbl_lname.TabIndex = 0;
            this.mlbl_lname.Text = "*";
            this.mlbl_lname.UseCustomBackColor = true;
            this.mlbl_lname.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(636, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(15, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "*";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // mlbl_status
            // 
            this.mlbl_status.AutoSize = true;
            this.mlbl_status.ForeColor = System.Drawing.Color.Red;
            this.mlbl_status.Location = new System.Drawing.Point(636, 61);
            this.mlbl_status.Name = "mlbl_status";
            this.mlbl_status.Size = new System.Drawing.Size(15, 19);
            this.mlbl_status.TabIndex = 0;
            this.mlbl_status.Text = "*";
            this.mlbl_status.UseCustomBackColor = true;
            this.mlbl_status.UseCustomForeColor = true;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(155, 41);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fname.MaxLength = 30;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(207, 22);
            this.txt_fname.TabIndex = 0;
            // 
            // txt_eid
            // 
            // 
            // 
            // 
            this.txt_eid.CustomButton.Image = null;
            this.txt_eid.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txt_eid.CustomButton.Name = "";
            this.txt_eid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_eid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_eid.CustomButton.TabIndex = 1;
            this.txt_eid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_eid.CustomButton.UseSelectable = true;
            this.txt_eid.CustomButton.Visible = false;
            this.txt_eid.Enabled = false;
            this.txt_eid.Lines = new string[0];
            this.txt_eid.Location = new System.Drawing.Point(155, 40);
            this.txt_eid.MaxLength = 32767;
            this.txt_eid.Name = "txt_eid";
            this.txt_eid.PasswordChar = '\0';
            this.txt_eid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_eid.SelectedText = "";
            this.txt_eid.SelectionLength = 0;
            this.txt_eid.SelectionStart = 0;
            this.txt_eid.Size = new System.Drawing.Size(75, 23);
            this.txt_eid.TabIndex = 7;
            this.txt_eid.UseSelectable = true;
            this.txt_eid.Visible = false;
            this.txt_eid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_eid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbl_fname
            // 
            this.mlbl_fname.AutoSize = true;
            this.mlbl_fname.ForeColor = System.Drawing.Color.Red;
            this.mlbl_fname.Location = new System.Drawing.Point(359, 30);
            this.mlbl_fname.Name = "mlbl_fname";
            this.mlbl_fname.Size = new System.Drawing.Size(15, 19);
            this.mlbl_fname.TabIndex = 0;
            this.mlbl_fname.Text = "*";
            this.mlbl_fname.UseCustomBackColor = true;
            this.mlbl_fname.UseCustomForeColor = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 196);
            this.Controls.Add(this.Employee_GB);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AddEmployee";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.Employee_GB.ResumeLayout(false);
            this.Employee_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Employee_GB;
        private MetroFramework.Controls.MetroComboBox mcmb_status;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_compid;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroLabel mlbl_fname;
        private MetroFramework.Controls.MetroLabel mlbl_lname;
        private MetroFramework.Controls.MetroLabel mlbl_status;
        private MetroFramework.Controls.MetroTextBox txt_eid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}