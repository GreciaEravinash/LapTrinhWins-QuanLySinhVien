﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace QuanLySinhVien.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool isValidAccount(string username, string password, char x)
        {
            string query = "SP_Login @username , @password , @type";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password, x });

            return result.Rows.Count > 0;
        }
        public bool isAdminAccount(string username, string password)
        {
            string query = "SP_Login_Admin @username , @password , @type";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password, 1 });

            return result.Rows.Count > 0;
        }

        public void loadAccountList(ListView accountList)
        {
            string query = "select Account.mssv , studentname , class , username , displayname from Student inner join Account on Student.mssv = Account.mssv";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                accountList.Items.Add(item);
            }
        }
        public void deleteAccount(string username)
        {
            string query = "delete from Account where username = @username";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {username });

            if (data > 0)
            {
                MessageBox.Show("Xóa thông tin tài khoản thành công");
            }
        }

        public DataTable getAccountInfo(string username)
        {
            string query = "select displayname , password from Account where username = @username";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            return data;
        }
        public void updateAccountInfo(string username, string displayname, string password)
        {
            string query = "SP_UpdateAccount @username , @displayname , @password";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, displayname, password });

            if (data > 0)
            {
                MessageBox.Show("Cập nhật thông tin tài khoản thành công!");
            }
        }
    }
}
