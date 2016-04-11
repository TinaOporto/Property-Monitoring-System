namespace LoginForm
{
    partial class CategoryName
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
            this.cat_grid = new MetroFramework.Controls.MetroGrid();
            this.mbtn_cat = new MetroFramework.Controls.MetroButton();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.txt_cat = new MetroFramework.Controls.MetroTextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cat_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // cat_grid
            // 
            this.cat_grid.AllowUserToResizeColumns = false;
            this.cat_grid.AllowUserToResizeRows = false;
            this.cat_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cat_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cat_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cat_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cat_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cat_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cat_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cat_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.cat_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cat_grid.EnableHeadersVisualStyles = false;
            this.cat_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cat_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cat_grid.Location = new System.Drawing.Point(20, 60);
            this.cat_grid.MultiSelect = false;
            this.cat_grid.Name = "cat_grid";
            this.cat_grid.ReadOnly = true;
            this.cat_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cat_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cat_grid.RowHeadersWidth = 30;
            this.cat_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cat_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cat_grid.Size = new System.Drawing.Size(239, 337);
            this.cat_grid.Style = MetroFramework.MetroColorStyle.Orange;
            this.cat_grid.TabIndex = 0;
            this.cat_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cat_grid_CellClick);
            this.cat_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cat_grid_CellContentClick);
            // 
            // mbtn_cat
            // 
            this.mbtn_cat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mbtn_cat.Location = new System.Drawing.Point(85, 140);
            this.mbtn_cat.Name = "mbtn_cat";
            this.mbtn_cat.Size = new System.Drawing.Size(75, 23);
            this.mbtn_cat.TabIndex = 1;
            this.mbtn_cat.UseSelectable = true;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_add.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_add.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_add.Location = new System.Drawing.Point(170, 22);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseCustomBackColor = true;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_cat
            // 
            // 
            // 
            // 
            this.txt_cat.CustomButton.Image = null;
            this.txt_cat.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txt_cat.CustomButton.Name = "";
            this.txt_cat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_cat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cat.CustomButton.TabIndex = 1;
            this.txt_cat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cat.CustomButton.UseSelectable = true;
            this.txt_cat.CustomButton.Visible = false;
            this.txt_cat.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_cat.Lines = new string[0];
            this.txt_cat.Location = new System.Drawing.Point(20, 22);
            this.txt_cat.MaxLength = 32767;
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.PasswordChar = '\0';
            this.txt_cat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cat.SelectedText = "";
            this.txt_cat.SelectionLength = 0;
            this.txt_cat.SelectionStart = 0;
            this.txt_cat.Size = new System.Drawing.Size(144, 23);
            this.txt_cat.TabIndex = 3;
            this.txt_cat.UseSelectable = true;
            this.txt_cat.WaterMark = "Add Category";
            this.txt_cat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Category";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 417);
            this.Controls.Add(this.txt_cat);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cat_grid);
            this.Controls.Add(this.mbtn_cat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryName";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.CategoryName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cat_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroGrid cat_grid;
        private MetroFramework.Controls.MetroButton mbtn_cat;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroTextBox txt_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}