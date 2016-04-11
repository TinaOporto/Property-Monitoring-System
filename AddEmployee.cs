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
    public partial class AddEmployee : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];
     
        public AddEmployee()
        {
            InitializeComponent();
        }

        EmployeeForm ef = new EmployeeForm();
        public int rowIndex = 0;

        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into employee_info( em_fname, em_lname, company_id, status ) value('" + txt_fname.Text + "', '" + txt_lname.Text + "','" + txt_compid.Text + "', '" + mcmb_status.Text + "' )", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Added Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                LoadAllEmployee();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void LoadAllEmployee()
        {
            connection = new MySqlConnection(ConnectionString); 
            ef.employee_grid.Rows.Clear();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from employee_info order by eid desc ", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ef.employee_grid.Rows.Add(dataReader["eid"] + "", dataReader["em_fname"] + "", dataReader["em_lname"] + "", dataReader["company_id"] + "", dataReader["status"] + "");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }
       
        private void btn_save_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);  

            if (txt_fname.Text == "" || txt_lname.Text == "" || mcmb_status.Text == "" || txt_compid.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MetroMessageBox.Show(this, "Field is Empty.");
                return;
            }
            connection.Open();

            string str = "Select count(*) from employee_info where em_fname = '" + txt_fname.Text + "' and em_lname = '" + txt_lname.Text + "'";
            MySqlCommand cmd = new MySqlCommand(str, connection);
            int userExist = Convert.ToInt32(cmd.ExecuteScalar());
            if (userExist > 0)
            {
                MetroMessageBox.Show(this, "Employee already exist!", "Oopps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_cancel.PerformClick();
                return;
            }
            connection.Close();
            Insert();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {           
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_compid.Text = "";
            mcmb_status.PromptText = "Select Status";
            
            ef.employee_grid.ClearSelection();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            LoadAllEmployee();
            this.ActiveControl = txt_fname;
            ef.employee_grid.ReadOnly = true;
           // rd_all.Checked = true;
            ef.employee_grid.ClearSelection(); 
        }             
    }
}
