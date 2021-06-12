using IF3001_proyecto_final.Cluster;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listening_assistant.Cluster
{
    class EscuchaSQLSERVER
    {
        //GENERAL
        private Thread hilo;
        private bool escuchando;
        private ConexionMySqlCluster conexionMySqlCluster;
        private ConexionSqlServerCluster conexionSqlServerCluster;

        //SQL SERVER
        private SqlCommand sqlCommand;
        private SqlDataReader sqlDataReader;

        //MYSQL SERVER



        public EscuchaSQLSERVER()
        {
            this.hilo = null;
            this.escuchando = true;
            this.conexionSqlServerCluster = new ConexionSqlServerCluster();
            this.conexionMySqlCluster = new ConexionMySqlCluster();
        }

        public void Start()
        {
            this.hilo = new Thread(Run);
            this.hilo.Start();
        }

        private void Run()
        {
            while (this.escuchando)
            {
                if (VerificarDisponibilidad()) //valida disponiblidad en ambas conexiones para poder proceder con la replica.
                {






                    
                }


                Thread.Sleep(300);

            }//while
        }

        private bool VerificarDisponibilidad()
        {

            if (this.conexionMySqlCluster.ConnectToDatabaseWithConsole() != null && this.conexionSqlServerCluster.ConnectToDatabaseWithConsole() != null)
            {
                return true;
            }

            return false;

        }

        private void EjecutarConsultarAuditorias()
        {
            string commandText = "AUDITORIA.sp_MOSTRAR_AUDITORIAS";
            this.InitSqlComponents(commandText);
            this.ExcecuteReader();


        }

        private void RevisarAuditorias()
        {

            while (this.sqlDataReader.Read())
            {
                int id = this.sqlDataReader.GetInt32(0);
                String tabla = this.sqlDataReader.GetString(1);
                bool atendida = Convert.ToBoolean(this.sqlDataReader.GetBoolean(2));

                if (!atendida)
                {

                }
            }
            this.conexionSqlServerCluster.DisconnectFromDatabase();

        }


        //SQL SERVER 




        private void CreateParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter sqlParameter = new SqlParameter(parameterName, dbType);
            sqlParameter.Value = value;
            this.sqlCommand.Parameters.Add(sqlParameter);
        }

        private void ExcecuteReader()
        {
            this.ExecuteConnectionCommands();
            this.sqlDataReader = this.sqlCommand.ExecuteReader();
        }
        private void InitSqlComponents(string commandText)
        {
            this.sqlCommand = new SqlCommand(commandText, this.conexionSqlServerCluster.sqlConnection);
        }

        private void ExecuteConnectionCommands()
        {
            this.sqlCommand.CommandType = CommandType.StoredProcedure;
        }


        //MYSQL SERVER




    }
}
