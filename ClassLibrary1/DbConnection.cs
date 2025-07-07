using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class DbConnection
    {
        private string connectionString = "data source=Legion-PC\\SQLEXPRESS;initial catalog=CATALOGO_WEB_DB;trusted_connection=true";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }
        

        public DbConnection() {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            command = new SqlCommand();
        }

        public void SetProcedure(string procedure)
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = procedure;
        }

        public void SetParameter(string parameter, object value)
        {
            command.Parameters.AddWithValue(parameter, value);
        }

        public void ReadQuery()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ExecuteScalar()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                return int.Parse(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
