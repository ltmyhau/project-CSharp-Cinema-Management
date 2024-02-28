using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BetaCinema.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get => instance == null ? instance = new AccountDAO() : instance;
            private set => instance = value;
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            //string query = "SELECT * FROM TaiKhoan WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "'";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query);
            //return result.Rows.Count > 0;

            string query = "SELECT * FROM TaiKhoan WHERE UserName = @userName AND PassWord = @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;

            //string query = "EXEC sp_Login @UserName , @PassWord";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            //return result.Rows.Count > 0;
        }
    }
}
