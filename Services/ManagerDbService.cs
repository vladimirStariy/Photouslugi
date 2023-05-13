using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Xml.Linq;

namespace Фотоуслуги.Services
{
    public class ManagerDbService
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
        // Типы услуг
        public DataTable GetUslugaTypes()
        {
            string query = $"SELECT UslugaType_Id, UslugaTypeName as N'Наименование' " +
                           $"FROM UslugaType";
            return GetDataTableByQuery(query);
        }
        public DataTable GetUslugaTypeById(int id)
        {
            string query = $"SELECT * " +
                           $"FROM UslugaType " +
                           $"WHERE UslugaType_Id = {id}";
            return GetDataTableByQuery(query);
        }
        public void CreateUslugaType(string name)
        {
            string query = $"INSERT INTO UslugaType VALUES (N'{name}')";
            QueryExec(query);
        }
        public void UpdateUslugaType(int id, string name)
        {
            string query = $"UPDATE UslugaType SET UslugaTypeName = N'{name}' WHERE UslugaType_Id = {id}";
            QueryExec(query);
        }
        public void DeleteUslugaType(int id)
        {
            string query = $"DELETE FROM UslugaType WHERE UslugaType_Id = {id}";
            QueryExec(query);
        }
        // Услуги
        public DataTable GetUslugaList()
        {
            string query = $"SELECT id_uslugi, nazv as 'Наименование', UslugaTypeName as 'Тип услуги', stoim as 'Стоимость'" +
                           $"FROM usluga " +
                           $"INNER JOIN UslugaType ON vid = UslugaType_Id";
            return GetDataTableByQuery(query);
        }
        public DataTable GetUslugaById(int id)
        {
            string query = $"SELECT * " +
                           $"FROM usluga " +
                           $"WHERE id_uslugi = {id}";
            return GetDataTableByQuery(query);
        }
        public void CreateUsluga(string name, int type_id, double price)
        {
            string query = $"INSERT INTO usluga VALUES ({type_id}, N'{name}', {price})";
            QueryExec(query);
        }
        public void UpdateUsluga(int id, string name, int type_id, double price)
        {
            string query = $"UPDATE usluga " +
                           $"SET vid = {type_id}, nazv = N'{name}', stoim = {price} " +
                           $"WHERE id_uslugi = {id}";
            QueryExec(query);
        }
        public void DeleteUsluga(int id)
        {
            string query = $"DELETE FROM usluga Where id_uslugi = {id}";
            QueryExec(query);
        }
        
        // Услуга заказа
        public DataTable GetUslugaZakaza(int id)
        {
            string query = $"SELECT usluga_zakaza_id, nazv as 'Услуга'" +
                           $"FROM usluga_zakaza " +
                           $"INNER JOIN usluga ON usluga.id_uslugi = usluga_zakaza.id_uslugi " +
                           $"WHERE nomer_zakaza = {id} ";
            return GetDataTableByQuery(query);
        }
        public void AddUslugaZakaza(int zakaz_id, int usluga_id, int material_id, int count)
        {
            string query = $"EXEC UslugaZakazaAddProc @zakaz_id = {zakaz_id}, @usluga_id = {usluga_id}, @material_id = {material_id}, @count = {count}";
            QueryExec(query);
        }
        public double GetOrderPrice(int id)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = $"SELECT stoim " +
                               $"FROM zakaz " +
                               $"WHERE nomer_zakaza = {id}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    return Convert.ToDouble(item["stoim"]);
                }
                return 0;
            }
        }
        // Заказ
        public DataTable GetZakazList()
        {
            string query = $"SELECT nomer_zakaza, data_zayavki as 'Дата заказа', data_vipolneniya as 'Дата выполнения', " +
                           $"       stoim as 'Стоимость', sotrudnik.fam as 'Ответственный', klient.fam as 'Клиент' " +
                           $"FROM zakaz " +
                           $"INNER JOIN sotrudnik ON sotrudnik.id_sotrudnika = zakaz.id_sotrudnika " +
                           $"INNER JOIN klient ON klient.id_klienta = zakaz.id_klienta";
            return GetDataTableByQuery(query);
        }
        public DataTable GetZakazKlienta(int id)
        {
            string query = $"";
            return GetDataTableByQuery(query);
        }
        public void AddZakaz(DateTime datavip, int sotr_id, int klient_id)
        {
            string query;
            if (datavip.Day < 10)
            {
                if (datavip.Month < 10)
                    query = $"INSERT INTO zakaz VALUES (GETDATE(), '{datavip.Year}-0{datavip.Month}-0{datavip.Day}', 0, {sotr_id}, {klient_id})";
                else
                    query = $"INSERT INTO zakaz VALUES (GETDATE(), '{datavip.Year}-{datavip.Month}-0{datavip.Day}', 0, {sotr_id}, {klient_id})";
            }
            else
            {
                if (datavip.Month < 10)
                    query = $"INSERT INTO zakaz VALUES (GETDATE(), '{datavip.Year}-0{datavip.Month}-{datavip.Day}', 0, {sotr_id}, {klient_id})";
                else
                    query = $"INSERT INTO zakaz VALUES (GETDATE(), '{datavip.Year}-{datavip.Month}-{datavip.Day}', 0, {sotr_id}, {klient_id})";
            }
            QueryExec(query);
        }
        public void DeleteZakaz(int id)
        {
            string query = $"DELETE FROM zakaza WHERE nomer_zakaza = {id}";
            QueryExec(query);
        }
        public int GetWorkerIdByUserId(int user_id)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = $"SELECT Sotrudnik_ID " +
                           $"FROM dbo.[user] " +
                           $"WHERE User_ID = {user_id}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    return Convert.ToInt32(item["Sotrudnik_ID"]);
                }
                return 0;
            }
        }
        public DataTable GetZakazById(int id)
        {
            string query = $"SELECT * " +
                           $"FROM zakaz " +
                           $"WHERE nomer_zakaza = {id}";
            return GetDataTableByQuery(query);
        }
        public int GetMaxOrderId()
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = $"SELECT MAX(nomer_zakaza) as 'order_id' " +
                               $"FROM zakaz ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                
                foreach (DataRow item in dt.Rows)
                {
                    return Convert.ToInt32(item["order_id"]);
                }
                return 0;
            }
        }
        public DataTable GetMaterials()
        {
            string query = $"SELECT material.id_materiala, naim as N'Наименование', TypeName as N'Вид', Sklad_count as N'Количество' " +
                               $"FROM material " +
                               $"INNER JOIN type_material " +
                               $"ON material.vid = type_material.Type_Id";

            return GetDataTableByQuery(query);
        }
        public void SetZakazPrice(double price, int order_id)
        {
            string query = $"UPDATE zakaz SET stoim = {price} WHERE nomer_zakaza = {order_id}";
            QueryExec(query);
        }

        // Клиенты
        public DataTable GetKlientList()
        {
            string query = $"SELECT id_klienta, fam as 'Фамилия', nam as 'Имя', pot as 'Отчество', adr as 'Адрес', tel as 'Телефон'" +
                           $"FROM klient";
            return GetDataTableByQuery(query);
        }
        public DataTable GetKlientById(int id)
        {
            string query = $"SELECT * " +
                           $"FROM klient " +
                           $"WHERE id_klienta = {id}";
            return GetDataTableByQuery(query);
        }
        public void CreateKlient(string fam, string nam, string pot, string adr, int phone)
        {
            string query = $"INSERT INTO klient VALUES (N'{fam}', N'{nam}', N'{pot}', N'{adr}', {phone})";
            QueryExec(query);
        }
        public void UpdateKlient(int id, string fam, string nam, string pot, string adr, int phone)
        {
            string query = $"UPDATE klient " +
                           $"SET fam = N'{fam}', nam = N'{nam}', pot = N'{pot}', adr = N'{adr}', phone = {phone} " +
                           $"WHERE id_klienta = {id}";
            QueryExec(query);
        }
        public void DeleteKlient(int id)
        {
            string query = $"DELETE FROM klient Where id_klienta = {id}";
            QueryExec(query);
        }
    }
}
