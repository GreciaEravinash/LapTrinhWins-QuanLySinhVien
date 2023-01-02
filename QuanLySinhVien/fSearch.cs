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

        public int searchType; //0: blank search   1: search by MSSV   2: search by name

        public bool buttonClicked;

        public string searchValue;

        private void fSearch_Load(object sender, EventArgs e)
        {
            cmbxSearchType.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            buttonClicked = true;
            searchValue = txbSearchValue.Text;

            this.Close();

        }
    }
}
