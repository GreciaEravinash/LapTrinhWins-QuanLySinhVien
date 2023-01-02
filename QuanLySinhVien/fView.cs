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
                Nametxt.Text = listviewStudent.FocusedItem.SubItems[1].Text.ToString();
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

        private void clearInput()
        {
            Mssvtxt.Clear();
            Nametxt.Clear();
            Birthdaytxt.Clear();
            Hometowntxt.Clear();
            Gendertxt.Clear();
            MajorCBX.SelectedIndex = -1;
            ClassCBX.SelectedIndex = -1;
            RankCBX.SelectedIndex = -1;
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi về thông tin của sinh viên này không", "Cảnh báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                StudentDAO.Instance.changeStudentInfo(Nametxt.Text,Mssvtxt.Text, Birthdaytxt.Text, Hometowntxt.Text, Gendertxt.Text, MajorCBX.Text, ClassCBX.Text, RankCBX.Text);

                refreshStudentList();

                clearInput();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void listviewStudent_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = listviewStudent.ListViewItemSorter as ItemComparer;

            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                listviewStudent.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            listviewStudent.Sort();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            fAddNewStudent form = new fAddNewStudent();
            this.Hide();
            form.ShowDialog();
            this.Show();

            refreshStudentList();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshStudentList();

            clearInput();
        }
    }
}
