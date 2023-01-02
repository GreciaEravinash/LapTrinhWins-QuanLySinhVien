using QuanLySinhVien.DAO;
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
    public partial class fAddNewStudent : Form
    {
        public fAddNewStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMSSV.Text) || string.IsNullOrWhiteSpace(txbStudentName.Text) || string.IsNullOrWhiteSpace(txbHometown.Text) || (!rdbtnFemale.Checked && !rdbtnMale.Checked && !rdbtnOther.Checked) || string.IsNullOrWhiteSpace(MajorCBX.Text) || string.IsNullOrWhiteSpace(ClassCBX.Text) || string.IsNullOrWhiteSpace(RankCBX.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ các thông tin cần thiết");
            }
            else
            {
                string gender;

                if (rdbtnMale.Checked)
                {
                    gender = "Nam";
                }
                else if (rdbtnFemale.Checked)
                {
                    gender = "Nữ";
                }
                else
                {
                    gender = "Khác";
                }
                if (StudentDAO.Instance.addNewStudent(txbMSSV.Text, txbStudentName.Text, DateTimePickerBirthday.Value.ToString("MM-dd-yyyy"), txbHometown.Text, gender, MajorCBX.Text, ClassCBX.Text, RankCBX.Text) == true)
                {
                    this.Close();
                }
            }
        }

        private void fAddNewStudent_Load(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
