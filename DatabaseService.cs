using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фотоуслуги
{
    public class DatabaseService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; 
        //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\otdel\Downloads\Новая папка\Абибок-20230417T080211Z-001\Абибок\EXE\Фотоуслуги.mdf"";Integrated Security=True;Connect Timeout=30";
        
        

        public void LoadStaff(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM sotrudnik", sqlConnection);
                try
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] z = { sqlReader.GetValue(0), sqlReader.GetValue(1), sqlReader.GetValue(2),
                        sqlReader.GetValue(3), sqlReader.GetValue(4), sqlReader.GetValue(5),
                        sqlReader.GetValue(6), sqlReader.GetValue(7), sqlReader.GetValue(8)};
                        dataGridView1.Rows.Add(z);

                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void AddStaffToList(string[] data)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("INSERT INTO dbo.Sotrudnik(id_sotrudnika, fam, nam, pot, adr, tel, dol, login, password) VALUES ("
                    + $"{data[0]},'{data[1]}','{data[2]}','{data[3]}','{data[4]}', {data[5]},'{data[6]}','{data[7]}','{data[8]}') ;", sqlConnection);
                try
                {
                    command.ExecuteNonQuery();
                    sqlReader = command.ExecuteReader();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void DeleteStaffOfList(int id_sotrudnika)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("DELETE FROM dbo.sotrudnik where id_sotrudnika=" + id_sotrudnika, sqlConnection);

                try
                {
                    command.ExecuteNonQuery();
                    sqlReader = command.ExecuteReader();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void LoadOrder(DataGridView dataGridView2)
        {
            dataGridView2.Rows.Clear();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT nomer_zakaza, data_zayavki, data_vipolneniya, stoim, S.fam, K.fam FROM zakaz Z, sotrudnik S, klient K WHERE Z.id_sotrudnika = S.id_sotrudnika AND K.id_klienta = Z.id_klienta", sqlConnection);
                try
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] zachem = { sqlReader.GetValue(0), sqlReader.GetValue(1), sqlReader.GetValue(2),
                        sqlReader.GetValue(3), sqlReader.GetValue(4), sqlReader.GetValue(5)};
                        dataGridView2.Rows.Add(zachem);

                    }
                }

                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void loadMaterial(DataGridView dataGridView4)
        {
            dataGridView4.Rows.Clear();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT* from material", sqlConnection);
                try
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] zachem = { sqlReader.GetValue(0), sqlReader.GetValue(1), sqlReader.GetValue(2) };
                        dataGridView4.Rows.Add(zachem);

                    }
                }

                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void loadService(DataGridView dataGridView5)
        {
            dataGridView5.Rows.Clear();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT* from usluga", sqlConnection);
                try
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] zachem = { sqlReader.GetValue(0), sqlReader.GetValue(1), sqlReader.GetValue(2), sqlReader.GetValue(3) };
                        dataGridView5.Rows.Add(zachem);

                    }
                }

                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void AddServiceToList(string[] data)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("INSERT INTO dbo.usluga (id_uslugi, vid, nazv, stoim) VALUES ("
                   + $"{data[0]},'{data[1]}','{data[2]}',{data[3]}) ;", sqlConnection);
                try
                {
                    command.ExecuteNonQuery();
                    sqlReader = command.ExecuteReader();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void DeleteServiceOfList(int id_uslugi)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("DELETE FROM dbo.usluga where id_uslugi=" + id_uslugi, sqlConnection);

                try
                {
                    command.ExecuteNonQuery();
                    sqlReader = command.ExecuteReader();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void LoadMaterealOfWarehouse(DataGridView dataGridView7)
        {
            dataGridView7.Rows.Clear();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM material_na_sklade", sqlConnection);
                try
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] z = { sqlReader.GetValue(0), sqlReader.GetValue(1), sqlReader.GetValue(2),
                        sqlReader.GetValue(3)};
                        dataGridView7.Rows.Add(z);
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void Loadcustomer(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM klient", sqlConnection);
                try
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] zachem = { sqlReader.GetValue(0), sqlReader.GetValue(1), sqlReader.GetValue(2),
                        sqlReader.GetValue(3), sqlReader.GetValue(4), sqlReader.GetValue(5),};
                        dataGridView1.Rows.Add(zachem);

                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void AddCustomerToList(string[] data)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("INSERT INTO dbo.klient(id_klienta, fam, nam, pot, adr, tel) VALUES ("
                    + $" {data[0]},'{data[1]}','{data[2]}','{data[3]}','{data[4]}', {data[5]}) ;", sqlConnection);
                try
                {
                    command.ExecuteNonQuery();
                    sqlReader = command.ExecuteReader();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void DeleteCustomerOfList(int id_klienta)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("DELETE FROM dbo.klient where id_klienta=" + id_klienta, sqlConnection);

                try
                {
                    command.ExecuteNonQuery();
                    sqlReader = command.ExecuteReader();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void LoadServiseOfOrder(DataGridView dataGridView3,int nomer_zakaza)
        {
            dataGridView3.Rows.Clear();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT DISTINCT U.nazv, U.stoim, U.vid FROM zakaz Z, usluga U, usluga_zakaza UZ WHERE UZ.id_uslugi = U.id_uslugi AND UZ.nomer_zakaza ="+nomer_zakaza, sqlConnection);
                try
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] zachem = { sqlReader.GetValue(0), sqlReader.GetValue(1), sqlReader.GetValue(2)};
                        dataGridView3.Rows.Add(zachem);

                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void LoadMaterealOfService(DataGridView dataGridView6, int id_uslugi)
        {
            dataGridView6.Rows.Clear();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT DISTINCT m.naim, m.vid FROM material m, material_uslugi mu, usluga u WHERE mu.id_materiala=m.id_materiala AND mu.id_uslugi =  " + id_uslugi, sqlConnection);
                try
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] zachem = { sqlReader.GetValue(0), sqlReader.GetValue(1)};
                        dataGridView6.Rows.Add(zachem);

                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void SearchOrder(DateTime before, DateTime after,DataGridView dataGridView4)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand($"SELECT nomer_zakaza, data_zayavki, data_vipolneniya, stoim, S.fam, K.fam FROM zakaz Z, sotrudnik S, klient K WHERE Z.id_sotrudnika = S.id_sotrudnika AND K.id_klienta = Z.id_klienta and data_zayavki between '{before}' and '{after}'  ",  sqlConnection);
                try
                {
                    sqlReader = command.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] z = { sqlReader.GetValue(0), sqlReader.GetValue(1), sqlReader.GetValue(2),
                        sqlReader.GetValue(3), sqlReader.GetValue(4), sqlReader.GetValue(5)};
                        dataGridView4.Rows.Add(z);
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void AddOrdertoList(string[] data)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("INSERT INTO dbo.zakaz(nomer_zakaza,data_zayavki, data_vipolneniya, stoim, fam, fam) VALUES ("
                    + $"{data[0]},{data[1]},{data[2]},{data[3]},{data[4]}, {data[5]}) ;", sqlConnection);
                try
                {
                    command.ExecuteNonQuery();
                    sqlReader = command.ExecuteReader();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
        public void AddMaterial_na_sklad(string [] data)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("INSERT INTO dbo.material_na_sklade(id_materiala_na_sklade, data_postupleniya, kolichestvo, id_materiala) VALUES ("
                    + $"{data[0]},{data[1]},{data[2]},{data[3]}) ;", sqlConnection);
                try
                {
                    command.ExecuteNonQuery();
                    sqlReader = command.ExecuteReader();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }
    }
}
