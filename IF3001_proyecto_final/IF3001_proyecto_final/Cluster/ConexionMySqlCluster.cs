using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace IF3001_proyecto_final.Cluster
{
    class ConexionMySqlCluster
    {
        public ConexionMySqlCluster()
        {
            this.ConnectToDatabase();
        }

        public object ConnectToDatabase()
        {
            try
            {
                MySqlConnection mysqlConnection = new MySqlConnection(GetConnectionString());
                mysqlConnection.Open();
                mysqlConnection.Close();
                return mysqlConnection;
            }
            catch (MySqlException mysqlException)
            {
                return null;
            }
        }

        static private string GetConnectionString()
        {
            var mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = "34.122.1.75",
                UserID = "root",
                Password = "superuser",
                //Database = "ESTUDIANTE",
            };
            return mySqlConnectionStringBuilder.ConnectionString;
        }
    }
}
