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
    public partial class InventoryReport : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public InventoryReport()
        {
            InitializeComponent();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
        }

        private void mbtn_search_Click(object sender, EventArgs e)
        {
            ReportDocument myReport = new ReportDocument();
            DataSet myData = new DataSet();
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

           // conn.ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";
             conn.ConnectionString = ConfigurationManager.AppSettings["connection"];

            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "inventory_info";


                cmd.CommandText = "Select * from inventory_info where cid = '" + mtxt_cid.Tag + "' And date(item_date) >='" + mdate_from.Value.ToString("yyyy-MM-dd") + "' And date(item_date) <= '" + mdate_to.Value.ToString("yyyy-MM-dd") + "'";
                cmd.Connection = conn;

                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(dt);

                myData.Tables.Add(dt);

                string reportPath = @"C:\Users\OJT\Desktop\InventorySystem\LoginForm\CrystalReport2.rpt";
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

            if (catname.ShowDialog(this) == DialogResult.OK)
            {
                mtxt_cat.Text = catname.cat_grid.Rows[catname.row].Cells[1].Value.ToString();
                //mtxt_cat.Tag = catname.cat_grid.Rows[catname.row].Cells[0].Value.ToString();
                mtxt_cid.Tag = catname.cat_grid.Rows[catname.row].Cells[0].Value.ToString();

            }
        }          
    }
}
