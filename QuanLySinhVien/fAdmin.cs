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

        private void getTotal()
        {
            int totalAccount = 0;

            foreach (ListViewItem item in listviewAccountList.Items)
            {
                totalAccount++;
            }
            label8.Text = "Tổng số tài khoản: ";
            label8.Text += totalAccount;
        }
        private void fAdmin_Load(object sender, EventArgs e)
        {
            lblUsername.Text += " " + fLogin.loginName;
            AccountDAO.Instance.loadAccountList(listviewAccountList);
            txbMssv.ReadOnly = true;
            txbName.ReadOnly = true;

            getTotal();

        }

        private void listviewAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewAccountList.SelectedItems.Count > 0)
            {
                txbMssv.Text = listviewAccountList.FocusedItem.SubItems[0].Text.ToString();
                txbName.Text = listviewAccountList.FocusedItem.SubItems[1].Text.ToString();
                
                txbUsername.Text = listviewAccountList.FocusedItem.SubItems[2].Text.ToString();
                txbDisplayName.Text = listviewAccountList.FocusedItem.SubItems[3].Text.ToString();
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

                        getTotal();
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
            fSearch searchForm = new fSearch();

            searchForm.currentForm = "fAdmin";

            searchForm.ShowDialog();
            if (searchForm.buttonClicked)
            {
                listviewAccountList.Items.Clear();

                AccountDAO.Instance.loadSpecificAccount(listviewAccountList, searchForm.searchType, searchForm.searchValue);

                searchForm.Close();
            }
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshAccountList();

            
            txbMssv.Clear();
            txbName.Clear();
            txbDisplayName.Clear();
            txbUsername.Clear();
        }

        

        private void ResetPassBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbUsername.Text))
            {
                DialogResult resetPasswordWarning = MessageBox.Show("Bạn có muốn reset lại mật khẩu của tài khoản này về lại mật khẩu mặc định không?", "Cảnh báo", MessageBoxButtons.OKCancel);

                if (resetPasswordWarning == DialogResult.OK)
                {
                    AccountDAO.Instance.resetPassword(txbUsername.Text);

                    refreshAccountList();
                }
            }
        }

        private void listviewAccountList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = listviewAccountList.ListViewItemSorter as ItemComparer;

            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                listviewAccountList.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            listviewAccountList.Sort();
        }

        private void AddAccBtn_Click(object sender, EventArgs e)
        {
            fAddNewAccount f = new fAddNewAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
            refreshAccountList();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHelp f = new fHelp();
            f.Show();
        }
    }
}
