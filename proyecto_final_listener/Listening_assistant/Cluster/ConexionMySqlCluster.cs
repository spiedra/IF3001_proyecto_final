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

        public object ConnectToDatabase()
        {
            try
            {
                this.mysqlConnection = new MySqlConnection(GetConnectionString());
                this.mysqlConnection.Open();
                this.mysqlConnection.Close();
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

        public void ConnectFromDatabase()
        {
            this.mysqlConnection.Open();
        }

        static private string GetConnectionString()
        {
            var mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = "104.198.146.87",
                UserID = "root",
                Password = "root",
            };
            return mySqlConnectionStringBuilder.ConnectionString;
        }
    }
}
