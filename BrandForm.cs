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
    public partial class BrandForm : MetroForm
    {
        public string cid;
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public BrandForm()
        {
            InitializeComponent();
        }

        public int row = 0;

        private void BrandForm_Load(object sender, EventArgs e)
        {
            LoadAllBrands();
            //connection = new MySqlConnection(ConnectionString);

            //using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select bid AS ID, brand_name as Brand_Name from brand_info where cid = '"+ cid +"'  order by brand_name ASC", connection))
            //{
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds);

            //    brand_grid.DataSource = ds.Tables[0];
            //    brand_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}
        }

        private void brand_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            btn_brand.PerformClick();
        }

        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Insert into brand_info(brand_name, cid) value('"+ txt_brands.Text +"', '"+ cid +"')", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, ""+ txt_brands.Text +" is Addeed!");
                connection.Close();
                LoadAllBrands();
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            if(txt_brands.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MetroMessageBox.Show(this, "Field is Empty.");
                return;
            }

               connection.Open();
               string str = "Select count(*) from brand_info where brand_name = '" + txt_brands.Text + "' and cid = '"+ cid +"'";
               MySqlCommand cmd = new MySqlCommand(str, connection);
               int brandExist = Convert.ToInt32(cmd.ExecuteScalar());
               if(brandExist > 0)
               {
                   MetroMessageBox.Show(this, ""+ txt_brands.Text +" already exist!", "Oopps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   return;
               }
               connection.Close();
               Insert();           
        }
       
        private void LoadAllBrands()
        {
            connection = new MySqlConnection(ConnectionString);
            brand_grid.Rows.Clear();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from brand_info where cid = '" + cid + "' order by brand_name Asc", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    brand_grid.Rows.Add(dataReader["bid"] + "", dataReader["brand_name"] + "", dataReader["cid"] + "");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void brand_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                brand_grid.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
