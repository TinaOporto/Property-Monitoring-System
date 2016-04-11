using MetroFramework;
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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];
        DataTable table = new DataTable();
        
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = txt_uname;           
        }       

        private void btn_login_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT uname, pword From users Where uname = '" + txt_uname.Text + "' AND  pword = '" + txt_pword.Text + "' and status = 'Active'", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                cmd.ExecuteNonQuery();
                connection.Close();

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {                   
                    MainForm main = new MainForm();
                    main.FormClosed += new FormClosedEventHandler(mainformclosed);
                    main.Show();
                    this.Hide();                
                }               
                else
                {
                    btn_cancel.PerformClick();
                    MetroMessageBox.Show(this, "Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }
            }      
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message);
                }
            }         

        private void mainformclosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();         
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_uname.Text = "";
            txt_pword.Text = "";            
        }

        private void btn_1_Click(object sender, EventArgs e)
        { 
           
            MainForm main = new MainForm();
            main.FormClosed += new FormClosedEventHandler(mainformclosed);
            main.Show();
            this.Hide();   
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Incorrect Password!");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Incorrect Password!");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Incorrect Password!");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.FormClosed += new FormClosedEventHandler(mainformclosed);
            main.Show();
            this.Hide();   
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Incorrect Password!");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Incorrect Password!");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Incorrect Password!");
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.FormClosed += new FormClosedEventHandler(mainformclosed);
            main.Show();
            this.Hide();   
        }
               
    }
}
