namespace LoginForm
{
    partial class Warehouse
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
            this.whouse_grid = new MetroFramework.Controls.MetroGrid();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.designateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtxt_iid = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.whouse_grid)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // whouse_grid
            // 
            this.whouse_grid.AllowUserToResizeRows = false;
            this.whouse_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.whouse_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.whouse_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.whouse_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.whouse_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.whouse_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.whouse_grid.ContextMenuStrip = this.metroContextMenu1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.whouse_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.whouse_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whouse_grid.EnableHeadersVisualStyles = false;
            this.whouse_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.whouse_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.whouse_grid.Location = new System.Drawing.Point(20, 60);
            this.whouse_grid.MultiSelect = false;
            this.whouse_grid.Name = "whouse_grid";
            this.whouse_grid.ReadOnly = true;
            this.whouse_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.whouse_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.whouse_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.whouse_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.whouse_grid.Size = new System.Drawing.Size(1079, 505);
            this.whouse_grid.Style = MetroFramework.MetroColorStyle.Teal;
            this.whouse_grid.TabIndex = 0;
            this.whouse_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.whouse_grid_CellClick);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designateToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(127, 26);
            // 
            // designateToolStripMenuItem
            // 
            this.designateToolStripMenuItem.ForeColor = System.Drawing.Color.DeepPink;
            this.designateToolStripMenuItem.Name = "designateToolStripMenuItem";
            this.designateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.designateToolStripMenuItem.Text = "Designate";
            this.designateToolStripMenuItem.Click += new System.EventHandler(this.designateToolStripMenuItem_Click_1);
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
            this.mtxt_iid.Location = new System.Drawing.Point(513, 73);
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
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 585);
            this.Controls.Add(this.whouse_grid);
            this.Controls.Add(this.mtxt_iid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Warehouse";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.whouse_grid)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid whouse_grid;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private MetroFramework.Controls.MetroTextBox mtxt_iid;
        private System.Windows.Forms.ToolStripMenuItem designateToolStripMenuItem;
    }
}