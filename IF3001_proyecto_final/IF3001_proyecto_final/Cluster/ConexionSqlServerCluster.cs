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
           // this.SqlConnection = "jaja";
        }

        public SqlConnection SqlConnection { get; set; }

        public object EstablishSqlServerConnection()
        {
            try
            {
                this.SqlConnection = new SqlConnection(GetConnectionString());
                this.SqlConnection.Open();
                this.SqlConnection.Close();
                return this.SqlConnection;
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
            builder.InitialCatalog = "test";
            return builder.ConnectionString;
        }
    }
}
