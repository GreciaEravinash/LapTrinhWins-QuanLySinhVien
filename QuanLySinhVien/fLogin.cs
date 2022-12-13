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




namespace QuanLySinhVien
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public static string ID_USER = "";
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
            SqlConnection cnn;
            string connectionStrinng = @"Data Source=LAPTOP-G0K1DP8U\KHANHMINHSQL;Initial Catalog=QLSV_DataBase;Integrated Security=SSPI;";
            cnn = new SqlConnection(connectionStrinng);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Account_SV where Account = '" + UserNameTxt.Text + "'and Password = '" + PassTxt.Text + "'", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                fView f = new fView();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }




    }   
}
