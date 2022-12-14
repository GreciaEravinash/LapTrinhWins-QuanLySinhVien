using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySinhVien.DAO;

namespace QuanLySinhVien
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public static string ID_USER = "";
        int loginAttemptFailedCount = 0;
        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void logicBtn_Click(object sender, EventArgs e)
        {
            string username = UserNameTxt.Text;
            string password = PassTxt.Text;
            if (AccountDAO.Instance.isValidAccount(username, password, '0'))
            {
                fView f = new fView();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (AccountDAO.Instance.isValidAccount(username, password, '1'))
            {
                fAdmin f = new fAdmin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Hãy kiểm tra lại tên đăng nhập và mật khẩu");
                loginAttemptFailedCount++;
                if (loginAttemptFailedCount >= 3)
                {
                    Application.Exit();
                }
            }
        }
    }   
}
