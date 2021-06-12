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
        public MySqlConnection mysqlConnection { get; set; }
        public  ConexionMySqlCluster()
        {
            
        }

        public MySqlConnection ConnectToDatabaseWithConsole()
        {
            try
            {
                this.mysqlConnection = new MySqlConnection(GetConnectionString());
                this.mysqlConnection.Open();
                return mysqlConnection;
            }
            catch (MySqlException mysqlException)
            {
                return null;
            }
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

        public void DisconnectFromDatabase()
        {
            this.mysqlConnection.Close();
        }

        static private string GetConnectionString()
        {
            var mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = "34.122.1.75",
                UserID = "DBA_ADMIN2",
                Password = "DBA_ADMIN123",
            };
            return mySqlConnectionStringBuilder.ConnectionString;
        }
    }
}
