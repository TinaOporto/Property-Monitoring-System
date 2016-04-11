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
    public partial class EmployeeName : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public EmployeeName()
        {
            InitializeComponent();
        }
        public int row = 0;

        private void EmployeeName_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

             using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select eid AS ID, concat ( em_fname ,' ',  em_lname) as Employe_Name  from employee_info", connection))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                emname_grid.DataSource = ds.Tables[0];
                emname_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void emname_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            btn_name.PerformClick();           
        }             
    }
}
