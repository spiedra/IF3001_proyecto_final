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

        public SqlConnection sqlConnection { get; set; }
        public ConexionSqlServerCluster()
        {

        }

        public object ConnectToDatabase()
        {
            try
            {
                this.sqlConnection = new SqlConnection(GetConnectionString());
                this.sqlConnection.Open();
                this.sqlConnection.Close();
                return sqlConnection;
            }
            catch (SqlException sqlException)
            {
                return null;
            }
        }

        public void ConnectFromDatabase()
        {
            this.sqlConnection.Open();
        }

        public void DisconnectFromDatabase()
        {
            this.sqlConnection.Close();
        }

        static private string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "proyectodbarjk.database.windows.net";
            builder.UserID = "proyectodbarjkinit";
            builder.Password = "contrasenaProyecto1";
            builder.InitialCatalog = "db_proyecto_admin_est";
            return builder.ConnectionString;
        }
    }
}
