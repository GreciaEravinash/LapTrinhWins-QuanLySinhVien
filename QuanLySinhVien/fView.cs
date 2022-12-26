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
        public int selectedRowIndex = 0;

        public static string loginName;
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

        private void ToolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            fHelp f = new fHelp();
            f.ShowDialog();
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
                danhSáchTàiKhoảnToolStripMenuItem.Enabled = false;
                
            }
            loginName = fLogin.loginName;

            StudentDAO.Instance.LoadStudentList(listviewStudent);
            lblUsername.Text += " " + fLogin.loginName;

            DataTable majorList = Major_Class_DAO.Instance.loadMajorList();

            foreach (DataRow item in majorList.Rows)
            {
                MajorCBX.Items.Add(item[0].ToString());
            }
            majorList.Clear();

            DataTable classList = Major_Class_DAO.Instance.loadClassList();

            foreach (DataRow item in classList.Rows)
            {
                ClassCBX.Items.Add(item[0].ToString());
            }
            classList.Clear();

            DataTable rankList = Major_Class_DAO.Instance.loadRankList();

            foreach (DataRow item in rankList.Rows)
            {
                RankCBX.Items.Add(item[0].ToString());
            }
        }

        private void listviewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewStudent.SelectedItems.Count > 0)
            {
                Mssvtxt.Text = listviewStudent.FocusedItem.SubItems[0].Text.ToString();
                HoTentxt.Text = listviewStudent.FocusedItem.SubItems[1].Text.ToString();
                Birthdaytxt.Text = listviewStudent.FocusedItem.SubItems[2].Text.ToString();
                Hometowntxt.Text = listviewStudent.FocusedItem.SubItems[3].Text.ToString();
                Gendertxt.Text = listviewStudent.FocusedItem.SubItems[4].Text.ToString();

                MajorCBX.SelectedIndex = MajorCBX.FindStringExact(listviewStudent.FocusedItem.SubItems[5].Text.ToString());
                ClassCBX.SelectedIndex = ClassCBX.FindStringExact(listviewStudent.FocusedItem.SubItems[6].Text.ToString());
                RankCBX.SelectedIndex = RankCBX.FindStringExact(listviewStudent.FocusedItem.SubItems[7].Text.ToString());

            }
            
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listviewStudent.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên bạn muốn xóa");
            }
            else
            {
                DialogResult deleteUserWarning = MessageBox.Show("Bạn có muốn xóa người dùng này không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (deleteUserWarning == DialogResult.Yes)
                {
                    if (!string.IsNullOrWhiteSpace(Mssvtxt.Text))
                    {
                        StudentDAO.Instance.deleteStudent(Mssvtxt.Text);

                        refreshStudentList();
                    }
                }
            }
        }
        private void refreshStudentList()
        {
            listviewStudent.Items.Clear();
            StudentDAO.Instance.LoadStudentList(listviewStudent);
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void SreachBtn_Click(object sender, EventArgs e)
        {
            fSearch searchForm = new fSearch();

            searchForm.ShowDialog();
            if (searchForm.buttonClicked)
            {
                listviewStudent.Items.Clear();

                StudentDAO.Instance.loadSpecificStudent(listviewStudent, searchForm.searchType, searchForm.searchValue);

                searchForm.Close();
            }
        }
    }
}
