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
    public partial class ItemName :MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public ItemName()
        {
            InitializeComponent();
        }

        public int row = 0;

        private void ItemName_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select iid AS ID, item_name As Item_Name, item_serial AS Serial  from inventory_info order by item_name Asc", connection))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                item_name_grid.DataSource = ds.Tables[0];
                item_name_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void item_name_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            btn_iname.PerformClick();       
        }
    }
}
