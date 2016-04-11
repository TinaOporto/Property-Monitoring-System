using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            System.Windows.Forms.Form user = System.Windows.Forms.Application.OpenForms["LoginForm"];
           // mlbl_user.Text = ((LoginForm)user).txt_uname.Text;

            FrontForm front = new FrontForm();
            front.MdiParent = this;
            front.Dock = DockStyle.Fill;
            front.Show();
        }         

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {            
            try
            {
            
            TreeNode node = treeView1.SelectedNode;

            if (node.Text == "Manage User")
            {
                UserForm usersetup = new UserForm();
                usersetup.MdiParent = this;
                usersetup.Dock = DockStyle.Fill;
                usersetup.Show();
            }
            if (node.Text == "Manage Items")
            {
                ItemsForm inventory = new ItemsForm();
                inventory.MdiParent = this;
                inventory.Dock = DockStyle.Fill;
                inventory.Show();
            }
            if (node.Text == "Employee Details")
            {
                EmployeeForm employee = new EmployeeForm();
                employee.MdiParent = this;
                employee.Dock = DockStyle.Fill;
                employee.Show();
            }
            if (node.Text == "Transaction")
            {
                TransactionForm transac = new TransactionForm();
                transac.MdiParent = this;
                transac.Dock = DockStyle.Fill;
                transac.Show();
            }
            if (node.Text == "Designation")
            {
                DesignationForm desig = new DesignationForm();
                desig.MdiParent = this;
                desig.Dock = DockStyle.Fill;
                desig.Show();
            }
            if (node.Text == "Generate Reports")
            {
                ReportForm report = new ReportForm();
                report.MdiParent = this;
                report.Dock = DockStyle.Fill;
                report.Show();
            }
            if (node.Text == "Trash")
            {
                TrashForm trash = new TrashForm();
                trash.MdiParent = this;
                trash.Dock = DockStyle.Fill;
                trash.Show();
            }
        }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }                     
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {           
            DialogResult log = MetroMessageBox.Show(this, "Do you want to exit?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(log == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void CloseOpen()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }   
    }
}
