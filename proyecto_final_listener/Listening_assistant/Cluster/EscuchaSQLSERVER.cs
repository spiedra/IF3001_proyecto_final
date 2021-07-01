using IF3001_proyecto_final.Cluster;
using MySql.Data.MySqlClient;
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
        private StringBuilder builderInserts;

        //MYSQL
        private MySqlCommand mysqlCommand;
        private MySqlDataReader mysqlDataReader;

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
                    Console.WriteLine("Se establece conexion");
                    EjecutarConsultarAuditorias();
                    LeerRevisarAuditorias();
                }
                Thread.Sleep(300);

            }//while
        }

        private bool VerificarDisponibilidad()
        {
            Console.WriteLine("verificando");
            if (this.conexionMySqlCluster.ConnectToDatabase() != null && this.conexionSqlServerCluster.ConnectToDatabase() != null)
            {
                return true;
            }

            return false;

        }

        private void LeerRevisarAuditorias()
        {

            while (this.sqlDataReader.Read())
            {
                int id = this.sqlDataReader.GetInt32(0);
                String tabla = this.sqlDataReader.GetString(1);
                bool atendida = Convert.ToBoolean(this.sqlDataReader.GetBoolean(2));

                if (!atendida)
                {

                    //apagar los triggers
                    this.manejar_triggers(2);

                    this.EjecutarManejarIncremento(0);  //apago auto_incremento
                    this.EjecutarBorrarDatosTabla(tabla);
                    //Console.WriteLine("manejado");
                   this.EjecutarSolicitarInserts(tabla);
                   this.EjecutaInsertarDatos();
                   this.EjecutarManejarIncremento(1);  //encender auto_increment
                    this.EjecutarMarcarAtendida(id);

                    this.manejar_triggers(0);
                    //encender triggers
                }
            }
            this.conexionSqlServerCluster.DisconnectFromDatabase();
        }


        //**********************SQL SERVER*******************

        private void EjecutarSolicitarInserts(string nombre_tabla)
        {
            string commandText = "ADMINISTRACION.sp_TABLE_INSERTS";
            ConexionSqlServerCluster csql = new ConexionSqlServerCluster();
            csql.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(commandText, csql.sqlConnection);
            csql.ConnectFromDatabase();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@param_NOMBRE_TABLA", SqlDbType.VarChar);
            sqlParameter.Value = nombre_tabla;
            sqlCommand.Parameters.Add(sqlParameter);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.builderInserts = new StringBuilder();

            while (sqlDataReader.Read())
            {
                this.builderInserts.Append(sqlDataReader.GetString(0));
            }
            csql.DisconnectFromDatabase();

            Console.WriteLine(this.builderInserts.ToString());
        }

        private void EjecutarConsultarAuditorias()
        {
            string commandText = "AUDITORIA.sp_MOSTRAR_AUDITORIAS";
            this.InitSqlComponents(commandText);
            this.ExcecuteReader();
        }

        private void EjecutarMarcarAtendida(int id_tabla)
        {
            string commandText = "AUDITORIA.sp_MARCAR_ATENDIDO";
            ConexionSqlServerCluster csql = new ConexionSqlServerCluster();
            csql.ConnectToDatabase();
            SqlCommand sqlCommand = new SqlCommand(commandText, csql.sqlConnection);
            csql.ConnectFromDatabase();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter("@param_Id", SqlDbType.Int);
            sqlParameter.Value = id_tabla;
            sqlCommand.Parameters.Add(sqlParameter);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            csql.DisconnectFromDatabase();
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
            this.conexionSqlServerCluster.ConnectFromDatabase();
            this.sqlCommand.CommandType = CommandType.StoredProcedure;
        }

        //**********************************MYSQL************************************

        private void manejar_triggers(int n)
        {
            string commandText = "AUDITORIA.sp_MANEJAR_TRIGGER", param_bandera="param_FLAG";
            this.conexionMySqlCluster.ConnectFromDatabase();
            this.InitNpgsqlComponents(commandText);
            this.mysqlCommand.Parameters.Add(new MySqlParameter(param_bandera, MySqlDbType.Int32)).Value = n;
            this.mysqlCommand.CommandType = CommandType.StoredProcedure;
            this.mysqlCommand.ExecuteNonQuery();
            this.conexionMySqlCluster.DisconnectFromDatabase();
        }

        private void EjecutaInsertarDatos()
        {

            
            string commandText = this.builderInserts.ToString();   //posible error parentesis
            if (commandText.Length != 0) { 
            this.conexionMySqlCluster.ConnectFromDatabase();
            this.InitNpgsqlComponents(commandText);
            this.mysqlCommand.CommandType = CommandType.Text;
            this.mysqlCommand.ExecuteNonQuery();
            this.conexionMySqlCluster.DisconnectFromDatabase();
            }
        }

        private void EjecutarBorrarDatosTabla(string nombre_tabla)
        {
            string paramNombre = "param_TABLA"
                     
                             , commandText = "AUDITORIA.sp_BORRAR_DATOS_TABLA";
            this.conexionMySqlCluster.ConnectFromDatabase();
            this.InitNpgsqlComponents(commandText);
            this.mysqlCommand.Parameters.Add(new MySqlParameter(paramNombre, MySqlDbType.VarChar)).Value = nombre_tabla;
            this.mysqlCommand.CommandType = CommandType.StoredProcedure;
            this.mysqlCommand.ExecuteNonQuery();
            this.conexionMySqlCluster.DisconnectFromDatabase();
        }

        private void EjecutarManejarIncremento(int modo)
        {
            string paramNombre = "param_MODO"
                , commandText = "AUDITORIA.sp_MANEJAR_INCREMENTO";
            this.conexionMySqlCluster.ConnectFromDatabase();
            this.InitNpgsqlComponents(commandText);
            this.mysqlCommand.Parameters.Add(new MySqlParameter(paramNombre, MySqlDbType.VarChar)).Value = modo;
            this.mysqlCommand.CommandType = CommandType.StoredProcedure;
            this.mysqlCommand.ExecuteNonQuery();
            this.conexionMySqlCluster.DisconnectFromDatabase();
            Console.WriteLine("hecha");
        }

        private void ExecuteNonQuery()
        {
            this.ExecuteConnectionCommandsMySQL();
            this.mysqlCommand.ExecuteNonQuery();
            this.conexionMySqlCluster.DisconnectFromDatabase();
        }

        private void InitNpgsqlComponents(string commandText)
        {
            this.mysqlCommand = new MySqlCommand(commandText, this.conexionMySqlCluster.mysqlConnection);
        }

        private void ExecuteConnectionCommandsMySQL()
        {
            this.conexionMySqlCluster.ConnectFromDatabase();
            this.mysqlCommand.CommandType = CommandType.Text;
        }
    }
}
