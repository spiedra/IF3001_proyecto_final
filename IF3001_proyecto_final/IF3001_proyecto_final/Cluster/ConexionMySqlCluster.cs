using MySql.Data.MySqlClient;

namespace IF3001_proyecto_final.Cluster
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
                Server = "104.198.146.87",
                UserID = "root",
                Password = "root",
            };
            return mySqlConnectionStringBuilder.ConnectionString;
        }

    }
}
