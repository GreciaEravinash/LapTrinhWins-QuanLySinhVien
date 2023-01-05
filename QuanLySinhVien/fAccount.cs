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
    public partial class fAccount : Form
    {
        public fAccount()
        {
            InitializeComponent();
        }

        private string currentPassword;

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            loadCurrentAccountInfo();
        }

        private void loadCurrentAccountInfo()
        {
            txbUsername.Text = fView.formUsername;

            DataTable accountInfo = AccountDAO.Instance.getAccountInfo(txbUsername.Text);

            txbDisplayname.Text = accountInfo.Rows[0][0].ToString();

            currentPassword = accountInfo.Rows[0][1].ToString();

            txbCurrentPassword.Clear();

            txbNewPassword.Clear();

            txbReenterNewPassword.Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbCurrentPassword.Text) || string.IsNullOrWhiteSpace(txbDisplayname.Text) || string.IsNullOrWhiteSpace(txbNewPassword.Text) || string.IsNullOrWhiteSpace(txbReenterNewPassword.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!");
            }
            else
            {
                if (txbCurrentPassword.Text != currentPassword)
                {
                    MessageBox.Show("Không thể thực hiện tác vụ do bạn đã nhập sai mật khẩu! Hãy kiểm tra lại mật khẩu của bạn!");
                }
                else
                {
                    if (txbNewPassword.Text != txbReenterNewPassword.Text)
                    {
                        MessageBox.Show("Mật khẩu mới bạn vừa đặt và mật khẩu bạn vừa nhập không trùng khớp với nhau! Hãy kiểm tra lại mật khẩu mới của bạn!");
                    }
                    else
                    {
                        if (txbNewPassword.Text == currentPassword)
                        {
                            MessageBox.Show("Mật khẩu mới của bạn trùng với mật khẩu hiện tại!");
                        }
                        else
                        {
                            AccountDAO.Instance.updateAccountInfo(txbUsername.Text, txbNewPassword.Text);

                            loadCurrentAccountInfo();
                        }
                    }
                }
            }
        }
    }
}
