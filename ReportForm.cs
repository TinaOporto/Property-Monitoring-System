
using CrystalDecisions.CrystalReports.Engine;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
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
    public partial class ReportForm : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public ReportForm()
        {
            InitializeComponent();
        }
     
        private void ReportForm_Load_1(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ReportDocument myReport = new ReportDocument();
            DataSet myData = new DataSet();
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

             conn.ConnectionString = ConfigurationManager.AppSettings["connection"];
           // conn.ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";

            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "inventory_info";

                cmd.CommandText = "SELECT inventory_info.item_date, inventory_info.item_name, inventory_info.item_serial, inventory_info.bid, inventory_info.quantity, inventory_info.unit, inventory_info.`status`, inventory_info.item_description, transaction.price, inventory_info.iid FROM category_info Inner Join inventory_info ON category_info.cid = inventory_info.cid Inner Join transaction ON inventory_info.iid = transaction.iid Where inventory_info.cid= '" + mtxtx_cid.Tag + "' And date(trans_date) >='" + date_from.Value.ToString("yyyy-MM-dd") + "' And date(trans_date) <= '" + date_to.Value.ToString("yyyy-MM-dd") + "'";
                cmd.Connection = conn;

                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(dt);

                myData.Tables.Add(dt);

                string reportPath = @"C:\Users\OJT\Desktop\InventorySystem\LoginForm\CrystalReport1.rpt";
                myReport.Load(reportPath);
                myReport.SetDataSource(myData);
                crystalReportViewer1.ReportSource = myReport;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Report could not be created", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxt_cat_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
             CategoryName catname = new CategoryName();

            if(catname.ShowDialog(this) == DialogResult.OK)
            {
                mtxt_cat.Text = catname.cat_grid.Rows[catname.row].Cells[1].Value.ToString();
                mtxtx_cid.Tag = catname.cat_grid.Rows[catname.row].Cells[0].Value.ToString();
            }
        }      

        private void btn_search_all_Click(object sender, EventArgs e)
        {
            ReportDocument myReport = new ReportDocument();
            DataSet myData = new DataSet();
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            conn.ConnectionString = ConfigurationManager.AppSettings["connection"];
            //conn.ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";

            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "inventory_info";

                cmd.CommandText = "SELECT inventory_info.item_date, inventory_info.item_name, inventory_info.item_serial, inventory_info.bid, inventory_info.quantity, inventory_info.unit, inventory_info.`status`, inventory_info.item_description, transaction.price, inventory_info.iid FROM category_info Inner Join inventory_info ON category_info.cid = inventory_info.cid Inner Join transaction ON inventory_info.iid = transaction.iid Where date(trans_date) >='" + date_from.Value.ToString("yyyy-MM-dd") + "' And date(trans_date) <= '" + date_to.Value.ToString("yyyy-MM-dd") + "'";
                cmd.Connection = conn;

                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(dt);

                myData.Tables.Add(dt);

                string reportPath = @"C:\Users\OJT\Desktop\InventorySystem\LoginForm\CrystalReport1.rpt";
                myReport.Load(reportPath);
                myReport.SetDataSource(myData);
                crystalReportViewer1.ReportSource = myReport;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Report could not be created", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
    }
}
