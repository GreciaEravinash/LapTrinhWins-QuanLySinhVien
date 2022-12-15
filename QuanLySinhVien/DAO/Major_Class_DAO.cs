using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public class Major_Class_DAO
    {
        private static Major_Class_DAO instance;

        public static Major_Class_DAO Instance
        {
            get { if (instance == null) instance = new Major_Class_DAO(); return instance; }
            set { instance = value; }
        }
        private Major_Class_DAO() { }
        public DataTable loadMajorList()
        {
            string query = "select * from Major";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public DataTable loadClassList()
        {
            string query = "select * from Class";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
