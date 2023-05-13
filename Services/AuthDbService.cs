using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фотоуслуги.Services
{
    public class AuthDbService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public bool TryFindUser(string login)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM dbo.[User]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    if (item["User_login"].ToString() == login)
                    {
                        return true;
                    }

                }
                return false;
            }
        }

        public string Login(string login, string password)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                if (TryFindUser(login))
                {
                    sqlConnection.Open();
                    string query = $"SELECT * FROM dbo.[User] WHERE User_login = '{login}'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["User_password"].ToString() == password)
                        {
                            return item["Role_ID"].ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный пароль");
                }
                return "none";
            }
        }

        public int GetIdByLogin(string login)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM dbo.[User]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    if (item["User_login"].ToString() == login)
                    {
                        return Convert.ToInt32(item["User_ID"]);
                    }

                }
                return 0;
            }
        }
    }
}
