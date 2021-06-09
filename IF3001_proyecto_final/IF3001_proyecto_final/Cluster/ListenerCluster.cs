using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace IF3001_proyecto_final.Cluster
{
    class ListenerCluster
    {
        private ConexionSqlServerCluster conexionSqlServerCluster;
        private ConexionMySqlCluster conexionMySqlCluster;
        public ListenerCluster()
        {
            this.conexionSqlServerCluster = new ConexionSqlServerCluster();
            this.conexionMySqlCluster = new ConexionMySqlCluster();
        }

        public bool IsMainNodeReady()
        {
            SqlConnection sqlConnection = (SqlConnection)this.conexionSqlServerCluster.ConnectToDatabase();
            if (sqlConnection != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object ConnectToDatabaseInstance()
        {
            SqlConnection sqlConnection = (SqlConnection)this.conexionSqlServerCluster.ConnectToDatabase();
            if (sqlConnection != null)
            {
                return sqlConnection;
            }
            else
            {
                return this.conexionMySqlCluster.ConnectToDatabase();
            }
        }
    }
}
