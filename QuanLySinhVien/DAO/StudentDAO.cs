using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.DAO
{
    public class StudentDAO
    {
        private static StudentDAO instance;

        public static StudentDAO Instance
        {
            get { if (instance == null) instance = new StudentDAO(); return instance; }
            set { instance = value; }
        }
        private StudentDAO() { }

        public void LoadStudentList(ListView listView)
        {
            string query = "select * from Student";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    if (i == 2)
                    {
                        string tmp = row[i].ToString();
                        if (tmp.Length == 20)
                        {
                            tmp = tmp.Substring(0, 8);
                        }
                        else if (tmp.Length == 21)
                        {
                            tmp = tmp.Substring(0, 9);
                        }
                        else if (tmp.Length == 22)
                        {
                            tmp = tmp.Substring(0, 10);
                        }
                        item.SubItems.Add(tmp);
                    }
                    else
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    //item.SubItems.Add(row[i].ToString());
                }
                listView.Items.Add(item);
            }
        }
        public void deleteStudent(string mssv)
        {
            string query = "delete from Student where mssv = @mssv";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {mssv });

            if (data > 0)
            {
                MessageBox.Show("Xóa thông tin sinh viên thành công");
            }
        }

        public void loadSpecificStudent(ListView listView, int type, string searchValue)
        {
            string query;

            DataTable data = new DataTable();

            if (type == 1)
            {
                query = "select * from Student where mssv like '%' + @mssv + '%'";

                data = DataProvider.Instance.ExecuteQuery(query, new object[] { searchValue });
            }
            else if (type == 2)
            {
                query = "select * from Student where studentname like '%' + @name + '%'";

                data = DataProvider.Instance.ExecuteQuery(query, new object[] { searchValue });
            }
            else
            {
                query = "select * from Student";

                data = DataProvider.Instance.ExecuteQuery(query);
            }

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    if (i == 2)
                    {
                        string tmp = row[i].ToString();
                        if (tmp.Length == 20)
                        {
                            tmp = tmp.Substring(0, 8);
                        }
                        else if (tmp.Length == 21)
                        {
                            tmp = tmp.Substring(0, 9);
                        }
                        else if (tmp.Length == 22)
                        {
                            tmp = tmp.Substring(0, 10);
                        }
                        item.SubItems.Add(tmp);
                    }
                    else
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    //item.SubItems.Add(row[i].ToString());
                }
                listView.Items.Add(item);
            }
        }

        public void changeStudentInfo(string name,string mssv, string birthday, string hometown, string gender, string major, string studentclass, string rank)
        {
            string query = "update Student set studentname = @studentname , birthday = CAST( @birthday as DATE) , hometown = @hometown , gender = @gender , major = @major , class = @class , rank = @rank where mssv = @mssv";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {name, birthday, hometown, gender, major, studentclass, rank, mssv });

            if (data > 0)
            {
                MessageBox.Show("Cập nhật thông tin sinh viên thành công");
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật thông tin sinh viên");
            }
        }

        public bool addNewStudent(string mssv, string name, string birthday, string hometown, string gender, string major, string studentclass, string rank)
        {
            string checkExistedStudent = "select * from Student where mssv = @mssv";

            DataTable tmp = DataProvider.Instance.ExecuteQuery(checkExistedStudent, new object[] { mssv });

            if (tmp.Rows.Count > 0)
            {
                MessageBox.Show("Không thể thêm thông tin sinh viên do đã tồn tại một sinh viên với MSSV là " + mssv);

                return false;
            }
            else
            {
                string query = "insert into Student values ( @mssv , @name , CAST( @birthday as DATE) , @hometown , @gender , @major , @studentclass , @rank )";

                int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv, name, birthday, hometown, gender, major, studentclass, rank });

                if (data > 0)
                {
                    MessageBox.Show("Thêm thông tin sinh viên thành công");

                    return true;
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm thông tin sinh viên");

                    return false;
                }
            }
        }
        public bool thisStudentExist(string mssv)
        {
            string query = "select * from Student where mssv = @mssv";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mssv });

            if (data.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
