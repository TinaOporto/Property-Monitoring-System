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
    public partial class Warehouse : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];       

        public Warehouse()
        {
            InitializeComponent();
        }

        ItemsForm iff = new ItemsForm();
        int SelectedRow;

        private void Warehouse_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);         

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT inventory_info.iid As ID, inventory_info.item_date As Date, category_info.cat_name As Category, inventory_info.item_name As Item,  inventory_info.item_description As Description, inventory_info.item_serial As Serial, brand_info.brand_name As Brand, inventory_info.quantity As Quantity, inventory_info.unit As Unit, inventory_info.`status`As Status FROM category_info Inner Join inventory_info ON category_info.cid = inventory_info.cid Inner Join brand_info ON brand_info.bid = inventory_info.bid where status = 'Inactive' order by iid desc", connection))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                whouse_grid.DataSource = ds.Tables[0];
                whouse_grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;               
            }
        }        
      
       private void Active()
        {
            connection = new MySqlConnection(ConnectionString);
              try
              {
                  connection.Open();
                  MySqlCommand cmd = new MySqlCommand("Update inventory_info set status = 'Active' where iid = '"+ mtxt_iid.Text +"'", connection);
                  cmd.ExecuteNonQuery();                 
                  connection.Close();                     
                  iff.LoadAllInventory();                    
              }
               catch(Exception ex)
              {
                  MetroMessageBox.Show(this, ex.Message);
              }
        }      

        private void whouse_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                whouse_grid.Rows[e.RowIndex].Selected = true;
                SelectedRow = e.RowIndex;
            }
        }

        private void designateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mtxt_iid.Text = whouse_grid.Rows[SelectedRow].Cells[0].Value.ToString();

            DesignationNew df = new DesignationNew();
            df.mtxt_iid.Text = whouse_grid.Rows[SelectedRow].Cells[0].Value.ToString();
            df.itemname_txt.Text = whouse_grid.Rows[SelectedRow].Cells[3].Value.ToString();
            df.mtxt_serial.Text = whouse_grid.Rows[SelectedRow].Cells[5].Value.ToString();

            if (df.ShowDialog(this) == DialogResult.OK)
            {
                Active();
                whouse_grid.Rows.Remove(whouse_grid.Rows[SelectedRow]);
            }
            df.Dispose();
        }
      }
   }
