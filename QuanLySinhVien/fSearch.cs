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
            txbSearchName.Enabled = false;
            
        }

        private void rdbtnSearchMSSV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSearchMSSV.Checked)
            {
                txbSearchMSSV.Enabled = true;
            }
            else
            {
                txbSearchMSSV.Enabled = false;
            }
        }

        private void rdbtnSearchName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSearchName.Checked)
            {
                txbSearchName.Enabled = true;
            }
            else
            {
                txbSearchName.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbtnSearchMSSV.Checked && !string.IsNullOrWhiteSpace(txbSearchMSSV.Text))
            {
                searchType = 1;
                searchValue = txbSearchMSSV.Text;
                
            }
            else if (rdbtnSearchName.Checked && !string.IsNullOrWhiteSpace(txbSearchName.Text))
            {
                searchType = 2;
                searchValue = txbSearchName.Text;
                
            }
            else
            {
                searchType = 0;
            }
            buttonClicked = true;
            this.Hide();
        }
    }
}
