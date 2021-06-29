using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Listening_assistant.Cluster
{
    class ConexionSqlServerCluster
    {
        public ConexionSqlServerCluster()
        {
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
            builder.DataSource = "proyectodbarjk.database.windows.net";
            builder.UserID = "proyectodbarjkinit";
            builder.Password = "contrasenaProyecto1";
            builder.InitialCatalog = "db_proyecto_admin_est";
            return builder.ConnectionString;
            //return "Data Source=localhost; database=PROYECTO_FINAL_DBA; User Id=juan; Password=piedra";
        }
    }
}
