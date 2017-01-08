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


        static public void Insert(int _id, string _nev, string _cim, int _ar, string _pizza)
        {
            try
            {
                connection.Open();
                SqlCommand commandInsert = new SqlCommand("INSERT INTO [Kiszallitas] values(@id,@nev,@cim,@ar,@pizza)", connection);
                commandInsert.Parameters.Add("@id", _id);
                commandInsert.Parameters.Add("@nev", _nev);
                commandInsert.Parameters.Add("@cim", _cim);
                commandInsert.Parameters.Add("@ar", _ar);
                commandInsert.Parameters.Add("@pizza", _pizza);
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


        static public void Delete(string _id)
        {
            try
            {
                connection.Open();
                SqlCommand commandDelete = new SqlCommand("DELETE FROM [Kiszallitas] where Id = @id", connection);
                commandDelete.Parameters.Add("@id", _id);
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

    }
}
