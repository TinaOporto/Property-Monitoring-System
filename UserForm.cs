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
    public partial class UserForm : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];
       
        bool IsInserting = false;        
        int rowIndex = 0;      

        public UserForm()
        {
            InitializeComponent();           
        }
        
        string Status;
        int flag_update = 0;
       
        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);
           
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into users(uid, uname, pword, fname, lname, acct_type,status ) value('" + txtuid.Text + "', '" + txtuname.Text + "', '" + txtpword.Text + "', '" + txtfname.Text + "', '" + txtlname.Text + "','" + mcmb_acct.Text + "', '"+ mcmb_status.Text +"' )", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Added Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                LoadAllUsers();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }          
        }

         private void LoadAllUsers()
         {
            connection = new MySqlConnection(ConnectionString);
            user_grid.Rows.Clear();
           
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from users order by uid desc ", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    user_grid.Rows.Add(dataReader["uid"] + "", dataReader["uname"] + "", dataReader["pword"] + "", dataReader["fname"] + "", dataReader["lname"] + "", dataReader["acct_type"]+"", dataReader["status"]+"");
                }
                connection.Close();       
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }           
        }

        private void LoadAllActiveUsers()
        {
             connection = new MySqlConnection(ConnectionString);
             user_grid.Rows.Clear();

             try
             {
                 connection.Open();
                 MySqlCommand cmd = new MySqlCommand("select * from users where status = 'Active' order by uid desc ", connection);
                 MySqlDataReader dataReader = cmd.ExecuteReader();
                 while (dataReader.Read())
                 {
                     user_grid.Rows.Add(dataReader["uid"] + "", dataReader["uname"] + "", dataReader["pword"] + "", dataReader["fname"] + "", dataReader["lname"] + "", dataReader["acct_type"] + "", dataReader["status"] + "");
                 }
                 connection.Close();
             }
             catch (Exception ex)
             {
                 MetroMessageBox.Show(this, ex.Message);
             }
         }

        private void LoadAllInactiveUsers()
        {
            connection = new MySqlConnection(ConnectionString);
            user_grid.Rows.Clear();
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from users where status = 'Inactive' order by uid desc ", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    user_grid.Rows.Add(dataReader["uid"] + "", dataReader["uname"] + "", dataReader["pword"] + "", dataReader["fname"] + "", dataReader["lname"] + "", dataReader["acct_type"] + "", dataReader["status"] + "");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

         private void btn_add_Click(object sender, EventArgs e)
         {
             this.ActiveControl = txtuname;
             IsInserting = true;
             btn_cancel.PerformClick();

             txtuid.Enabled = true;
             txtuname.Enabled = true;
             txtpword.Enabled = true;
             mchkb_passchar.Enabled = true;
             txtfname.Enabled = true;
             txtlname.Enabled = true;
             mcmb_acct.Enabled = true;
             mcmb_status.Enabled = true;
             btn_save.Enabled = true;
             btn_cancel.Enabled = true;
             btn_add.Enabled = false;

             user_grid.ClearSelection();            
         }

         private void btn_save_Click(object sender, EventArgs e)
         {
           connection = new MySqlConnection(ConnectionString);

             if (txtuname.Text == "" || txtpword.Text == "" || txtfname.Text == "" || txtlname.Text == "" || mcmb_acct.Text == "" || mcmb_status.Text == "")
             {
                 string myStringVariable1 = string.Empty;
                 MetroMessageBox.Show(this, "Field is Empty.");
                 return;
             }
           
                 if (IsInserting == true)
                 {
                     connection.Open();

                     string str = "Select count(*) from users where fname = '" + txtfname.Text + "' and lname = '"+ txtlname.Text +"'";
                     MySqlCommand cmd = new MySqlCommand(str, connection);
                     int userExist = Convert.ToInt32(cmd.ExecuteScalar());
                     if (userExist > 0)
                     {
                         MetroMessageBox.Show(this, "User already exist!", "Oopps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

         private void UserForm_Load(object sender, EventArgs e)
         {             
             LoadAllUsers();
             this.ActiveControl = txtuname;
             user_grid.ReadOnly = true;
             mrd_all.Checked = true;

             txtuid.Enabled = false;
             txtuname.Enabled = false;
             txtpword.Enabled = false;
             mchkb_passchar.Enabled = false;
             txtfname.Enabled = false;
             txtlname.Enabled = false;
             mcmb_acct.Enabled = false;
             mcmb_status.Enabled = false;
             btn_save.Enabled = false;
             btn_cancel.Enabled = false;

             user_grid.ClearSelection();        
         }
       
         private void btn_cancel_Click(object sender, EventArgs e)
         {
             txtuid.Text = "";
             txtuname.Text = "";
             txtpword.Text = "";
             txtfname.Text = "";
             txtlname.Text = "";
             mcmb_acct.PromptText = "Select Account Type";
             mcmb_status.PromptText = "Select Status";
             mrd_active.Checked = false;
             mrd_inactive.Checked = false;
             mrd_all.Checked = true;
             Status = "";
             btn_add.Enabled = true;
             user_grid.ClearSelection();     
         }    

         private void Updates()
         {            
             connection = new MySqlConnection(ConnectionString);            
             try
             {
                 connection.Open();
                 MySqlCommand cmd = new MySqlCommand("update users set uname = '" + txtuname.Text + "', pword = '" + txtpword.Text + "',  fname = '" + txtfname.Text + "', lname = '" + txtlname.Text + "', acct_type = '" + mcmb_acct.Text + "', status = '"+ mcmb_status.Text +"' where uid = '" + txtuid.Text + "'", connection);
                 cmd.ExecuteNonQuery();
                 MetroMessageBox.Show(this, "Updated Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                 connection.Close();

                if(mrd_all.Checked == true)
                {
                    LoadAllUsers();
                }
                 if (mrd_active.Checked == true)
                 {
                     LoadAllActiveUsers();
                 }
                 else if (mrd_inactive.Checked == true)
                 {
                     LoadAllInactiveUsers();
                 }
                
                 this.user_grid.CurrentCell = this.user_grid[1, Convert.ToInt32(rowIndex)];                 
             }
             catch (Exception ex)
             {
                 MetroMessageBox.Show(this, ex.Message);
             }            
         }

         private void updateToolStripMenuItem_Click(object sender, EventArgs e)
         {          
             this.ActiveControl = txtuname;
             IsInserting = false;
             btn_add.Enabled = false;
            
             flag_update = 1;

             txtuid.Enabled = true;
             txtuname.Enabled = true;
             txtpword.Enabled = true;
             mchkb_passchar.Enabled = true;
             txtfname.Enabled = true;
             txtlname.Enabled = true;
             mcmb_acct.Enabled = true;
             mcmb_status.Enabled = true;
             btn_save.Enabled = true;
             btn_cancel.Enabled = true;

             rowIndex = user_grid.CurrentCell.RowIndex;
   
             foreach (DataGridViewRow row in this.user_grid.Rows)
             {
                 if (row.Selected == true)
                 {
                     txtuid.Text = row.Cells[0].Value.ToString();
                     txtuname.Text = row.Cells[1].Value.ToString();
                     txtpword.Text = row.Cells[2].Value.ToString();
                     txtfname.Text = row.Cells[3].Value.ToString();
                     txtlname.Text = row.Cells[4].Value.ToString();
                     mcmb_acct.Text = row.Cells[5].Value.ToString();
                     mcmb_status.Text = row.Cells[6].Value.ToString();
                     break;
                 }              
             }            
         }        
        
         private void mchkb_passchar_CheckedChanged(object sender, EventArgs e)
         {             
             if(mchkb_passchar.Checked)
             {
                txtpword.UseSystemPasswordChar = false;
             }           
            else
            {
                txtpword.UseSystemPasswordChar = true;
            }
        }
      
         private void mrd_active_CheckedChanged(object sender, EventArgs e)
         {
             Status = "Active";
             updateToolStripMenuItem.Visible = true;

             MySqlDataAdapter sda = new MySqlDataAdapter("Select * FROM users Where status = 'Active' order by uid desc", connection);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             user_grid.Rows.Clear();

             foreach (DataRow row in dt.Rows)
             {
                 int n = user_grid.Rows.Add();
                 user_grid.Rows[n].Cells[0].Value = row["uid"].ToString();
                 user_grid.Rows[n].Cells[1].Value = row["uname"].ToString();
                 user_grid.Rows[n].Cells[2].Value = row["pword"].ToString();
                 user_grid.Rows[n].Cells[3].Value = row["fname"].ToString();
                 user_grid.Rows[n].Cells[4].Value = row["lname"].ToString();
                 user_grid.Rows[n].Cells[5].Value = row["acct_type"].ToString();
                 user_grid.Rows[n].Cells[6].Value = row["status"].ToString();                 
             }
         }

         private void mrd_inactive_CheckedChanged(object sender, EventArgs e)
         {
             Status = "Inactive";
             updateToolStripMenuItem.Visible = true;

             MySqlDataAdapter sda = new MySqlDataAdapter("Select * FROM users Where status = 'Inactive' order by uid desc", connection);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             user_grid.Rows.Clear();

             foreach (DataRow row in dt.Rows)
             {
                 int n = user_grid.Rows.Add();
                 user_grid.Rows[n].Cells[0].Value = row["uid"].ToString();
                 user_grid.Rows[n].Cells[1].Value = row["uname"].ToString();
                 user_grid.Rows[n].Cells[2].Value = row["pword"].ToString();
                 user_grid.Rows[n].Cells[3].Value = row["fname"].ToString();
                 user_grid.Rows[n].Cells[4].Value = row["lname"].ToString();
                 user_grid.Rows[n].Cells[5].Value = row["acct_type"].ToString();
                 user_grid.Rows[n].Cells[6].Value = row["status"].ToString();                               
             }           
         }

         private void mrd_all_CheckedChanged(object sender, EventArgs e)
         {
             Status = "All";           
            
             MySqlDataAdapter sda = new MySqlDataAdapter("Select * FROM users Where status = 'Inactive' OR status = 'Active' order by uid desc", connection);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             user_grid.Rows.Clear();

             foreach (DataRow row in dt.Rows)
             {
                 int n = user_grid.Rows.Add();
                 user_grid.Rows[n].Cells[0].Value = row["uid"].ToString();
                 user_grid.Rows[n].Cells[1].Value = row["uname"].ToString();
                 user_grid.Rows[n].Cells[2].Value = row["pword"].ToString();
                 user_grid.Rows[n].Cells[3].Value = row["fname"].ToString();
                 user_grid.Rows[n].Cells[4].Value = row["lname"].ToString();
                 user_grid.Rows[n].Cells[5].Value = row["acct_type"].ToString();
                 user_grid.Rows[n].Cells[6].Value = row["status"].ToString();
             }
         }         

         private void user_grid_CellClick_2(object sender, DataGridViewCellEventArgs e)
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

                     txtuid.Enabled = false;
                     txtuname.Enabled = false;
                     txtpword.Enabled = false;
                     txtfname.Enabled = false;
                     txtlname.Enabled = false;
                     mcmb_acct.Enabled = false;
                     mcmb_status.Enabled = false;

                     btn_cancel.PerformClick();
                     user_grid.CurrentCell.Selected = true;
                 }
             }
         }      
        
         private void user_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
         {
             if(e.ColumnIndex == 2)
             {
                 e.Value = "*****";
             }
         }         
    }
}
