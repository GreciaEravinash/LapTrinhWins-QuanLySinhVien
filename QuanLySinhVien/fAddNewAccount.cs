using QuanLySinhVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class fAddNewAccount : Form
    {
        public fAddNewAccount()
        {
            InitializeComponent();
        }

        private void fAddNewAccount_Load(object sender, EventArgs e)
        {
            AdminRBtn.Checked = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(MssvAccTxt.Text) && StudentRBtn.Checked ) || string.IsNullOrWhiteSpace(NameAcctxt.Text) || string.IsNullOrWhiteSpace(DisplatnameAcctxt.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ các thông tin cần thiết");
            }
            else
            {
                int type;
                if (AdminRBtn.Checked)
                {
                    type = 1;
                }
                else type = 0;
                if (AccountDAO.Instance.createNewAccount(type, MssvAccTxt.Text, NameAcctxt.Text, UsernameAcctxt.Text, DisplatnameAcctxt.Text))
                {
                    this.Close();
                }
            }
        }

        private void MssvAccTxt_TextChanged(object sender, EventArgs e)
        {
            UsernameAcctxt.Text = MssvAccTxt.Text;
        }

        private void NameAcctxt_TextChanged(object sender, EventArgs e)
        {
            DisplatnameAcctxt.Text = NameAcctxt.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminRBtn.Checked)
            {
                MssvAccTxt.Enabled = false;

                UsernameAcctxt.Enabled = true;
            }
            else
            {
                MssvAccTxt.Enabled = true;

                UsernameAcctxt.Enabled = false;
            }
        }

        private void StudentRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (StudentRBtn.Checked)
            {
                //MssvAccTxt.ReadOnly = false;

                //UsernameAcctxt.ReadOnly = true;

                MssvAccTxt.Enabled = true;

                UsernameAcctxt.Enabled = false;
            }
            else
            {
                MssvAccTxt.Enabled = false;

                UsernameAcctxt.Enabled = true;
            }
        }
    }
}
