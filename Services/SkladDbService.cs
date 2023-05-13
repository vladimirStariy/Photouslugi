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
    public class SkladDbService
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

        // материалы
        public DataTable GetMaterials()
        {
            string query = $"SELECT material.id_materiala, naim as N'Наименование', TypeName as N'Вид', Sklad_count as N'Количество' " +
                               $"FROM material " +
                               $"INNER JOIN type_material " +
                               $"ON material.vid = type_material.Type_Id";

            return GetDataTableByQuery(query);
        }
        public void CreateMaterial(string name, int count, double price, int type_id)
        {
            string query = $"EXEC MaterialAddProc @naim = N'{name}', @type_id = {type_id}, @count = {count}, @price = {price}";
            QueryExec(query);
        }
        public void IncreaseMaterialCount(int count, double price, int material_id)
        {
            string query = $"INSERT INTO material_na_sklade VALUES (GetDate(), {count}, {material_id}, 1, {price})";
            QueryExec(query);
        }
        public void DeleteMaterial(int id)
        {
            string query = $"DELETE FROM material WHERE id_materiala = {id}";
            QueryExec(query);
        }
        // движения
        public DataTable GetMaterialMovements()
        {
            string query = $"SELECT id_materiala_na_sklade, " +
                           $"move_date as N'Дата движения', " +
                           $"kolichestvo as N'Количество', " +
                           $"material.naim as N'Материал', " +
                           $"CASE " +
                           $"WHEN move_type = 1 " +
                           $"THEN N'Приход' " +
                           $"WHEN move_type = 0 " +
                           $"THEN N'Расход' " +
                           $"END AS N'Тип движения', " +
                           $"price as 'Цена' " +
                           $"FROM material_na_sklade " +
                           $"INNER JOIN material " +
                           $"ON material_na_sklade.id_materiala = material.id_materiala";

            return GetDataTableByQuery(query);
        }
        // типы
        public DataTable GetMaterialTypes()
        {
            string query = $"SELECT Type_Id, TypeName as 'Наименование' " +
                           $"FROM type_material";

            return GetDataTableByQuery(query);
        }
        public void CreateType(string name)
        {
            string query = $"INSERT INTO type_material VALUES (N'{name}')";
            QueryExec(query);
        }
        public void UpdateType(int id, string name)
        {
            string query = $"UPDATE type_material SET TypeName = N'{name}' WHERE Type_Id = {id}";
            QueryExec(query);
        }
        public void DeleteType(int id)
        {
            string query = $"DELETE FROM type_material WHERE Type_Id = {id}";
            QueryExec(query);
        }

    }
}
