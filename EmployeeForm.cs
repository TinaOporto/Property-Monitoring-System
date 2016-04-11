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
    public partial class EmployeeForm : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];
       
        bool IsInserting = false;
        int rowIndex = 0;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        string Status;
        int flag_update = 0;

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txt_fname;
            IsInserting = true;
            btn_cancel.PerformClick();

            txt_eid.Enabled = true;
            txt_fname.Enabled = true;
            txt_lname.Enabled = true;
            txt_compid.Enabled = true;
            mcmb_status.Enabled = true;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            employee_grid.ClearSelection();
        }

        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into employee_info(eid, em_fname, em_lname, company_id, status ) value('" + txt_eid.Text + "', '" + txt_fname.Text + "', '" + txt_lname.Text + "','" + txt_compid.Text + "', '" + mcmb_status.Text +"' )", connection);
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
            employee_grid.Rows.Clear();
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from employee_info order by eid desc ", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    employee_grid.Rows.Add(dataReader["eid"] + "", dataReader["em_fname"] + "",  dataReader["em_lname"] + "", dataReader["company_id"] +"", dataReader["status"]+"");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void LoadAllActiveEmployee()
        {
            connection = new MySqlConnection(ConnectionString);
            employee_grid.Rows.Clear();

            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from employee_info where status = 'Active' order by eid desc ", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    employee_grid.Rows.Add(dataReader["eid"] + "", dataReader["em_fname"] + "", dataReader["em_lname"] + "", dataReader["company_id"] + "", dataReader["status"] + "");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void LoadAllInactiveEmployee()
        {
            connection = new MySqlConnection(ConnectionString);
            employee_grid.Rows.Clear();
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from employee_info where status = 'Inactive' order by eid desc ", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    employee_grid.Rows.Add(dataReader["eid"] + "", dataReader["em_fname"] + "", dataReader["em_lname"] + "", dataReader["company_id"] + "", dataReader["status"] + "");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }
        private void Updates()
        {
            connection = new MySqlConnection(ConnectionString);       

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("update employee_info set em_fname = '" + txt_fname.Text + "', em_lname = '" + txt_lname.Text + "', company_id = '" + txt_compid.Text + "', status = '"+ mcmb_status.Text +"' where eid = '" + txt_eid.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Updated Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                employee_grid.Update();
                employee_grid.Refresh();
                connection.Close();
                //LoadAllEmployee();
                if(rd_all.Checked == true)
                {
                    LoadAllEmployee();
                }
                if(rd_active.Checked == true)
                {
                    LoadAllActiveEmployee();
                }
                else if(rd_inactive.Checked == true)
                {
                    LoadAllInactiveEmployee();
                }
                this.employee_grid.CurrentCell = this.employee_grid[1, Convert.ToInt32(rowIndex)];
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void Delete(string ID)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("delete from employee_info where eid = '" + ID + "'", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Deleted Sucesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();

                LoadAllEmployee();
                btn_cancel.PerformClick();
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            if (txt_fname.Text == "" || txt_lname.Text == "" || mcmb_status.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MetroMessageBox.Show(this, "Field is Empty.");
                return;
            }

         if (IsInserting == true)
            {
                connection.Open();
                string str = "Select count(*) from employee_info where em_fname = '" + txt_fname.Text + "' and em_lname = '"+ txt_lname.Text +"'";
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
            else
            {
                Updates();
            }
            flag_update = 0;                     
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_eid.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_compid.Text = "";
            mcmb_status.PromptText = "Select Status";
            rd_active.Checked = false;
            rd_inactive.Checked = false;
            rd_all.Checked = true;
            Status = "";
            btn_add.Enabled = true;
           
            employee_grid.ClearSelection();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            this.ActiveControl = txt_fname;
            IsInserting = false;
            flag_update = 1;

            txt_eid.Enabled = true;
            txt_fname.Enabled = true;
            txt_lname.Enabled = true;
            txt_compid.Enabled = true;
            mcmb_status.Enabled = true;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;

            rowIndex = employee_grid.CurrentCell.RowIndex;

            foreach (DataGridViewRow row in this.employee_grid.Rows)
            {
                if (row.Selected == true)
                {
                    txt_eid.Text = row.Cells[0].Value.ToString(); 
                    txt_fname.Text = row.Cells[1].Value.ToString();
                    txt_lname.Text = row.Cells[2].Value.ToString();
                    txt_compid.Text = row.Cells[3].Value.ToString();
                    mcmb_status.Text = row.Cells[4].Value.ToString();
                    break;
                }
            }
        }

        //private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    btn_add.Enabled = true;
        //    foreach (DataGridViewRow row in this.employee_grid.Rows)
        //    {
        //        if (row.Selected == true)
        //        {
        //            Delete(row.Cells[0].Value.ToString());
        //            break;
        //        }
        //    }
        //}

        private void EmployeeForm_Load_1(object sender, EventArgs e)
        {
            LoadAllEmployee();
            this.ActiveControl = txt_fname;
            employee_grid.ReadOnly = true;
            rd_all.Checked = true;
            employee_grid.ClearSelection();

            txt_eid.Enabled = false;
            txt_fname.Enabled = false;
            txt_lname.Enabled = false;
            txt_compid.Enabled = false;
            mcmb_status.Enabled = false;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
           
        }

        private void rd_active_CheckedChanged(object sender, EventArgs e)
        {
            Status = "Active";
            updateToolStripMenuItem.Visible = true;

            MySqlDataAdapter sda = new MySqlDataAdapter("Select * FROM employee_info Where status = 'Active' order by eid desc", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employee_grid.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = employee_grid.Rows.Add();
                employee_grid.Rows[n].Cells[0].Value = row["eid"].ToString();
                employee_grid.Rows[n].Cells[1].Value = row["em_fname"].ToString();
                employee_grid.Rows[n].Cells[2].Value = row["em_lname"].ToString();
                employee_grid.Rows[n].Cells[3].Value = row["company_id"].ToString();
                employee_grid.Rows[n].Cells[4].Value = row["status"].ToString();
            }           
        }

        private void rd_inactive_CheckedChanged(object sender, EventArgs e)
        {

            Status = "Inactive";
            updateToolStripMenuItem.Visible = true;         
           
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * FROM employee_info Where status = 'Inactive' order by eid desc", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employee_grid.Rows.Clear();

            foreach(DataRow row in dt.Rows)
            {
                int n = employee_grid.Rows.Add();
                employee_grid.Rows[n].Cells[0].Value = row["eid"].ToString();
                employee_grid.Rows[n].Cells[1].Value = row["em_fname"].ToString();
                employee_grid.Rows[n].Cells[2].Value = row["em_lname"].ToString();
                employee_grid.Rows[n].Cells[3].Value = row["company_id"].ToString();
                employee_grid.Rows[n].Cells[4].Value = row["status"].ToString();
            }  
        }      

        private void rd_all_CheckedChanged(object sender, EventArgs e)
        {
            Status = "All";
           // updateToolStripMenuItem.Visible = false;

            MySqlDataAdapter sda = new MySqlDataAdapter("Select * FROM employee_info Where status = 'Inactive' OR status = 'Active' order by eid desc", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employee_grid.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = employee_grid.Rows.Add();
                employee_grid.Rows[n].Cells[0].Value = row["eid"].ToString();
                employee_grid.Rows[n].Cells[1].Value = row["em_fname"].ToString();
                employee_grid.Rows[n].Cells[2].Value = row["em_lname"].ToString();
                employee_grid.Rows[n].Cells[3].Value = row["company_id"].ToString();
                employee_grid.Rows[n].Cells[4].Value = row["status"].ToString();
            }
        }

        private void employee_grid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employee_grid.Rows[e.RowIndex].Selected = true;
            }

            if (flag_update == 1)
            {

                DialogResult mb = MetroMessageBox.Show(this, "Do you want to save first?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mb == DialogResult.Yes)
                {
                    flag_update = 0;

                    Updates();
                    employee_grid.Focus();
                    employee_grid.CurrentCell.Selected = true;               
                }

                else if (mb == DialogResult.No)
                {
                    flag_update = 0;

                    txt_eid.Enabled = false;
                    txt_fname.Enabled = false;
                    txt_lname.Enabled = false;
                    txt_compid.Enabled = false;
                    mcmb_status.Enabled = false;

                    btn_cancel.PerformClick();
                    employee_grid.CurrentCell.Selected = true;
                }
            }
        }

        private void mcmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if(mcmb_status.Text == "Active")
            //{
            //    rd_active.Checked = true;
            //    MySqlDataAdapter sda = new MySqlDataAdapter("Select * FROM employee_info Where status = 'Active' order by eid desc", connection);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    employee_grid.Rows.Clear();

            //    foreach (DataRow row in dt.Rows)
            //    {
            //        int n = employee_grid.Rows.Add();
            //        employee_grid.Rows[n].Cells[0].Value = row["eid"].ToString();
            //        employee_grid.Rows[n].Cells[1].Value = row["em_fname"].ToString();
            //        employee_grid.Rows[n].Cells[2].Value = row["em_lname"].ToString();
            //        employee_grid.Rows[n].Cells[3].Value = row["company_id"].ToString();
            //        employee_grid.Rows[n].Cells[4].Value = row["status"].ToString();
            //    }  
           // }

            //if(mcmb_status.Text == "Inactive")
            //{
            //    rd_inactive.Checked = true;
            //    MySqlDataAdapter sda = new MySqlDataAdapter("Select * FROM employee_info Where status = 'Inactive' order by eid desc", connection);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    employee_grid.Rows.Clear();

            //    foreach (DataRow row in dt.Rows)
            //    {
            //        int n = employee_grid.Rows.Add();
            //        employee_grid.Rows[n].Cells[0].Value = row["eid"].ToString();
            //        employee_grid.Rows[n].Cells[1].Value = row["em_fname"].ToString();
            //        employee_grid.Rows[n].Cells[2].Value = row["em_lname"].ToString();
            //        employee_grid.Rows[n].Cells[3].Value = row["company_id"].ToString();
            //        employee_grid.Rows[n].Cells[4].Value = row["status"].ToString();
            //    }  
           // }
        }
    }
}
