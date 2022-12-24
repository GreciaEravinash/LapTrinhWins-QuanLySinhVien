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

        public static bool isAdmin = false;

        public static string loginName = "";

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                isAdmin = false;
                loginName = username;
                fView f = new fView();
                this.Hide();
                f.ShowDialog();
                this.Show();
                PassTxt.Clear();
            }
            else if (AccountDAO.Instance.isValidAccount(username, password, '1'))
            {
                isAdmin = true;
                loginName = username;
                fView f = new fView();
                this.Hide();
                f.ShowDialog();
                this.Show();
                PassTxt.Clear();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Hãy kiểm tra lại tên đăng nhập và mật khẩu");
                PassTxt.Clear();
            }
        }
    }   
}
