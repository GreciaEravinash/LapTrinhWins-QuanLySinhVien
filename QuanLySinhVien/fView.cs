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
    public partial class fView : Form
    {
        public fView()
        {
            InitializeComponent();
        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        
        private void tàiKhoảnCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            f.ShowDialog();

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHelp f = new fHelp();
            f.ShowDialog();
        }

        private void ToolStripMenuItemHelp_Click(object sender, EventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fView_Load(object sender, EventArgs e)
        {
            if (fLogin.isAdmin == false)
            {
                AddBtn.Visible = false;
                DeleteBtn.Visible = false;
                EditBtn.Visible = false;
            }
            StudentDAO.Instance.LoadStudentList(listviewStudent);
        }
    }
}
