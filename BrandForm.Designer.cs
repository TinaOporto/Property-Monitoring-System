namespace LoginForm
{
    partial class BrandForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.brand_grid = new MetroFramework.Controls.MetroGrid();
            this.btn_brand = new MetroFramework.Controls.MetroButton();
            this.txt_brands = new MetroFramework.Controls.MetroTextBox();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.brand_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // brand_grid
            // 
            this.brand_grid.AllowUserToResizeRows = false;
            this.brand_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brand_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brand_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.brand_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brand_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.brand_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.brand_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.brand_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.brand_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brand_grid.EnableHeadersVisualStyles = false;
            this.brand_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.brand_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brand_grid.Location = new System.Drawing.Point(20, 60);
            this.brand_grid.Name = "brand_grid";
            this.brand_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brand_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.brand_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.brand_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brand_grid.Size = new System.Drawing.Size(248, 351);
            this.brand_grid.Style = MetroFramework.MetroColorStyle.Purple;
            this.brand_grid.TabIndex = 0;
            this.brand_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brand_grid_CellClick);
            this.brand_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brand_grid_CellContentClick);
            // 
            // btn_brand
            // 
            this.btn_brand.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_brand.Location = new System.Drawing.Point(80, 151);
            this.btn_brand.Name = "btn_brand";
            this.btn_brand.Size = new System.Drawing.Size(75, 23);
            this.btn_brand.TabIndex = 1;
            this.btn_brand.Text = "brand_btn";
            this.btn_brand.UseSelectable = true;
            // 
            // txt_brands
            // 
            // 
            // 
            // 
            this.txt_brands.CustomButton.Image = null;
            this.txt_brands.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txt_brands.CustomButton.Name = "";
            this.txt_brands.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_brands.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_brands.CustomButton.TabIndex = 1;
            this.txt_brands.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_brands.CustomButton.UseSelectable = true;
            this.txt_brands.CustomButton.Visible = false;
            this.txt_brands.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_brands.Lines = new string[0];
            this.txt_brands.Location = new System.Drawing.Point(20, 22);
            this.txt_brands.MaxLength = 32767;
            this.txt_brands.Name = "txt_brands";
            this.txt_brands.PasswordChar = '\0';
            this.txt_brands.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_brands.SelectedText = "";
            this.txt_brands.SelectionLength = 0;
            this.txt_brands.SelectionStart = 0;
            this.txt_brands.Size = new System.Drawing.Size(134, 23);
            this.txt_brands.TabIndex = 2;
            this.txt_brands.UseSelectable = true;
            this.txt_brands.WaterMark = "Add Brands";
            this.txt_brands.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_brands.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_add.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_add.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_add.Location = new System.Drawing.Point(160, 21);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(60, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseCustomBackColor = true;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Brands";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CID";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 431);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_brands);
            this.Controls.Add(this.brand_grid);
            this.Controls.Add(this.btn_brand);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrandForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Load += new System.EventHandler(this.BrandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brand_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroGrid brand_grid;
        private MetroFramework.Controls.MetroButton btn_brand;
        private MetroFramework.Controls.MetroTextBox txt_brands;
        private MetroFramework.Controls.MetroButton btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}