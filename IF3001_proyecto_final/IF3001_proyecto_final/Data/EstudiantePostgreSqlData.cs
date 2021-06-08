using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Data
{
    class EstudiantePostgreSqlData
    {
        private NpgsqlCommand npgsqlCommand;
        private NpgsqlConnection npgsqlConnection;
        private NpgsqlDataReader npgsqlDataReader;

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            this.EjecutarInsertarEstudiante(estudiante);
            return this.LeerRespuestaInsertarEstudiante();
        }

        private void EjecutarInsertarEstudiante(Estudiante estudiante)
        {
            string paramName = "@param_NOMBRE_ESTUDIANTE"
                , paramLastName = "@param_APELLIDOS_ESTUDIANTE"
                , paramAge = "@param_EDAD"
                , paramAverage = "@param_PROMEDIO"
                , paramCarnet = "@param_CARNE"
                , paramAddress = "@param_direccion"
                , commandText = "ESTUDIANTE.fn_INSERTAR_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramName, NpgsqlTypes.NpgsqlDbType.Varchar, estudiante.Nombre);
            this.CreateParameter(paramLastName, NpgsqlTypes.NpgsqlDbType.Varchar, estudiante.Apellidos);
            this.CreateParameter(paramAge, NpgsqlTypes.NpgsqlDbType.Integer, estudiante.Edad);
            this.CreateParameter(paramAverage, NpgsqlTypes.NpgsqlDbType.Varchar, estudiante.Promedio);
            this.CreateParameter(paramCarnet, NpgsqlTypes.NpgsqlDbType.Varchar, estudiante.Carnet);
            this.CreateParameter(paramAddress, NpgsqlTypes.NpgsqlDbType.Varchar, estudiante.Direccion);
            this.ExcecuteReader();
        }

        private bool LeerRespuestaInsertarEstudiante()
        {
            this.npgsqlDataReader.Read();
            if (this.npgsqlDataReader.GetInt32(0) == 1)
                return true;

            this.npgsqlDataReader.Close();
            return false;
        }

        private void InitNpgsqlComponents(string commandText)
        {
            ConexionPostgreSqlData conexionPostgreSqlData = new ConexionPostgreSqlData();
            this.npgsqlConnection = (NpgsqlConnection)conexionPostgreSqlData.ConnectToDatabase();
            this.npgsqlCommand = new NpgsqlCommand(commandText, this.npgsqlConnection);
        }

        private void CreateParameter(string parameterName, NpgsqlTypes.NpgsqlDbType npgsqlDbType, object value)
        {
            NpgsqlParameter npgsqlParameter = new NpgsqlParameter(parameterName, npgsqlDbType);
            npgsqlParameter.Value = value;
            this.npgsqlCommand.Parameters.Add(npgsqlParameter);
        }

        private void ExecuteNonQuery()
        {
            this.ExecuteConnectionCommands();
            this.npgsqlCommand.ExecuteNonQuery();
            this.npgsqlConnection.Close();
        }

        private void ExcecuteReader()
        {
            this.ExecuteConnectionCommands();
            this.npgsqlDataReader = this.npgsqlCommand.ExecuteReader();
        }

        private void ExecuteConnectionCommands()
        {
            this.npgsqlConnection.Open();
            this.npgsqlCommand.CommandType = CommandType.StoredProcedure;
        }
    }
}
