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
    public partial class ItemsForm : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        bool IsInserting = false;        
        int rowIndex = 0;

        public ItemsForm()
        {
            InitializeComponent();
        }

        int flag_update = 0;

        private void InventoryForm_Load(object sender, EventArgs e)
        {

            LoadAllInventory();
            this.ActiveControl = date_invent;
            inventory_grid.ReadOnly = true;
            txt_iid.Enabled = false;
            date_invent.Enabled = false;
            mtxt_cat.Enabled = false;
            txt_itemname.Enabled = false;
            txt_descrip.Enabled = false;
            txt_serial.Enabled = false;
            mtxt_brand.Enabled = false;
            txt_quant.Enabled = false;
            mcmb_unit.Enabled = false;
            mcmb_stat.Enabled = false;
            btn_insave.Enabled = false;
            btn_incancel.Enabled = false;

            inventory_grid.ClearSelection();

        }

        private void btn_inadd_Click(object sender, EventArgs e)
        {
            this.ActiveControl = date_invent;
            IsInserting = true;
            txt_iid.Enabled = true;
            btn_incancel.PerformClick();

            date_invent.Enabled = true;
            mtxt_cat.Enabled = true;
            txt_itemname.Enabled = true;
            txt_descrip.Enabled = true;
            txt_serial.Enabled = true;
            txt_quant.Enabled = true;
            mcmb_unit.Enabled = true;
            mcmb_stat.Enabled = true;
            btn_incancel.Enabled = true;
            btn_insave.Enabled = true;
            btn_inadd.Enabled = false;

            inventory_grid.ClearSelection();
        }

        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into inventory_info(iid, item_date, cid, item_name, item_description, item_serial, bid, quantity, unit, status ) value('" + txt_iid.Text + "','" + date_invent.Value.ToString("yyyy-MM-dd") + "','" + mtxt_cid.Tag + "', '" + txt_itemname.Text + "','" + txt_descrip.Text + "', '" + txt_serial.Text + "','" + mtxt_bid.Tag + "', '" + txt_quant.Text + "', '" + mcmb_unit.Text + "', '" + mcmb_stat.Text + "' )", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Added Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                LoadAllInventory();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        public void LoadAllInventory()
        {
            connection = new MySqlConnection(ConnectionString);
            inventory_grid.Rows.Clear();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT inventory_info.iid, inventory_info.item_date, category_info.cat_name, inventory_info.item_name,  inventory_info.item_description, inventory_info.item_serial, brand_info.brand_name, inventory_info.quantity, inventory_info.unit, inventory_info.`status`,  category_info.cid, brand_info.bid  FROM category_info Inner Join inventory_info ON category_info.cid = inventory_info.cid Inner Join brand_info ON brand_info.bid = inventory_info.bid order by iid desc", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    inventory_grid.Rows.Add(dataReader["iid"] + "", Convert.ToDateTime(dataReader["item_date"]).ToString("yyyy-MM-dd"), dataReader["cat_name"] + "", dataReader["item_name"] + "", dataReader["item_description"] + "", dataReader["item_serial"] + "", dataReader["brand_name"] + "", dataReader["quantity"] + "", dataReader["unit"] + "", dataReader["status"] + "", dataReader["cid"] + "", dataReader["bid"] + "");
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
                MySqlCommand cmd = new MySqlCommand("update inventory_info set item_date = '" + date_invent.Value.ToString("yyyy-MM-dd") + "', cid = '" + mtxt_cid.Tag + "', item_name = '" + txt_itemname.Text + "', item_description = '" + txt_descrip.Text + "', item_serial = '" + txt_serial.Text + "', bid = '" + mtxt_bid.Tag + "', quantity ='" + txt_quant.Text + "', unit = '" + mcmb_unit.Text + "', status = '" + mcmb_stat.Text + "'  where iid = '" + txt_iid.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Updated Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                LoadAllInventory();
                this.inventory_grid.CurrentCell = this.inventory_grid[1, Convert.ToInt32(rowIndex)];
                txt_search.Text = "";
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }
      
        public void Delete(string ID)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("delete from inventory_info where iid = '" + ID + "'", connection);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                LoadAllInventory();
                btn_incancel.PerformClick();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }       

        private void btn_insave_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            if (mtxt_cat.Text == "" || txt_itemname.Text == "" || txt_quant.Text == "" || txt_descrip.Text == "" || txt_serial.Text == "" || mtxt_brand.Text == "" || mcmb_stat.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MetroMessageBox.Show(this, "Field s Empty.");
                return;
            }

            if (IsInserting == true)
            {
                connection.Open();
                string str = "Select count(*) from inventory_info where item_serial = '" + txt_serial.Text + "' or item_description = '"+ txt_descrip.Text +"'";
                MySqlCommand cmd = new MySqlCommand(str, connection);
                int itemExist = Convert.ToInt32(cmd.ExecuteScalar());
                if (itemExist > 0)
                {
                    MetroMessageBox.Show(this, "Item already exist!", "Oopps", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btn_incancel.PerformClick();
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
            InactiveItems items = new InactiveItems();
            items.FormClosed += items_FormClosed;
        }

        private void items_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAllInventory();
        }

        private void btn_incancel_Click(object sender, EventArgs e)
        {
            txt_iid.Text = "";
            date_invent.Text = "";
            mtxt_cat.Text = "Select Category";
            txt_itemname.Text = "";
            txt_descrip.Text = "";
            txt_serial.Text = "";
            mtxt_brand.Text = "Select Brand";
            txt_quant.Text = "";
            mcmb_unit.PromptText = "Unit";
            mcmb_stat.PromptText = "Select Status";

            btn_inadd.Enabled = true;
            mtxt_brand.Enabled = false;
            inventory_grid.ClearSelection();
        }

        private void inventory_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                inventory_grid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_inadd.Enabled = false;
            this.ActiveControl = date_invent;
            IsInserting = false;
            flag_update = 1;
            deleteToolStripMenuItem.Enabled = false;

            date_invent.Enabled = true;
            mtxt_cat.Enabled = true;
            txt_itemname.Enabled = true;
            txt_descrip.Enabled = true;
            txt_serial.Enabled = true;
            txt_quant.Enabled = true;
            mcmb_unit.Enabled = true;
            mcmb_stat.Enabled = true;
            btn_incancel.Enabled = true;
            btn_insave.Enabled = true;
        
            rowIndex = inventory_grid.CurrentCell.RowIndex;
            foreach (DataGridViewRow row in this.inventory_grid.Rows)
            {
                if (row.Selected == true)
                {
                    txt_iid.Text = row.Cells[0].Value.ToString();
                    date_invent.Text = row.Cells[1].Value.ToString();
                    mtxt_cat.Text = row.Cells[2].Value.ToString();
                    txt_itemname.Text = row.Cells[3].Value.ToString();
                    txt_descrip.Text = row.Cells[4].Value.ToString();
                    txt_serial.Text = row.Cells[5].Value.ToString();
                    mtxt_brand.Text = row.Cells[6].Value.ToString();
                    txt_quant.Text = row.Cells[7].Value.ToString();
                    mcmb_unit.Text = row.Cells[8].Value.ToString();
                    mcmb_stat.Text = row.Cells[9].Value.ToString();
                    mtxt_cid.Tag = row.Cells[10].Value.ToString();
                    mtxt_bid.Tag = row.Cells[11].Value.ToString();
                    break;
                }               
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_inadd.Enabled = true;

            foreach (DataGridViewRow row in this.inventory_grid.SelectedRows)
            {
                DialogResult dr = MetroMessageBox.Show(this, "Do you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {                   
                    //if (row.Selected == true)
                    //{
                        trash();
                        Delete(row.Cells[0].Value.ToString());                       
                        break;
                   // }                  
                }
                else if (dr == DialogResult.No)
                {
                    return;
                }
            }
        }       

        void display()
        {
            connection = new MySqlConnection(ConnectionString);

            if (txt_search.Text.Length > 0)
            {
                connection.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT inventory_info.iid, inventory_info.item_date, category_info.cat_name, inventory_info.item_name,  inventory_info.item_description, inventory_info.item_serial, brand_info.brand_name, inventory_info.quantity, inventory_info.unit, inventory_info.`status`,  category_info.cid, brand_info.bid  FROM category_info Inner Join inventory_info ON category_info.cid = inventory_info.cid Inner Join brand_info ON brand_info.bid = inventory_info.bid where item_name LIKE '" + txt_search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);              
                inventory_grid.Rows.Clear();
                connection.Close();

                foreach (DataRow row in dt.Rows)
                {                  
                        int n = inventory_grid.Rows.Add();
                        inventory_grid.Rows[n].Cells[0].Value = row["iid"].ToString();
                        inventory_grid.Rows[n].Cells[1].Value = Convert.ToDateTime(row["item_date"]).ToString("yyyy-MM-dd");
                        inventory_grid.Rows[n].Cells[2].Value = row["cat_name"].ToString();
                        inventory_grid.Rows[n].Cells[3].Value = row["item_name"].ToString();
                        inventory_grid.Rows[n].Cells[4].Value = row["item_description"].ToString();
                        inventory_grid.Rows[n].Cells[5].Value = row["item_serial"].ToString();
                        inventory_grid.Rows[n].Cells[6].Value = row["brand_name"].ToString();
                        inventory_grid.Rows[n].Cells[7].Value = row["quantity"].ToString();
                        inventory_grid.Rows[n].Cells[8].Value = row["unit"].ToString();
                        inventory_grid.Rows[n].Cells[9].Value = row["status"].ToString();
                        inventory_grid.Rows[n].Cells[10].Value = row["cid"].ToString();
                        inventory_grid.Rows[n].Cells[11].Value = row["bid"].ToString();                                       
                }
            }          
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {          
            display();          

            if (txt_search.Text == "")
            {
                  LoadAllInventory();                 
            }
        }

        private void inventory_grid_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            deleteToolStripMenuItem.Enabled = true;

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

                    date_invent.Enabled = false;
                    mtxt_cat.Enabled = false;
                    txt_itemname.Enabled = false;
                    txt_descrip.Enabled = false;
                    txt_serial.Enabled = false;
                    mtxt_brand.Enabled = false;
                    txt_quant.Enabled = false;
                    mcmb_unit.Enabled = false;
                    mcmb_stat.Enabled = false;

                    btn_incancel.PerformClick();
                    inventory_grid.CurrentCell.Selected = true;
                }
            }
        }

        private void txt_quant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            var validKeys = new[] { Keys.Back, Keys.D1 };
            e.Handled = !validKeys.Contains((Keys)e.KeyChar);
        }

        private void mtxt_cat_Click(object sender, EventArgs e)
        {
            mtxt_brand.Enabled = true;
            mtxt_brand.Clear();
            //MessageBox.Show("" + mtxt_cid.Tag);
            connection = new MySqlConnection(ConnectionString);
            CategoryName catname = new CategoryName();
            BrandForm brand = new BrandForm();

            if (catname.ShowDialog(this) == DialogResult.OK)
            {
                mtxt_cat.Text = catname.cat_grid.Rows[catname.row].Cells[1].Value.ToString();
                //mtxt_cat.Tag = catname.cat_grid.Rows[catname.row].Cells[0].Value.ToString();
                mtxt_cid.Tag = catname.cat_grid.Rows[catname.row].Cells[0].Value.ToString();
            }
            catname.Dispose();
        }

        private void mtxt_brand_Click(object sender, EventArgs e)
        {
            // connection = new MySqlConnection(ConnectionString);
            BrandForm brand = new BrandForm();
            brand.cid = mtxt_cid.Tag.ToString();
            if (brand.ShowDialog(this) == DialogResult.OK)
            {
                mtxt_brand.Text = brand.brand_grid.Rows[brand.row].Cells[1].Value.ToString();
                // mtxt_brand.Tag = brand.brand_grid.Rows[brand.row].Cells[0].Value.ToString();
                mtxt_bid.Tag = brand.brand_grid.Rows[brand.row].Cells[0].Value.ToString();
            }
            brand.Dispose();
        }

        private void mlink_reports_Click(object sender, EventArgs e)
        {
            InventoryReport report = new InventoryReport();
            report.ShowDialog();
        }

        private void mlink_whouse_Click(object sender, EventArgs e)
        {
            Warehouse whouse = new Warehouse();
            whouse.FormClosed += whouse_FormClosed;
            whouse.ShowDialog();
        }

        private void whouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAllInventory();
        }

        private void trash()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Trash(iid, item_date, cid, item_name, item_description, item_serial, bid, quantity, unit, status) VALUES('" + inventory_grid.CurrentRow.Cells[0].Value.ToString() + "','" + Convert.ToDateTime(inventory_grid.CurrentRow.Cells[1].Value).ToString("yyyy-MM-dd") + "','" + inventory_grid.CurrentRow.Cells[10].Value.ToString() + "','" + inventory_grid.CurrentRow.Cells[3].Value.ToString() + "','" + inventory_grid.CurrentRow.Cells[4].Value.ToString() + "','" + inventory_grid.CurrentRow.Cells[5].Value.ToString() + "','" + inventory_grid.CurrentRow.Cells[11].Value.ToString() + "','" + inventory_grid.CurrentRow.Cells[7].Value.ToString() + "','" + inventory_grid.CurrentRow.Cells[8].Value.ToString() + "','" + inventory_grid.CurrentRow.Cells[9].Value.ToString() + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                LoadAllInventory();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }       
    }
}
