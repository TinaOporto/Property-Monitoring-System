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
    public partial class CategoryName : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public CategoryName()
        {
            InitializeComponent();
        }

        public int row = 0;

        private void CategoryName_Load(object sender, EventArgs e)
        {
            LoadAllCategory();
            //connection = new MySqlConnection(ConnectionString);

            //using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select cid AS ID, cat_name As Category_Name  from category_info order by cat_name Asc", connection))
            //{
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds);

            //    cat_grid.DataSource = ds.Tables[0];
            //    cat_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}          
        }

        private void cat_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            mbtn_cat.PerformClick();
        }

        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Insert into category_info(cat_name) value('"+ txt_cat.Text +"')", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, ""+ txt_cat.Text +" is  Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                LoadAllCategory();
            }

            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            if (txt_cat.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MetroMessageBox.Show(this, "Field is Empty.");
                return;
            }
          
               connection.Open();
               string str = "Select count(*) from category_info where cat_name = '" + txt_cat.Text + "'";
                 MySqlCommand cd = new MySqlCommand(str, connection);
                 int categoryExist = Convert.ToInt32(cd.ExecuteScalar());
                 if (categoryExist > 0)
                 {
                     MetroMessageBox.Show(this, ""+ txt_cat.Text +" already exist!", "Oopps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     txt_cat.Text = "";
                     cat_grid.ClearSelection();
                     return;
                 }
                 connection.Close();
                 Insert();            
        }
      
        private void LoadAllCategory()
        {
            connection = new MySqlConnection(ConnectionString);
            cat_grid.Rows.Clear();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from category_info order by cat_name Asc", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    cat_grid.Rows.Add(dataReader["cid"] + "", dataReader["cat_name"] + "");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
            
        }

        private void cat_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cat_grid.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
