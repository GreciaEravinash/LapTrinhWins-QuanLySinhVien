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
            txbMssv.ReadOnly = true;
            txbName.ReadOnly = true;
            txbClass.ReadOnly = true;
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
                txbDisplayName.Text = listviewAccountList.FocusedItem.SubItems[4].Text.ToString();
            }
        }

        private void DeleteAccBtn_Click(object sender, EventArgs e)
        {
            if (listviewAccountList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản bạn muốn xóa");
            }
            else
            {
                DialogResult deleteUserWarning = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (deleteUserWarning == DialogResult.Yes)
                {
                    if (!string.IsNullOrWhiteSpace(txbUsername.Text))
                    {
                        AccountDAO.Instance.deleteAccount(txbUsername.Text);

                        refreshAccountList();
                    }
                }
            }
        }

        private void refreshAccountList()
        {
            listviewAccountList.Items.Clear();

            AccountDAO.Instance.loadAccountList(listviewAccountList);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SreachAccBtn_Click(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshAccountList();

            txbClass.Clear();
            txbMssv.Clear();
            txbName.Clear();
            txbDisplayName.Clear();
            txbUsername.Clear();
        }
    }
}
