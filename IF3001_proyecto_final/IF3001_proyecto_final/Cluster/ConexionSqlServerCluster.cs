using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace IF3001_proyecto_final.Cluster
{
    class ConexionSqlServerCluster
    {
        public ConexionSqlServerCluster()
        {
            this.ConnectToDatabase();
        }

        public object ConnectToDatabase()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(GetConnectionString());
                sqlConnection.Open();
                sqlConnection.Close();
                return sqlConnection;                
            }
            catch (SqlException sqlException)
            {
                return null;
            }
        }

        static private string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "35.193.110.243";
            builder.UserID = "sqlserver";
            builder.Password = "piedra";
            builder.InitialCatalog = "test111";
            return builder.ConnectionString;
        }
    }
}
