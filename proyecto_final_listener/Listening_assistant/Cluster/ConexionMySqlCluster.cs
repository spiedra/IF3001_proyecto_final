using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Listening_assistant.Cluster
{
    class ConexionMySqlCluster
    {
        public ConexionMySqlCluster()
        {
        }

        public MySqlConnection MysqlConnection { get; set; }

        public object EstablishMySqlConnection()
        {
            try
            {
                this.MysqlConnection = new MySqlConnection(GetConnectionString());
                this.MysqlConnection.Open();
                this.MysqlConnection.Close();
                return this.MysqlConnection;
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
                UserID = "DBA_ADMIN2",
                Password = "DBA_ADMIN123",
                //Database = "ESTUDIANTE",
            };
            return mySqlConnectionStringBuilder.ConnectionString;
        }
    }
}
