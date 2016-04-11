namespace LoginForm
{
    partial class InventoryReport
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
            this.mbtn_search = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mdate_from = new MetroFramework.Controls.MetroDateTime();
            this.mdate_to = new MetroFramework.Controls.MetroDateTime();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.mtxt_cat = new MetroFramework.Controls.MetroTextBox();
            this.mtxt_cid = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mbtn_search
            // 
            this.mbtn_search.BackColor = System.Drawing.Color.Cyan;
            this.mbtn_search.BackgroundImage = global::LoginForm.Properties.Resources.Search_24;
            this.mbtn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtn_search.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtn_search.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtn_search.Location = new System.Drawing.Point(286, 89);
            this.mbtn_search.Name = "mbtn_search";
            this.mbtn_search.Size = new System.Drawing.Size(110, 23);
            this.mbtn_search.TabIndex = 2;
            this.mbtn_search.TabStop = false;
            this.mbtn_search.Text = "Search";
            this.mbtn_search.UseSelectable = true;
            this.mbtn_search.Click += new System.EventHandler(this.mbtn_search_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(427, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "From";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(623, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(28, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "To";
            // 
            // mdate_from
            // 
            this.mdate_from.CustomFormat = "yyyy-MM-dd";
            this.mdate_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mdate_from.Location = new System.Drawing.Point(484, 87);
            this.mdate_from.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdate_from.Name = "mdate_from";
            this.mdate_from.Size = new System.Drawing.Size(110, 29);
            this.mdate_from.TabIndex = 5;
            this.mdate_from.TabStop = false;
            this.mdate_from.Value = new System.DateTime(2016, 4, 6, 0, 0, 0, 0);
            // 
            // mdate_to
            // 
            this.mdate_to.CustomFormat = "yyyy-MM-dd";
            this.mdate_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mdate_to.Location = new System.Drawing.Point(657, 87);
            this.mdate_to.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdate_to.Name = "mdate_to";
            this.mdate_to.Size = new System.Drawing.Size(113, 29);
            this.mdate_to.TabIndex = 6;
            this.mdate_to.TabStop = false;
            this.mdate_to.Value = new System.DateTime(2016, 4, 6, 0, 0, 0, 0);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(20, 30);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(871, 628);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // mtxt_cat
            // 
            // 
            // 
            // 
            this.mtxt_cat.CustomButton.Image = null;
            this.mtxt_cat.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.mtxt_cat.CustomButton.Name = "";
            this.mtxt_cat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_cat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_cat.CustomButton.TabIndex = 1;
            this.mtxt_cat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_cat.CustomButton.UseSelectable = true;
            this.mtxt_cat.CustomButton.Visible = false;
            this.mtxt_cat.Lines = new string[0];
            this.mtxt_cat.Location = new System.Drawing.Point(152, 89);
            this.mtxt_cat.MaxLength = 32767;
            this.mtxt_cat.Name = "mtxt_cat";
            this.mtxt_cat.PasswordChar = '\0';
            this.mtxt_cat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_cat.SelectedText = "";
            this.mtxt_cat.SelectionLength = 0;
            this.mtxt_cat.SelectionStart = 0;
            this.mtxt_cat.Size = new System.Drawing.Size(128, 23);
            this.mtxt_cat.TabIndex = 7;
            this.mtxt_cat.UseSelectable = true;
            this.mtxt_cat.WaterMark = "Select Category";
            this.mtxt_cat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_cat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxt_cat.Click += new System.EventHandler(this.mtxt_cat_Click);
            // 
            // mtxt_cid
            // 
            // 
            // 
            // 
            this.mtxt_cid.CustomButton.Image = null;
            this.mtxt_cid.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.mtxt_cid.CustomButton.Name = "";
            this.mtxt_cid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_cid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_cid.CustomButton.TabIndex = 1;
            this.mtxt_cid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_cid.CustomButton.UseSelectable = true;
            this.mtxt_cid.CustomButton.Visible = false;
            this.mtxt_cid.Lines = new string[0];
            this.mtxt_cid.Location = new System.Drawing.Point(152, 119);
            this.mtxt_cid.MaxLength = 32767;
            this.mtxt_cid.Name = "mtxt_cid";
            this.mtxt_cid.PasswordChar = '\0';
            this.mtxt_cid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_cid.SelectedText = "";
            this.mtxt_cid.SelectionLength = 0;
            this.mtxt_cid.SelectionStart = 0;
            this.mtxt_cid.Size = new System.Drawing.Size(75, 23);
            this.mtxt_cid.TabIndex = 8;
            this.mtxt_cid.UseSelectable = true;
            this.mtxt_cid.Visible = false;
            this.mtxt_cid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_cid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 678);
            this.Controls.Add(this.mtxt_cat);
            this.Controls.Add(this.mdate_to);
            this.Controls.Add(this.mdate_from);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbtn_search);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.mtxt_cid);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryReport";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.InventoryReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MetroFramework.Controls.MetroButton mbtn_search;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime mdate_from;
        private MetroFramework.Controls.MetroDateTime mdate_to;
        private MetroFramework.Controls.MetroTextBox mtxt_cat;
        private MetroFramework.Controls.MetroTextBox mtxt_cid;
       // private CrystalReport2 CrystalReport21;
        //private CrystalReport2 CrystalReport22;

        public object CrystalReport21 { get; set; }
    }
}