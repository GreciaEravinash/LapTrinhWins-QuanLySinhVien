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
            //string query = "select mssv , studentname , CAST(birthday AS DATE) , hometown , gender , major , class , rank from Student";

            string query = "SP_LoadStudentList";

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
            string query = string.Format("delete from Student where mssv = {0}", mssv);

            int data = DataProvider.Instance.ExecuteNonQuery(query);

            if (data > 0)
            {
                MessageBox.Show("Xóa thông tin sinh viên thành công");
            }
        }
    }
}
