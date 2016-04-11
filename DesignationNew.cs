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
    public partial class DesignationNew : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public DesignationNew()
        {
            InitializeComponent();
            date_acq.MinDate = DateTime.MinValue;
            date_ret.MaxDate = DateTime.Now.AddMonths(6);
        }

        public int rowIndex = 0;
        DesignationForm df = new DesignationForm();

        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);     
            connection.Open();
            // string[] splitinfoname = emname_txt.Text.Split(new Char[] { '-' });
            //string[] splitinfoitem = itemname_txt.Text.Split(new Char[] { '-' });
            MySqlCommand cmd = new MySqlCommand("insert into designation_info(did, date_acquired, date_returned, eid, iid, item_serial) value('"+ txt_did.Text +"', '" + date_acq.Value.ToString("yyyy-MM-dd") + "','" + date_ret.Value.ToString("yyyy-MM-dd") + "', '" + mtxt_eid.Tag + "', '" + mtxt_iid.Text + "', '" + mtxt_serial.Text + "' )", connection);
            cmd.ExecuteNonQuery();        
            connection.Close();                    
        }

        private void LoadAllInfo()
        {
            connection = new MySqlConnection(ConnectionString);
            df.desig_grid.Rows.Clear();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT designation_info.did, designation_info.date_acquired, designation_info.date_returned, employee_info.em_fname, employee_info.em_lname, inventory_info.item_name,  inventory_info.item_serial, employee_info.eid, inventory_info.iid FROM designation_info Inner Join inventory_info ON inventory_info.iid = designation_info.iid Inner Join employee_info ON employee_info.eid = designation_info.eid order by did desc", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    df.desig_grid.Rows.Add(dataReader["did"] + "", Convert.ToDateTime(dataReader["date_acquired"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(dataReader["date_returned"]).ToString("yyyy-MM-dd"), dataReader["em_fname"] + "", dataReader["item_name"] + "", dataReader["item_serial"] + "", dataReader["eid"] + "", dataReader["iid"] + "");
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
            try
            {
                if (emname_txt.Text == "" || itemname_txt.Text == "")
                {
                    string myStringVariable1 = string.Empty;
                    MetroMessageBox.Show(this, "Field  is Empty.");
                }

                else
                {
                    Insert();
                    LoadAllInfo();
                    MetroMessageBox.Show(this, "Added Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnOK.PerformClick();
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }                  
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_did.Text = "";
            date_acq.Text = "";
            date_ret.Text = "";
            emname_txt.Text = "Select Employee Name";
            itemname_txt.Text = "Select Item Name";
            mtxt_serial.Text = "Serial";
          
            df.desig_grid.ClearSelection();
        }

        private void DesignationNew_Load(object sender, EventArgs e)
        {
            LoadAllInfo();
            this.ActiveControl = date_acq;
            df.desig_grid.ReadOnly = true;

            df.desig_grid.ClearSelection();
        }

        private void emname_txt_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            EmployeeName name = new EmployeeName();

            if (name.ShowDialog(this) == DialogResult.OK)
            {
                emname_txt.Text = name.emname_grid.Rows[name.row].Cells[1].Value.ToString();
                //emname_txt.Tag = name.emname_grid.Rows[name.row].Cells[0].Value.ToString();
                mtxt_eid.Tag = name.emname_grid.Rows[name.row].Cells[0].Value.ToString();
            }
            name.Dispose();
        }             
    }
}
