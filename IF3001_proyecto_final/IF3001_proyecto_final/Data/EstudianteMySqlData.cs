using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using IF3001_proyecto_final.Cluster;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Data
{
    class EstudianteMySqlData
    {
        private MySqlCommand mysqlCommand;
        private MySqlConnection mysqlConnection;
        private MySqlDataReader mysqlDataReader;

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            this.EjecutarInsertarEstudiante(estudiante);
            return this.LeerRespuestaInsertarEstudiante();
        }

        private void EjecutarInsertarEstudiante(Estudiante estudiante)
        {
            string paramName = "param_NOMBRE_ESTUDIANTE"
                , paramLastName = "param_APELLIDOS_ESTUDIANTE"
                , paramAge = "param_EDAD"
                , paramAverage = "param_PROMEDIO"
                , paramCarnet = "param_CARNE"
                , paramAddress = "param_direccion"
                , paramSede = "param_sede"
                , paramBecaType= "param_tipo_beca"
                , paramOut = "msg"
                , commandText = "ESTUDIANTE.sp_INSERTAR_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramName, MySqlDbType.VarChar, estudiante.Nombre);
            this.CreateParameter(paramLastName, MySqlDbType.VarChar, estudiante.Apellidos);
            this.CreateParameter(paramAge, MySqlDbType.Int32, estudiante.Edad);
            this.CreateParameter(paramAverage, MySqlDbType.VarChar, estudiante.Promedio);
            this.CreateParameter(paramCarnet, MySqlDbType.VarChar, estudiante.Carnet);
            this.CreateParameter(paramAddress, MySqlDbType.VarChar, estudiante.Direccion);
            this.CreateParameter(paramSede, MySqlDbType.VarChar, estudiante.Sede);
            this.CreateParameter(paramBecaType, MySqlDbType.VarChar, estudiante.TipoBeca);
            this.CreateParameterOutput(paramOut, MySqlDbType.Int32, 0);
            this.ExecuteNonQuery();
        }

        private bool LeerRespuestaInsertarEstudiante()
        {
            if (Convert.ToInt32(this.mysqlCommand.Parameters["msg"].Value) == 1)
                return true;

            return false;
        }

        private void InitNpgsqlComponents(string commandText)
        {
            ListenerCluster listenerCluster = new ListenerCluster();
            this.mysqlConnection = (MySqlConnection)listenerCluster.ConnectToDatabaseInstance();
            this.mysqlCommand = new MySqlCommand(commandText, this.mysqlConnection);
        }

        private void CreateParameter(string parameterName, MySqlDbType mysqlDbType, object value)
        {
            this.mysqlCommand.Parameters.Add(new MySqlParameter(parameterName, mysqlDbType)).Value = value;
        }

        private void CreateParameterOutput(string parameterName, MySqlDbType mysqlDbType, object value)
        {
            MySqlParameter mySqlParameter = new MySqlParameter(parameterName, mysqlDbType);
            mySqlParameter.Direction = ParameterDirection.Output;
            this.mysqlCommand.Parameters.Add(mySqlParameter).Value = value;
        }

        private void ExecuteNonQuery()
        {
            this.ExecuteConnectionCommands();
            this.mysqlCommand.ExecuteNonQuery();
            this.mysqlConnection.Close();
        }

        private void ExcecuteReader()
        {
            this.ExecuteConnectionCommands();
            this.mysqlDataReader = this.mysqlCommand.ExecuteReader();
        }

        private void ExecuteConnectionCommands()
        {
            this.mysqlConnection.Open();
            this.mysqlCommand.CommandType = CommandType.StoredProcedure;
        }
    }
}
