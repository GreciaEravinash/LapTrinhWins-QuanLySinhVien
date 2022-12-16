using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.DAO;

namespace QuanLySinhVien
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            lblUsername.Text += " " + fLogin.loginName;
            AccountDAO.Instance.loadAccountList(listviewAccountList);
        }

        private void AcpHaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditAccBtn_Click(object sender, EventArgs e)
        {

        }

        private void listviewAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewAccountList.SelectedItems.Count > 0)
            {
                txbMssv.Text = listviewAccountList.FocusedItem.SubItems[0].Text.ToString();
                txbName.Text = listviewAccountList.FocusedItem.SubItems[1].Text.ToString();
                txbClass.Text = listviewAccountList.FocusedItem.SubItems[2].Text.ToString();
                txbUsername.Text = listviewAccountList.FocusedItem.SubItems[3].Text.ToString();
                txbPassword.Text = listviewAccountList.FocusedItem.SubItems[4].Text.ToString();
            }
        }
    }
}
