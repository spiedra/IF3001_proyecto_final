using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Threading;

namespace IF3001_proyecto_final.Cluster
{
    class ListenerCluster
    {
        private static ListenerCluster _instance = null;
        private ConexionSqlServerCluster conexionSqlServerCluster;
        private ConexionMySqlCluster conexionMySqlCluster;

        private ListenerCluster()
        {
            this.conexionSqlServerCluster = new ConexionSqlServerCluster();
            this.conexionMySqlCluster = new ConexionMySqlCluster();
            this.ContadorConnection = 0;
        }

        public static ListenerCluster GetListenerCluster()
        {
            if (_instance == null)
            {
                _instance = new ListenerCluster();
            }
            return _instance;
        }

        public int NodeIsRunnig { get; set; }
        public int ContadorConnection { get; set; }

        public bool IsMainNodeReady()
        {
            //if (this.ContadorConnection == 0)
            //{
            //    return this.TryConnectToSqlServer();
            //}
            //else
            //{
            //    if (this.ContadorConnection < 4)
            //    {
            //        this.ContadorConnection++;
            //        return false;
            //    }
            //    else
            //    {
            //        this.ContadorConnection = 0;
            //        return this.TryConnectToSqlServer();
            //    }
            //}
            this.conexionSqlServerCluster.EstablishSqlServerConnection();
            return true;
        }

        public bool TryConnectToSqlServer()
        {
            if (this.conexionSqlServerCluster.EstablishSqlServerConnection() != null)
            {
                return true;
            }
            else if (this.conexionMySqlCluster.EstablishMySqlConnection() != null)
            {
                this.ContadorConnection++;
                return false;
            }
            return false;
        }

        public SqlConnection ConnectToSqlServerInstance()
        {
            return this.conexionSqlServerCluster.SqlConnection;
        }

        public MySqlConnection ConnectToMySqlInstance()
        {
            return this.conexionMySqlCluster.MysqlConnection;
        }
    }
}
