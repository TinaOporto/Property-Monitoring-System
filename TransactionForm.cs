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
    public partial class TransactionForm : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        bool IsInserting = false;
        int rowIndex = 0;

        public TransactionForm()
        {
            InitializeComponent();
        }

        int flag_update = 0;

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.ActiveControl = date_trans;
            IsInserting = true;
            btn_cancel.PerformClick();
            transac_grid.ClearSelection();

            txt_tid.Enabled = true;
            date_trans.Enabled = true;
            item_txt.Enabled = true;
            mtxt_serial.Enabled = true;
            txt_quant.Enabled = true;
            txt_price.Enabled = true;
            txt_supp.Enabled = true;
            txt_warrant.Enabled = true;
            pic_receipts.Enabled = true;

            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
        }

        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                string res = pic_receipts.ImageLocation.ToString().Replace(@"\", "|");
                // string[] splitinfoname = cmb_itemname.Text.Split(new Char[] { '-' });
                MySqlCommand cmd = new MySqlCommand("insert into transaction(trans_date, iid, item_serial, quantity, price, supplier, warranty, receipts) value('" + date_trans.Value.ToString("yyyy-MM-dd") + "',  '" + mtxt_iid.Tag + "' , '" + mtxt_serial.Text + "', '" + txt_quant.Text + "','" + txt_price.Text + "', '" + txt_supp.Text + "', '" + txt_warrant.Text + "', '" + res + "')", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Added Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                LoadAllTransaction();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void LoadAllTransaction()
        {
            connection = new MySqlConnection(ConnectionString);
            transac_grid.Rows.Clear();
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT transaction.tid, transaction.trans_date, inventory_info.item_name, inventory_info.item_serial, transaction.quantity, transaction.price, transaction.supplier, transaction.warranty, transaction.receipts, inventory_info.iid FROM transaction Inner Join inventory_info ON transaction.iid = inventory_info.iid ORDER BY transaction.tid Desc ", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    transac_grid.Rows.Add(dataReader["tid"] + "", Convert.ToDateTime(dataReader["trans_date"]).ToString("yyyy-MM-dd"), dataReader["item_name"] + "", dataReader["item_serial"] + "", dataReader["quantity"] + "", dataReader["price"] + "", dataReader["supplier"] + "", dataReader["warranty"] + "", dataReader["receipts"] + "", dataReader["iid"] + "");
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
                string res = pic_receipts.ImageLocation.ToString().Replace(@"\", "|");
                // string[] splitinfoname = cmb_itemname.Text.Split(new Char[] { '-' });

                string qString = "update transaction set trans_date = '" + date_trans.Value.ToString("yyyy-MM-dd") + "', iid = '" + mtxt_iid.Tag + "', item_serial = '" + mtxt_serial.Text + "', quantity = '" + txt_quant.Text + "', price = '" + txt_price.Text + "', supplier = '" + txt_supp.Text + "', warranty ='" + txt_warrant.Text + "', receipts ='" + res + "'  where tid = '" + txt_tid.Text + "' ";
                // MessageBox.Show("" + item_txt.Tag);
                MySqlCommand cmd = new MySqlCommand(qString, connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Updated Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                transac_grid.Update();
                transac_grid.Refresh();
                connection.Close();
                LoadAllTransaction();

                this.transac_grid.CurrentCell = this.transac_grid[1, Convert.ToInt32(rowIndex)];
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
                MySqlCommand cmd = new MySqlCommand("delete from transaction where tid = '" + ID + "'", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Deleted Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                LoadAllTransaction();
                btn_cancel.PerformClick();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            if (item_txt.Text == "" || txt_quant.Text == "" || txt_price.Text == "" || mtxt_serial.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MetroMessageBox.Show(this, "Field  is Empty.");
                return;
            }

            if (IsInserting == true)
            {
                connection.Open();
                string str = "Select count(*) from transaction where item_serial = '" + mtxt_serial.Text + "'";
                MySqlCommand cmd = new MySqlCommand(str, connection);
                int itemExist = Convert.ToInt32(cmd.ExecuteScalar());
                if (itemExist > 0)
                {
                    MetroMessageBox.Show(this, "Item already transact!", "Oopps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txt_tid.Text = "";
            date_trans.Text = "";
            item_txt.Text = "Select Item";
            mtxt_serial.Text = "Serial";
            txt_quant.Text = "";
            txt_price.Text = "";
            txt_supp.Text = "";
            txt_warrant.Text = "";
            pic_receipts.ImageLocation = "";

            btn_add.Enabled = true;
            transac_grid.ClearSelection();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            this.ActiveControl = date_trans;
            IsInserting = false;
            flag_update = 1;

            txt_tid.Enabled = true;
            date_trans.Enabled = true;
            item_txt.Enabled = true;
            mtxt_serial.Enabled = true;
            txt_quant.Enabled = true;
            txt_price.Enabled = true;
            txt_supp.Enabled = true;
            txt_warrant.Enabled = true;
            pic_receipts.Enabled = true;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;

            rowIndex = transac_grid.CurrentCell.RowIndex;

            foreach (DataGridViewRow row in this.transac_grid.Rows)
            {
                if (row.Selected == true)
                {
                    txt_tid.Text = row.Cells[0].Value.ToString();
                    date_trans.Text = row.Cells[1].Value.ToString();
                    item_txt.Text = row.Cells[2].Value.ToString();
                    mtxt_serial.Text = row.Cells[3].Value.ToString();
                    txt_quant.Text = row.Cells[4].Value.ToString();
                    txt_price.Text = row.Cells[5].Value.ToString();
                    txt_supp.Text = row.Cells[6].Value.ToString();
                    txt_warrant.Text = row.Cells[7].Value.ToString();
                    pic_receipts.ImageLocation = row.Cells[8].Value.ToString().Replace("|", @"\"); ;
                    mtxt_iid.Tag = row.Cells[9].Value.ToString();

                    break;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            foreach (DataGridViewRow row in this.transac_grid.Rows)
            {
                DialogResult dr = MetroMessageBox.Show(this, "Do you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    if (row.Selected == true)
                    {
                        Delete(row.Cells[0].Value.ToString());
                        break;
                    }
                }
                else if(dr == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void transac_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                transac_grid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            LoadAllTransaction();
           
            this.ActiveControl = date_trans;
            transac_grid.ReadOnly = true;
            transac_grid.ClearSelection();

            txt_tid.Enabled = false;
            date_trans.Enabled = false;
            item_txt.Enabled = false;
            mtxt_serial.Enabled = false;
            txt_quant.Enabled = false;
            txt_price.Enabled = false;
            txt_supp.Enabled = false;
            txt_warrant.Enabled = false;
            pic_receipts.Enabled = false;

            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
        }

     

        private void pic_receipts_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile1 = new OpenFileDialog();
            if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = openfile1.FileName;

                if (filepath != string.Empty)
                {
                    pic_receipts.ImageLocation = filepath;
                }
            }
        }

        private void transac_grid_CellClick_2(object sender, DataGridViewCellEventArgs e)
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

                    txt_tid.Enabled = false;
                    date_trans.Enabled = false;
                    txt_quant.Enabled = false;
                    item_txt.Enabled = false;
                    mtxt_serial.Enabled = false;
                    txt_price.Enabled = false;
                    txt_supp.Enabled = false;
                    txt_warrant.Enabled = false;
                    pic_receipts.Enabled = false;

                    btn_cancel.PerformClick();
                    transac_grid.CurrentCell.Selected = true;
                }
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void item_txt_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            ItemName iname = new ItemName();

            if (iname.ShowDialog(this) == DialogResult.OK)
            {
                item_txt.Text = iname.item_name_grid.Rows[iname.row].Cells[1].Value.ToString();
                // item_txt.Tag = iname.item_name_grid.Rows[iname.row].Cells[0].Value.ToString();
                mtxt_iid.Tag = iname.item_name_grid.Rows[iname.row].Cells[0].Value.ToString();
            }
            iname.Dispose();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select item_name, item_serial, quantity from inventory_info where item_name = '" + item_txt.Text + "'", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    txt_quant.Text = dataReader["quantity"] + "";
                    mtxt_serial.Text = dataReader["item_serial"] + "";
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }
    }
}

        
    
