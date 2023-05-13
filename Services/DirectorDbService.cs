using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фотоуслуги.Services
{
    public class DirectorDbService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public DataTable GetDataTableByQuery(string query)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
        }

        public void QueryExec(string query)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        
        public void CreateSotrudnik(string fam, string nam, string pot, string adr, int tel, string dol)
        {
            string query = $"INSERT INTO sotrudnik VALUES (N'{fam}', N'{nam}', N'{pot}', N'{adr}', {tel}, N'{dol}', NULL)";
            QueryExec(query);
        }

        public void UpdateSotrudnik(int id, string fam, string nam, string pot, string adr, int tel, string dol)
        {
            string query = $"UPDATE sotrudnik " +
                           $"SET " +
                           $"fam = N'{fam}', " +
                           $"nam = N'{nam}', " +
                           $"pot = N'{pot}', " +
                           $"adr = N'{adr}', " +
                           $"tel = {tel}, " +
                           $"dol = N'{dol}') " +
                           $"WHERE id_sotrudnika = {id}";
            QueryExec(query);
        }

        public void CreateUser(int sotr_id, string login, string password, string role)
        {
            string query = $"INSERT INTO dbo.[user] VALUES (N'{login}', N'{password}', N'{role}', {sotr_id})";
            QueryExec(query);
        }
    }
}
