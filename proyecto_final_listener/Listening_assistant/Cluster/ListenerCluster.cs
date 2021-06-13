using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Listening_assistant.Data;
using Listening_assistant.Domain;

namespace Listening_assistant.Cluster
{
    class ListenerCluster
    {
        private ConexionMySqlCluster conexionMySqlCluster;
        private ConexionMySqlData conexionMySqlData;
        private ConexionSqlServerCluster conexionSqlServerCluster;
        private Thread t;
        public ListenerCluster()
        {
            this.conexionMySqlCluster = new ConexionMySqlCluster();
            this.conexionMySqlData = new ConexionMySqlData();
            this.conexionSqlServerCluster = new ConexionSqlServerCluster();
            this.t = new Thread(this.Run);
            t.Start();
        }

        private void Run()
        {
            while (true)
            {
                if (this.conexionMySqlCluster.EstablishMySqlConnection() != null 
                && this.conexionSqlServerCluster.EstablishSqlServerConnection() != null)
                {
                    List<Auditoria> auditorias = this.conexionMySqlData.VerificarNuevosCambios(this.conexionMySqlCluster.MysqlConnection);
                    if (auditorias != null)
                    {
                        this.conexionMySqlData.ObtenerDatosNuevos(auditorias);
                    }
                }

               Thread.Sleep(10000);
            }
        }
    }
}
