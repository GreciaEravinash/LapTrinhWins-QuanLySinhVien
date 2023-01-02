using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class fSearch : Form
    {
        public fSearch()
        {
            InitializeComponent();
        }
        public string currentForm = "";

        public int searchType; //0: blank search   1: search by MSSV   2: search by name

        public bool buttonClicked;

        public string searchValue;

        private void fSearch_Load(object sender, EventArgs e)
        {
            if (currentForm == "fAdmin")
            {
                cmbxSearchType.Items.Clear();

                cmbxSearchType.Items.Add("Tìm kiếm theo MSSV");

                cmbxSearchType.Items.Add("Tìm kiếm theo tên tài khoản");

                cmbxSearchType.Items.Add("Tìm kiếm theo tên hiển thị");
            }
            cmbxSearchType.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (currentForm == "")
            {
                if (cmbxSearchType.SelectedIndex == 0 && !string.IsNullOrWhiteSpace(txbSearchValue.Text))
                {
                    searchType = 1;
                }
                else if (cmbxSearchType.SelectedIndex == 1 && !string.IsNullOrWhiteSpace(txbSearchValue.Text))
                {
                    searchType = 2;
                }
                else
                {
                    searchType = 0;
                }
            }
            else
            {
                if (cmbxSearchType.SelectedIndex == 0 && !string.IsNullOrWhiteSpace(txbSearchValue.Text))
                {
                    searchType = 1;
                }
                else if (cmbxSearchType.SelectedIndex == 1 && !string.IsNullOrWhiteSpace(txbSearchValue.Text))
                {
                    searchType = 2;
                }
                else if (cmbxSearchType.SelectedIndex == 2 && !string.IsNullOrWhiteSpace(txbSearchValue.Text))
                {
                    searchType = 3;
                }
                else
                {
                    searchType = 0;
                }
            }
            buttonClicked = true;
            searchValue = txbSearchValue.Text;

            this.Close();

        }
    }
}
