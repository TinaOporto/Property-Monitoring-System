namespace LoginForm
{
    partial class InactiveItems
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
            this.inactive_grid = new MetroFramework.Controls.MetroGrid();
            this.btn_inactive = new MetroFramework.Controls.MetroButton();
            this.mtxt_iid = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inactive_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // inactive_grid
            // 
            this.inactive_grid.AllowUserToResizeRows = false;
            this.inactive_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inactive_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inactive_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.inactive_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inactive_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inactive_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inactive_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.inactive_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inactive_grid.EnableHeadersVisualStyles = false;
            this.inactive_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inactive_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inactive_grid.Location = new System.Drawing.Point(20, 30);
            this.inactive_grid.MultiSelect = false;
            this.inactive_grid.Name = "inactive_grid";
            this.inactive_grid.ReadOnly = true;
            this.inactive_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inactive_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inactive_grid.RowHeadersWidth = 30;
            this.inactive_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.inactive_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inactive_grid.Size = new System.Drawing.Size(260, 331);
            this.inactive_grid.Style = MetroFramework.MetroColorStyle.Yellow;
            this.inactive_grid.TabIndex = 0;
            this.inactive_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inactive_grid_CellClick);
            this.inactive_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inactive_grid_CellContentClick);
            // 
            // btn_inactive
            // 
            this.btn_inactive.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_inactive.Location = new System.Drawing.Point(78, 100);
            this.btn_inactive.Name = "btn_inactive";
            this.btn_inactive.Size = new System.Drawing.Size(75, 23);
            this.btn_inactive.TabIndex = 1;
            this.btn_inactive.UseSelectable = true;
            // 
            // mtxt_iid
            // 
            // 
            // 
            // 
            this.mtxt_iid.CustomButton.Image = null;
            this.mtxt_iid.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.mtxt_iid.CustomButton.Name = "";
            this.mtxt_iid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_iid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_iid.CustomButton.TabIndex = 1;
            this.mtxt_iid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_iid.CustomButton.UseSelectable = true;
            this.mtxt_iid.CustomButton.Visible = false;
            this.mtxt_iid.Lines = new string[0];
            this.mtxt_iid.Location = new System.Drawing.Point(56, 228);
            this.mtxt_iid.MaxLength = 32767;
            this.mtxt_iid.Name = "mtxt_iid";
            this.mtxt_iid.PasswordChar = '\0';
            this.mtxt_iid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_iid.SelectedText = "";
            this.mtxt_iid.SelectionLength = 0;
            this.mtxt_iid.SelectionStart = 0;
            this.mtxt_iid.Size = new System.Drawing.Size(75, 23);
            this.mtxt_iid.TabIndex = 2;
            this.mtxt_iid.UseSelectable = true;
            this.mtxt_iid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_iid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InactiveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 381);
            this.Controls.Add(this.inactive_grid);
            this.Controls.Add(this.btn_inactive);
            this.Controls.Add(this.mtxt_iid);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InactiveItems";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Load += new System.EventHandler(this.InactiveItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inactive_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_inactive;
        public MetroFramework.Controls.MetroGrid inactive_grid;
        private MetroFramework.Controls.MetroTextBox mtxt_iid;
    }
}