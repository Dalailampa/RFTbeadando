using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;    // ez a 3 kell
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace Beadando
{
    class SQLFunctions
    {
        static private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Adatbazis.mdf;Integrated Security=True");


        public void Refresh(DataGridView _datagridview)
        {
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Kiszallitas]", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                _datagridview.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectId(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                //DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM [Kiszallitas] WHERE Id=@id ";
                command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(dt);
                command.ExecuteNonQuery();
                return dt;

            }
            catch (SqlException exception) { MessageBox.Show(exception.ToString()); }
            finally
            {
                connection.Close();
            }
            return dt;

        }

        public void Insert(string _nev, string _cim, int _ar, string _pizza)
        {
            try
            {
                connection.Open();
                SqlCommand commandInsert = new SqlCommand("INSERT INTO [Kiszallitas] values(@nev,@cim,@pizza,@ar)", connection);
                
                commandInsert.Parameters.Add(new SqlParameter("@nev", SqlDbType.NVarChar)).Value = _nev;
                commandInsert.Parameters.Add(new SqlParameter("@cim", SqlDbType.NVarChar)).Value =_cim;
                commandInsert.Parameters.Add(new SqlParameter("@ar", SqlDbType.Int)).Value = _ar;
                commandInsert.Parameters.Add(new SqlParameter("@pizza", SqlDbType.NVarChar)).Value = _pizza;
                
                commandInsert.ExecuteNonQuery();

            }           
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void Delete(int _id)
        {
            try
            {
                connection.Open();
                SqlCommand commandDelete = new SqlCommand("DELETE FROM [Kiszallitas] where Id = @id", connection);
                // command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = _id;
                commandDelete.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = _id;
                commandDelete.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
       

        static public void Update(string _regiNev, string _UjNev)
        {
            try
            {
                connection.Open();
                SqlCommand commandUpdate = new SqlCommand("UPDATE [Kiszallitas] SET Nev = @ujnev  WHERE Nev = @reginev", connection);
                commandUpdate.Parameters.Add("@ujnev", _UjNev);
                commandUpdate.Parameters.Add("@reginev", _regiNev);
                commandUpdate.ExecuteNonQuery();







            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void Modosit(int id, string _nev, string _cim)
        {
            try
            {
                connection.Open();
                SqlCommand commandInsert = new SqlCommand("UPDATE [Kiszallitas] SET Nev=@nev,Cim=@cim WHERE Id=@id", connection);
                commandInsert.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                commandInsert.Parameters.Add(new SqlParameter("@nev", SqlDbType.NVarChar)).Value = _nev;
                commandInsert.Parameters.Add(new SqlParameter("@cim", SqlDbType.NVarChar)).Value = _cim;       
                commandInsert.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally { connection.Close(); }
        }

    }
}
