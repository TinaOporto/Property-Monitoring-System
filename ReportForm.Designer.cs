namespace LoginForm
{
    partial class ReportForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.date_from = new MetroFramework.Controls.MetroDateTime();
            this.date_to = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_search = new System.Windows.Forms.Button();
            this.mtxt_cat = new MetroFramework.Controls.MetroTextBox();
            this.mtxtx_cid = new MetroFramework.Controls.MetroTextBox();
            this.btn_search_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(20, 30);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1062, 604);
            this.crystalReportViewer1.TabIndex = 11;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // date_from
            // 
            this.date_from.CustomFormat = "yyyy-MM-dd";
            this.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_from.Location = new System.Drawing.Point(633, 116);
            this.date_from.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(119, 29);
            this.date_from.TabIndex = 2;
            this.date_from.Value = new System.DateTime(2016, 4, 6, 0, 0, 0, 0);
            // 
            // date_to
            // 
            this.date_to.CustomFormat = "yyyy-MM-dd";
            this.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_to.Location = new System.Drawing.Point(801, 116);
            this.date_to.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(119, 29);
            this.date_to.TabIndex = 3;
            this.date_to.Value = new System.DateTime(2016, 4, 6, 0, 0, 0, 0);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(576, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 25);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "From";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(768, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(28, 25);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "To";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Cyan;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = global::LoginForm.Properties.Resources.Search_24;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(440, 122);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(106, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.TabStop = false;
            this.btn_search.Text = "   Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // mtxt_cat
            // 
            // 
            // 
            // 
            this.mtxt_cat.CustomButton.Image = null;
            this.mtxt_cat.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.mtxt_cat.CustomButton.Name = "";
            this.mtxt_cat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_cat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_cat.CustomButton.TabIndex = 1;
            this.mtxt_cat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_cat.CustomButton.UseSelectable = true;
            this.mtxt_cat.CustomButton.Visible = false;
            this.mtxt_cat.Lines = new string[0];
            this.mtxt_cat.Location = new System.Drawing.Point(302, 122);
            this.mtxt_cat.MaxLength = 32767;
            this.mtxt_cat.Name = "mtxt_cat";
            this.mtxt_cat.PasswordChar = '\0';
            this.mtxt_cat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_cat.SelectedText = "";
            this.mtxt_cat.SelectionLength = 0;
            this.mtxt_cat.SelectionStart = 0;
            this.mtxt_cat.Size = new System.Drawing.Size(132, 23);
            this.mtxt_cat.TabIndex = 21;
            this.mtxt_cat.UseSelectable = true;
            this.mtxt_cat.WaterMark = "Select Category";
            this.mtxt_cat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_cat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxt_cat.Click += new System.EventHandler(this.mtxt_cat_Click);
            // 
            // mtxtx_cid
            // 
            // 
            // 
            // 
            this.mtxtx_cid.CustomButton.Image = null;
            this.mtxtx_cid.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.mtxtx_cid.CustomButton.Name = "";
            this.mtxtx_cid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtx_cid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtx_cid.CustomButton.TabIndex = 1;
            this.mtxtx_cid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtx_cid.CustomButton.UseSelectable = true;
            this.mtxtx_cid.CustomButton.Visible = false;
            this.mtxtx_cid.Lines = new string[0];
            this.mtxtx_cid.Location = new System.Drawing.Point(441, 151);
            this.mtxtx_cid.MaxLength = 32767;
            this.mtxtx_cid.Name = "mtxtx_cid";
            this.mtxtx_cid.PasswordChar = '\0';
            this.mtxtx_cid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtx_cid.SelectedText = "";
            this.mtxtx_cid.SelectionLength = 0;
            this.mtxtx_cid.SelectionStart = 0;
            this.mtxtx_cid.Size = new System.Drawing.Size(75, 23);
            this.mtxtx_cid.TabIndex = 22;
            this.mtxtx_cid.UseSelectable = true;
            this.mtxtx_cid.Visible = false;
            this.mtxtx_cid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtx_cid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_search_all
            // 
            this.btn_search_all.BackColor = System.Drawing.Color.Cyan;
            this.btn_search_all.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_search_all.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_all.Image = global::LoginForm.Properties.Resources.Search_24;
            this.btn_search_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search_all.Location = new System.Drawing.Point(937, 116);
            this.btn_search_all.Name = "btn_search_all";
            this.btn_search_all.Size = new System.Drawing.Size(107, 29);
            this.btn_search_all.TabIndex = 23;
            this.btn_search_all.TabStop = false;
            this.btn_search_all.Text = "     Search All";
            this.btn_search_all.UseVisualStyleBackColor = false;
            this.btn_search_all.Click += new System.EventHandler(this.btn_search_all_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 654);
            this.ControlBox = false;
            this.Controls.Add(this.btn_search_all);
            this.Controls.Add(this.mtxt_cat);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.date_to);
            this.Controls.Add(this.date_from);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.mtxtx_cid);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Movable = false;
            this.Name = "ReportForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.ReportForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btn_search;
        private MetroFramework.Controls.MetroDateTime date_from;
        private MetroFramework.Controls.MetroDateTime date_to;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxt_cat;
        private MetroFramework.Controls.MetroTextBox mtxtx_cid;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.Button btn_search_all;

    }
}