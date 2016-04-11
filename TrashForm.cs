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
    public partial class TrashForm : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];   

        public TrashForm()
        {
            InitializeComponent();
        }       

        ItemsForm item = new ItemsForm();
       // int row;      

        private void TrashForm_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT iid AS ID, date(item_date) AS Date, cid AS Category, item_name AS Item, item_description AS Description, item_serial AS Serial, bid AS Brand, quantity AS Quantity, unit AS Unit, status AS Status from Trash", connection))            
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                item.inventory_grid.Rows.Clear();

                trash_grid.DataSource = ds.Tables[0];
                trash_grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;             
            }
            item.LoadAllInventory();         
        }

        public void Delete(string ID)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Delete from Trash where iid = '" + ID + "'", connection);
                cmd.ExecuteNonQuery();              
                connection.Close();               
                item.LoadAllInventory();              
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }
       
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            foreach (DataGridViewRow row in this.trash_grid.SelectedRows.OfType<DataGridViewRow>().ToArray())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO inventory_info(iid, item_date, cid, item_name, item_description, item_serial, bid, quantity, unit, status) VALUES('" + trash_grid.CurrentRow.Cells[0].Value.ToString() + "','" + Convert.ToDateTime(trash_grid.CurrentRow.Cells[1].Value).ToString("yyyy-MM-dd") + "','" + trash_grid.CurrentRow.Cells[2].Value.ToString() + "','" + trash_grid.CurrentRow.Cells[3].Value.ToString() + "','" + trash_grid.CurrentRow.Cells[4].Value.ToString() + "','" + trash_grid.CurrentRow.Cells[5].Value.ToString() + "','" + trash_grid.CurrentRow.Cells[6].Value.ToString() + "','" + trash_grid.CurrentRow.Cells[7].Value.ToString() + "','" + trash_grid.CurrentRow.Cells[8].Value.ToString() + "', '" + trash_grid.CurrentRow.Cells[9].Value.ToString() + "')", connection);
                Delete(row.Cells[0].Value.ToString());               
                cmd.ExecuteNonQuery();
                connection.Close();
                trash_grid.Rows.Remove(row);

                item.LoadAllInventory();
            }                       
        }                   
    }
}
 