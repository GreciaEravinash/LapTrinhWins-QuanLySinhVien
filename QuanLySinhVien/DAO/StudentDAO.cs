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
                        string tmp = row[i].ToString().Substring(0, 8);
                        item.SubItems.Add(tmp);
                    }
                    else
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                }
                listView.Items.Add(item);
            }
        }
        
    }
}
