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
    public partial class DesignationForm : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        bool IsInserting = false;
        int rowIndex = 0;

        public DesignationForm()
        {
            InitializeComponent();
            date_acq.MinDate = DateTime.MinValue;          
            date_ret.MaxDate = DateTime.Now.AddMonths(6);           
        }

        int flag_update = 0;      

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.ActiveControl = date_acq;
            IsInserting = true;
            btn_cancel.PerformClick();
            btn_add.Enabled = false;
            desig_grid.ClearSelection();

            date_acq.Enabled = true;
            date_ret.Enabled = true;
            emname_txt.Enabled = true;
            itemname_txt.Enabled = true;           
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
        }

        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
               // string[] splitinfoname = emname_txt.Text.Split(new Char[] { '-' });
               //string[] splitinfoitem = itemname_txt.Text.Split(new Char[] { '-' });
                MySqlCommand cmd = new MySqlCommand("insert into designation_info(did, date_acquired, date_returned, eid, iid, item_serial) value('"+ txt_did.Text +"','" + date_acq.Value.ToString("yyyy-MM-dd") + "','" + date_ret.Value.ToString("yyyy-MM-dd") + "', '" + mtxt_eid.Tag + "', '" + mtxt_iid.Tag + "', '"+ mtxt_serial.Text +"' )", connection);
                cmd.ExecuteNonQuery();
                //MetroMessageBox.Show(this, "Added Succesfully!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                LoadAllInfo();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void LoadAllInfo()
        {
            connection = new MySqlConnection(ConnectionString);
            desig_grid.Rows.Clear();
            try
            {
               connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT designation_info.did, designation_info.date_acquired, designation_info.date_returned, employee_info.em_fname, employee_info.em_lname, inventory_info.item_name,  inventory_info.item_serial, employee_info.eid, inventory_info.iid FROM designation_info Inner Join inventory_info ON inventory_info.iid = designation_info.iid Inner Join employee_info ON employee_info.eid = designation_info.eid order by did desc", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    desig_grid.Rows.Add(dataReader["did"] + "", Convert.ToDateTime(dataReader["date_acquired"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(dataReader["date_returned"]).ToString("yyyy-MM-dd"), dataReader["em_fname"] + "", dataReader["item_name"] + "", dataReader["item_serial"] + "", dataReader["eid"] + "", dataReader["iid"] + "");

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
              //  string[] splitinfoname = emname_txt.Text.Split(new Char[] { '-' });
               // string[] splitinfoitem = itemname_txt.Text.Split(new Char[] { '-' });
                MySqlCommand cmd = new MySqlCommand("update designation_info set date_acquired = '" + date_acq.Value.ToString("yyyy-MM-dd") + "', date_returned ='" + date_ret.Value.ToString("yyyy-MM-dd") + "', eid = '" + mtxt_eid.Tag + "', iid = '" + mtxt_iid.Tag + "', item_serial= '"+ mtxt_serial.Text +"'  where did = '" + txt_did.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Updated Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desig_grid.Update();
                desig_grid.Refresh();
                connection.Close();
                LoadAllInfo();
                this.desig_grid.CurrentCell = this.desig_grid[1, Convert.ToInt32(rowIndex)];
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void Delete(string ID)
        {
            //connection = new MySqlConnection(ConnectionString);
            //try
            //{
            //    connection.Open();
            //    MySqlCommand cmd = new MySqlCommand("delete from designation_info where did = '" + ID + "'", connection);
            //    cmd.ExecuteNonQuery();
            //    MetroMessageBox.Show(this, "Deleted Succesfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    connection.Close();
             
            //    LoadAllEmployee();
            //    btn_cancel.PerformClick();
            //}
            //catch (Exception ex)
            //{
            //    MetroMessageBox.Show(this, ex.Message);                
            //}
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            if (emname_txt.Text == "" || itemname_txt.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MetroMessageBox.Show(this, "Field  is Empty.");
                return;
            }

            if (IsInserting == true)
            {
                //connection.Open();
                //string str = "Select count(*) from designation_info where item_serial = '" + mtxt_serial.Text + "' AND date(date_returned) <= '"+ date_ret.Value.ToString("yyyy-MM-dd") +"'";
                //MySqlCommand cmd = new MySqlCommand(str, connection);
                //int itemExist = Convert.ToInt32(cmd.ExecuteScalar());
                //if (itemExist > 0)
                //{
                //    MetroMessageBox.Show(this, "Cannot assign item, someone else's using this.", "Oopps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    btn_cancel.PerformClick();
                //    return;
                //}
                //connection.Close();

                Insert();
                LoadAllInfo();
                MetroMessageBox.Show(this, "Added Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_ok.PerformClick();
            }
            else
            {
                Updates();
            }
            flag_update = 0;          
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_did.Text = "";
            date_acq.Text = "";
            date_ret.Text = "";
            emname_txt.Text = "Select Employee Name";
            itemname_txt.Text = "Select Item Name";
            mtxt_serial.Text = "Serial";
            btn_add.Enabled = true;
            desig_grid.ClearSelection();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            this.ActiveControl = date_acq;
            IsInserting = false;
            flag_update = 1;
           
            date_acq.Enabled = true;
            date_ret.Enabled = true;
            emname_txt.Enabled = true;
            itemname_txt.Enabled = true;
            mtxt_serial.Enabled = true;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;

            rowIndex = desig_grid.CurrentCell.RowIndex;

            foreach (DataGridViewRow row in this.desig_grid.Rows)
            {
                if (row.Selected == true)
                {
                    txt_did.Text = row.Cells[0].Value.ToString();
                    date_acq.Text = row.Cells[1].Value.ToString();
                    date_ret.Text = row.Cells[2].Value.ToString();
                    emname_txt.Text = row.Cells[3].Value.ToString();
                    itemname_txt.Text = row.Cells[4].Value.ToString();
                    mtxt_serial.Text = row.Cells[5].Value.ToString();
                    mtxt_eid.Tag =  row.Cells[6].Value.ToString();
                    mtxt_iid.Tag = row.Cells[7].Value.ToString();  
                    break;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //btn_add.Enabled = true;
            //foreach (DataGridViewRow row in this.desig_grid.Rows)
            //{
            //    if (row.Selected == true)
            //    {
            //        Delete(row.Cells[0].Value.ToString());
            //        break;
            //    }
            //}
        }

        private void desig_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                desig_grid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DesignationForm_Load(object sender, EventArgs e)
        {          
            LoadAllInfo();
            this.ActiveControl = date_acq;   
            desig_grid.ReadOnly = true;
            date_acq.Enabled = false;
            date_ret.Enabled = false;
            emname_txt.Enabled = false;
            itemname_txt.Enabled = false;
            mtxt_serial.Enabled = false;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
            desig_grid.ClearSelection();                       
        }

        private void desig_grid_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (flag_update == 1)
            {
                DialogResult mb = MetroMessageBox.Show(this, "Do you want to save first?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mb == DialogResult.Yes)
                {
                    flag_update = 0;
                    Updates();                 
                }

                else if (mb == DialogResult.No)
                {
                    flag_update = 0;

                    date_acq.Enabled = false;
                    date_ret.Enabled = false;
                   emname_txt.Enabled = false;
                   itemname_txt.Enabled = false;
                   mtxt_serial.Enabled = false;
               
                    btn_cancel.PerformClick();
                    desig_grid.CurrentCell.Selected = true;
               }
            }
        }

        private void emname_txt_Click(object sender, EventArgs e)
        {            
            EmployeeName name = new EmployeeName();

            if (name.ShowDialog(this) == DialogResult.OK)
            {
                emname_txt.Text = name.emname_grid.Rows[name.row].Cells[1].Value.ToString();
               // emname_txt.Tag = name.emname_grid.Rows[name.row].Cells[0].Value.ToString();
                mtxt_eid.Tag = name.emname_grid.Rows[name.row].Cells[0].Value.ToString();
            }
            name.Dispose();
        }

        private void itemname_txt_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            InactiveItems iname = new InactiveItems();

            if (iname.ShowDialog(this) == DialogResult.OK)
            {
               itemname_txt.Text = iname.inactive_grid.Rows[iname.row].Cells[1].Value.ToString();
               // itemname_txt.Tag = iname.item_name_grid.Rows[iname.row].Cells[0].Value.ToString();
                mtxt_iid.Tag = iname.inactive_grid.Rows[iname.row].Cells[0].Value.ToString();
               
                iname.Active();               
            }         
            iname.Dispose();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select item_name, item_serial from inventory_info where item_name = '" + itemname_txt.Text + "'", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {                 
                    mtxt_serial.Text = dataReader["item_serial"] + "";
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }         
        }      

        private void mlink_employee_Click(object sender, EventArgs e)
        {
            AddEmployee ef = new AddEmployee();          
            ef.ShowDialog();
        }
    }
}
