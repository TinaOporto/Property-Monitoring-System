using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class InactiveItems : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public InactiveItems()
        {
            InitializeComponent();
        }

        public int row = 0;
        int SelectedRow;
        ItemsForm iff = new ItemsForm();

        private void InactiveItems_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select iid AS ID, item_name As Item_Name, item_serial AS Serial from inventory_info where status = 'Inactive' order by item_name Asc", connection))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                inactive_grid.DataSource = ds.Tables[0];
                inactive_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void Active()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Update inventory_info set status = 'Active' where iid = '" + mtxt_iid.Text + "'", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                iff.LoadAllInventory();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void inactive_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            btn_inactive.PerformClick();

            mtxt_iid.Text = inactive_grid.Rows[SelectedRow].Cells[0].Value.ToString();                
        }

        private void inactive_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex >= 0)
            {
                inactive_grid.Rows[e.RowIndex].Selected = true;
                SelectedRow = e.RowIndex;
            }

            Active();
            //inactive_grid.Rows.Remove(inactive_grid.Rows[SelectedRow]);          
        }

    }
}
