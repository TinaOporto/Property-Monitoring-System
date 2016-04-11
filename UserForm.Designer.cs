namespace LoginForm
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_user = new System.Windows.Forms.GroupBox();
            this.mcmb_status = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mchkb_passchar = new MetroFramework.Controls.MetroCheckBox();
            this.mcmb_acct = new MetroFramework.Controls.MetroComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtpword = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_uid = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mlbl_uname = new MetroFramework.Controls.MetroLabel();
            this.mlbl_pword = new MetroFramework.Controls.MetroLabel();
            this.mrd_all = new MetroFramework.Controls.MetroRadioButton();
            this.mrd_inactive = new MetroFramework.Controls.MetroRadioButton();
            this.mrd_active = new MetroFramework.Controls.MetroRadioButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.user_grid = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_user.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_user
            // 
            this.groupBox_user.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox_user.Controls.Add(this.mcmb_status);
            this.groupBox_user.Controls.Add(this.metroLabel1);
            this.groupBox_user.Controls.Add(this.mchkb_passchar);
            this.groupBox_user.Controls.Add(this.mcmb_acct);
            this.groupBox_user.Controls.Add(this.btn_cancel);
            this.groupBox_user.Controls.Add(this.btn_save);
            this.groupBox_user.Controls.Add(this.btn_add);
            this.groupBox_user.Controls.Add(this.txtlname);
            this.groupBox_user.Controls.Add(this.txtfname);
            this.groupBox_user.Controls.Add(this.txtpword);
            this.groupBox_user.Controls.Add(this.txtuname);
            this.groupBox_user.Controls.Add(this.txtuid);
            this.groupBox_user.Controls.Add(this.label6);
            this.groupBox_user.Controls.Add(this.label5);
            this.groupBox_user.Controls.Add(this.label4);
            this.groupBox_user.Controls.Add(this.label3);
            this.groupBox_user.Controls.Add(this.label2);
            this.groupBox_user.Controls.Add(this.lbl_uid);
            this.groupBox_user.Controls.Add(this.metroLabel5);
            this.groupBox_user.Controls.Add(this.metroLabel4);
            this.groupBox_user.Controls.Add(this.metroLabel3);
            this.groupBox_user.Controls.Add(this.metroLabel2);
            this.groupBox_user.Controls.Add(this.mlbl_uname);
            this.groupBox_user.Controls.Add(this.mlbl_pword);
            this.groupBox_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_user.Location = new System.Drawing.Point(20, 60);
            this.groupBox_user.Name = "groupBox_user";
            this.groupBox_user.Size = new System.Drawing.Size(1085, 153);
            this.groupBox_user.TabIndex = 0;
            this.groupBox_user.TabStop = false;
            this.groupBox_user.Text = "User Details";
            // 
            // mcmb_status
            // 
            this.mcmb_status.FormattingEnabled = true;
            this.mcmb_status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mcmb_status.ItemHeight = 23;
            this.mcmb_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.mcmb_status.Location = new System.Drawing.Point(748, 64);
            this.mcmb_status.Name = "mcmb_status";
            this.mcmb_status.PromptText = "Select Status";
            this.mcmb_status.Size = new System.Drawing.Size(119, 29);
            this.mcmb_status.TabIndex = 5;
            this.mcmb_status.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(695, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Status";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // mchkb_passchar
            // 
            this.mchkb_passchar.AutoSize = true;
            this.mchkb_passchar.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mchkb_passchar.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mchkb_passchar.Location = new System.Drawing.Point(139, 114);
            this.mchkb_passchar.Name = "mchkb_passchar";
            this.mchkb_passchar.Size = new System.Drawing.Size(120, 19);
            this.mchkb_passchar.Style = MetroFramework.MetroColorStyle.Blue;
            this.mchkb_passchar.TabIndex = 9;
            this.mchkb_passchar.TabStop = false;
            this.mchkb_passchar.Text = "Show Password";
            this.mchkb_passchar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mchkb_passchar.UseCustomBackColor = true;
            this.mchkb_passchar.UseSelectable = true;
            this.mchkb_passchar.CheckedChanged += new System.EventHandler(this.mchkb_passchar_CheckedChanged);
            // 
            // mcmb_acct
            // 
            this.mcmb_acct.FormattingEnabled = true;
            this.mcmb_acct.ItemHeight = 23;
            this.mcmb_acct.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.mcmb_acct.Location = new System.Drawing.Point(472, 97);
            this.mcmb_acct.Name = "mcmb_acct";
            this.mcmb_acct.PromptText = "Select Account Type";
            this.mcmb_acct.Size = new System.Drawing.Size(194, 29);
            this.mcmb_acct.TabIndex = 4;
            this.mcmb_acct.UseSelectable = true;
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
            this.btn_cancel.Location = new System.Drawing.Point(944, 100);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(127, 31);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
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
            this.btn_save.Location = new System.Drawing.Point(944, 63);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(127, 31);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
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
            this.btn_add.Image = global::LoginForm.Properties.Resources.Add_User_25;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(944, 26);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 31);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "   Add New";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(472, 63);
            this.txtlname.MaxLength = 30;
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(194, 22);
            this.txtlname.TabIndex = 3;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(472, 27);
            this.txtfname.MaxLength = 30;
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(194, 22);
            this.txtfname.TabIndex = 2;
            // 
            // txtpword
            // 
            this.txtpword.Location = new System.Drawing.Point(139, 85);
            this.txtpword.MaxLength = 30;
            this.txtpword.Name = "txtpword";
            this.txtpword.Size = new System.Drawing.Size(179, 22);
            this.txtpword.TabIndex = 1;
            this.txtpword.UseSystemPasswordChar = true;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(139, 49);
            this.txtuname.MaxLength = 30;
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(179, 22);
            this.txtuname.TabIndex = 0;
            // 
            // txtuid
            // 
            this.txtuid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtuid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtuid.Location = new System.Drawing.Point(139, 49);
            this.txtuid.Name = "txtuid";
            this.txtuid.ReadOnly = true;
            this.txtuid.Size = new System.Drawing.Size(179, 22);
            this.txtuid.TabIndex = 0;
            this.txtuid.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Account Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.ForeColor = System.Drawing.Color.Black;
            this.lbl_uid.Location = new System.Drawing.Point(51, 55);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(53, 16);
            this.lbl_uid.TabIndex = 0;
            this.lbl_uid.Text = "User ID";
            this.lbl_uid.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Red;
            this.metroLabel5.Location = new System.Drawing.Point(866, 52);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(15, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "*";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Red;
            this.metroLabel4.Location = new System.Drawing.Point(662, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(15, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "*";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(662, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(15, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "*";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(662, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(15, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "*";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // mlbl_uname
            // 
            this.mlbl_uname.AutoSize = true;
            this.mlbl_uname.ForeColor = System.Drawing.Color.Red;
            this.mlbl_uname.Location = new System.Drawing.Point(314, 36);
            this.mlbl_uname.Name = "mlbl_uname";
            this.mlbl_uname.Size = new System.Drawing.Size(15, 19);
            this.mlbl_uname.TabIndex = 12;
            this.mlbl_uname.Text = "*";
            this.mlbl_uname.UseCustomBackColor = true;
            this.mlbl_uname.UseCustomForeColor = true;
            // 
            // mlbl_pword
            // 
            this.mlbl_pword.AutoSize = true;
            this.mlbl_pword.ForeColor = System.Drawing.Color.Red;
            this.mlbl_pword.Location = new System.Drawing.Point(314, 74);
            this.mlbl_pword.Name = "mlbl_pword";
            this.mlbl_pword.Size = new System.Drawing.Size(15, 19);
            this.mlbl_pword.TabIndex = 12;
            this.mlbl_pword.Text = "*";
            this.mlbl_pword.UseCustomBackColor = true;
            this.mlbl_pword.UseCustomForeColor = true;
            // 
            // mrd_all
            // 
            this.mrd_all.AutoSize = true;
            this.mrd_all.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrd_all.Location = new System.Drawing.Point(922, 35);
            this.mrd_all.Name = "mrd_all";
            this.mrd_all.Size = new System.Drawing.Size(40, 19);
            this.mrd_all.TabIndex = 0;
            this.mrd_all.Text = "All";
            this.mrd_all.UseCustomBackColor = true;
            this.mrd_all.UseSelectable = true;
            this.mrd_all.CheckedChanged += new System.EventHandler(this.mrd_all_CheckedChanged);
            // 
            // mrd_inactive
            // 
            this.mrd_inactive.AutoSize = true;
            this.mrd_inactive.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrd_inactive.Location = new System.Drawing.Point(829, 35);
            this.mrd_inactive.Name = "mrd_inactive";
            this.mrd_inactive.Size = new System.Drawing.Size(72, 19);
            this.mrd_inactive.TabIndex = 0;
            this.mrd_inactive.Text = "Inactive";
            this.mrd_inactive.UseCustomBackColor = true;
            this.mrd_inactive.UseSelectable = true;
            this.mrd_inactive.CheckedChanged += new System.EventHandler(this.mrd_inactive_CheckedChanged);
            // 
            // mrd_active
            // 
            this.mrd_active.AutoSize = true;
            this.mrd_active.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrd_active.Location = new System.Drawing.Point(749, 35);
            this.mrd_active.Name = "mrd_active";
            this.mrd_active.Size = new System.Drawing.Size(62, 19);
            this.mrd_active.TabIndex = 0;
            this.mrd_active.Text = "Active";
            this.mrd_active.UseCustomBackColor = true;
            this.mrd_active.UseSelectable = true;
            this.mrd_active.CheckedChanged += new System.EventHandler(this.mrd_active_CheckedChanged);
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
            // user_grid
            // 
            this.user_grid.AllowUserToResizeColumns = false;
            this.user_grid.AllowUserToResizeRows = false;
            this.user_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.user_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.user_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.user_grid.ColumnHeadersHeight = 25;
            this.user_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.user_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.user_grid.ContextMenuStrip = this.metroContextMenu1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.user_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.user_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_grid.EnableHeadersVisualStyles = false;
            this.user_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.user_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.user_grid.Location = new System.Drawing.Point(20, 213);
            this.user_grid.MultiSelect = false;
            this.user_grid.Name = "user_grid";
            this.user_grid.ReadOnly = true;
            this.user_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.user_grid.RowHeadersWidth = 30;
            this.user_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.user_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_grid.Size = new System.Drawing.Size(1085, 421);
            this.user_grid.Style = MetroFramework.MetroColorStyle.Teal;
            this.user_grid.TabIndex = 0;
            this.user_grid.TabStop = false;
            this.user_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_grid_CellClick_2);
            this.user_grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.user_grid_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Firstname";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Lastname";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Account Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 654);
            this.ControlBox = false;
            this.Controls.Add(this.user_grid);
            this.Controls.Add(this.mrd_all);
            this.Controls.Add(this.mrd_inactive);
            this.Controls.Add(this.mrd_active);
            this.Controls.Add(this.groupBox_user);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Movable = false;
            this.Name = "UserForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox_user.ResumeLayout(false);
            this.groupBox_user.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_user;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtpword;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_uid;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private MetroFramework.Controls.MetroComboBox mcmb_acct;
        private MetroFramework.Controls.MetroCheckBox mchkb_passchar;
        private MetroFramework.Controls.MetroRadioButton mrd_active;
        private MetroFramework.Controls.MetroRadioButton mrd_inactive;
        private MetroFramework.Controls.MetroRadioButton mrd_all;
        private MetroFramework.Controls.MetroLabel mlbl_uname;
        private MetroFramework.Controls.MetroLabel mlbl_pword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mcmb_status;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid user_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;


    }
}