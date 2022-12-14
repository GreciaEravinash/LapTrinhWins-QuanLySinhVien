using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
