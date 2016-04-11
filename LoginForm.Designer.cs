namespace LoginForm
{
    partial class LoginForm
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
            this.grouplogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_uname = new MetroFramework.Controls.MetroTextBox();
            this.txt_pword = new MetroFramework.Controls.MetroTextBox();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_5 = new MetroFramework.Controls.MetroButton();
            this.btn_3 = new MetroFramework.Controls.MetroButton();
            this.btn_6 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.btn_8 = new MetroFramework.Controls.MetroButton();
            this.btn_2 = new MetroFramework.Controls.MetroButton();
            this.btn_7 = new MetroFramework.Controls.MetroButton();
            this.btn_4 = new MetroFramework.Controls.MetroButton();
            this.btn_1 = new MetroFramework.Controls.MetroButton();
            this.grouplogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grouplogin
            // 
            this.grouplogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grouplogin.Controls.Add(this.metroPanel1);
            this.grouplogin.Controls.Add(this.pictureBox1);
            this.grouplogin.Controls.Add(this.txt_uname);
            this.grouplogin.Controls.Add(this.txt_pword);
            this.grouplogin.Controls.Add(this.btn_login);
            this.grouplogin.Controls.Add(this.btn_cancel);
            this.grouplogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grouplogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grouplogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouplogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grouplogin.Location = new System.Drawing.Point(20, 30);
            this.grouplogin.Name = "grouplogin";
            this.grouplogin.Size = new System.Drawing.Size(386, 192);
            this.grouplogin.TabIndex = 0;
            this.grouplogin.TabStop = false;
            this.grouplogin.Text = "Enter Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForm.Properties.Resources.lock_512;
            this.pictureBox1.Location = new System.Drawing.Point(19, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txt_uname
            // 
            // 
            // 
            // 
            this.txt_uname.CustomButton.Image = null;
            this.txt_uname.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txt_uname.CustomButton.Name = "";
            this.txt_uname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_uname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_uname.CustomButton.TabIndex = 1;
            this.txt_uname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_uname.CustomButton.UseSelectable = true;
            this.txt_uname.CustomButton.Visible = false;
            this.txt_uname.DisplayIcon = true;
            this.txt_uname.Icon = global::LoginForm.Properties.Resources.user;
            this.txt_uname.IconRight = true;
            this.txt_uname.Lines = new string[0];
            this.txt_uname.Location = new System.Drawing.Point(168, 45);
            this.txt_uname.MaxLength = 30;
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.PasswordChar = '\0';
            this.txt_uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_uname.SelectedText = "";
            this.txt_uname.SelectionLength = 0;
            this.txt_uname.SelectionStart = 0;
            this.txt_uname.Size = new System.Drawing.Size(199, 23);
            this.txt_uname.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_uname.TabIndex = 0;
            this.txt_uname.UseSelectable = true;
            this.txt_uname.UseStyleColors = true;
            this.txt_uname.WaterMark = "Username";
            this.txt_uname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_uname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_pword
            // 
            // 
            // 
            // 
            this.txt_pword.CustomButton.Image = null;
            this.txt_pword.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txt_pword.CustomButton.Name = "";
            this.txt_pword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pword.CustomButton.TabIndex = 1;
            this.txt_pword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pword.CustomButton.UseSelectable = true;
            this.txt_pword.CustomButton.Visible = false;
            this.txt_pword.DisplayIcon = true;
            this.txt_pword.Icon = global::LoginForm.Properties.Resources.Key_25;
            this.txt_pword.IconRight = true;
            this.txt_pword.Lines = new string[0];
            this.txt_pword.Location = new System.Drawing.Point(168, 74);
            this.txt_pword.MaxLength = 30;
            this.txt_pword.Name = "txt_pword";
            this.txt_pword.PasswordChar = '*';
            this.txt_pword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pword.SelectedText = "";
            this.txt_pword.SelectionLength = 0;
            this.txt_pword.SelectionStart = 0;
            this.txt_pword.Size = new System.Drawing.Size(199, 23);
            this.txt_pword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_pword.TabIndex = 1;
            this.txt_pword.UseSelectable = true;
            this.txt_pword.UseStyleColors = true;
            this.txt_pword.WaterMark = "Password";
            this.txt_pword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_login
            // 
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_login.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_login.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_login.Location = new System.Drawing.Point(168, 133);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(93, 34);
            this.btn_login.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_cancel.Location = new System.Drawing.Point(278, 133);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 34);
            this.btn_cancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanel1.Controls.Add(this.btn_5);
            this.metroPanel1.Controls.Add(this.btn_3);
            this.metroPanel1.Controls.Add(this.btn_6);
            this.metroPanel1.Controls.Add(this.metroButton8);
            this.metroPanel1.Controls.Add(this.btn_8);
            this.metroPanel1.Controls.Add(this.btn_2);
            this.metroPanel1.Controls.Add(this.btn_7);
            this.metroPanel1.Controls.Add(this.btn_4);
            this.metroPanel1.Controls.Add(this.btn_1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(19, 21);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(348, 146);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_5.Location = new System.Drawing.Point(116, 54);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(115, 46);
            this.btn_5.TabIndex = 2;
            this.btn_5.Text = "5";
            this.btn_5.UseCustomBackColor = true;
            this.btn_5.UseSelectable = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_3.Location = new System.Drawing.Point(230, 10);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(115, 45);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseCustomBackColor = true;
            this.btn_3.UseSelectable = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_6.Location = new System.Drawing.Point(230, 54);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(115, 46);
            this.btn_6.TabIndex = 2;
            this.btn_6.Text = "6";
            this.btn_6.UseCustomBackColor = true;
            this.btn_6.UseSelectable = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // metroButton8
            // 
            this.metroButton8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroButton8.Location = new System.Drawing.Point(230, 99);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(115, 44);
            this.metroButton8.TabIndex = 2;
            this.metroButton8.Text = "9";
            this.metroButton8.UseCustomBackColor = true;
            this.metroButton8.UseSelectable = true;
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_8.Location = new System.Drawing.Point(116, 99);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(115, 44);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseCustomBackColor = true;
            this.btn_8.UseSelectable = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_2.Location = new System.Drawing.Point(116, 10);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(115, 45);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseCustomBackColor = true;
            this.btn_2.UseSelectable = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_7.Location = new System.Drawing.Point(3, 99);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(114, 44);
            this.btn_7.TabIndex = 2;
            this.btn_7.Text = "7";
            this.btn_7.UseCustomBackColor = true;
            this.btn_7.UseSelectable = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_4.Location = new System.Drawing.Point(3, 54);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(114, 46);
            this.btn_4.TabIndex = 2;
            this.btn_4.Text = "4";
            this.btn_4.UseCustomBackColor = true;
            this.btn_4.UseSelectable = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_1.Location = new System.Drawing.Point(3, 10);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(114, 45);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = "1";
            this.btn_1.UseCustomBackColor = true;
            this.btn_1.UseSelectable = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 242);
            this.Controls.Add(this.grouplogin);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.grouplogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grouplogin;
        private MetroFramework.Controls.MetroTextBox txt_pword;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroButton btn_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroTextBox txt_uname;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_3;
        private MetroFramework.Controls.MetroButton btn_6;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton btn_8;
        private MetroFramework.Controls.MetroButton btn_5;
        private MetroFramework.Controls.MetroButton btn_2;
        private MetroFramework.Controls.MetroButton btn_7;
        private MetroFramework.Controls.MetroButton btn_4;
        private MetroFramework.Controls.MetroButton btn_1;
    }
}

