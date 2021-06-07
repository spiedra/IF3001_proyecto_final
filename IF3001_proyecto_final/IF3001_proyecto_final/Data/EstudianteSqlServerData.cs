using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IF3001_proyecto_final.Domain;
using System.Threading.Tasks;

namespace IF3001_proyecto_final.Data
{
    class EstudianteSqlServerData
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;

        private void EjecutarInsertarEstudiante(Estudiante estudiante)
        {
            string paramName = "@param_NOMBRE_ESTUDIANTE"
                , paramLastName = "@param_APELLIDOS_ESTUDIANTE"
                , paramAge = "@param_EDAD "
                , paramAverage = "@param_PROMEDIO"
                , paramCarnet = "@param_CARNE"
                , paramAddress = "@param_direccion"
                , commandText = "ESTUDIANTE.sp_INSERTAR_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramName, SqlDbType.VarChar, estudiante.Nombre);
            this.CreateParameter(paramLastName, SqlDbType.VarChar, estudiante.Apellidos);
            this.CreateParameter(paramAge, SqlDbType.VarChar, estudiante.Edad);
            this.CreateParameter(paramAverage, SqlDbType.VarChar, estudiante.Promedio);
            this.CreateParameter(paramCarnet, SqlDbType.VarChar, estudiante.Carnet);
            this.CreateParameter(paramAddress, SqlDbType.VarChar, estudiante.Direccion);
            this.ExcecuteReader();
        }

        private bool LeerRespuestaInsertarEstudiante()
        {
            this.sqlDataReader.Read();
            if (this.sqlDataReader.GetInt32(0) == 1)
                return true;

            this.sqlConnection.Close();
            return false;
        }

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            this.EjecutarInsertarEstudiante(estudiante);
            return this.LeerRespuestaInsertarEstudiante();
        }

        private void InitSqlComponents(string commandText)
        {
            ConexionSqlServerData conexionSqlServerData = new ConexionSqlServerData();
            this.sqlConnection = (SqlConnection)conexionSqlServerData.ConnectToDatabase();
            this.sqlCommand = new SqlCommand(commandText, this.sqlConnection);
        }

        private void CreateParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter sqlParameter = new SqlParameter(parameterName, dbType);
            sqlParameter.Value = value;
            this.sqlCommand.Parameters.Add(sqlParameter);
        }

        private void ExecuteNonQuery()
        {
            this.ExecuteConnectionCommands();
            this.sqlCommand.ExecuteNonQuery();
            this.sqlConnection.Close();
        }

        private void ExcecuteReader()
        {
            this.ExecuteConnectionCommands();
            this.sqlDataReader = this.sqlCommand.ExecuteReader();
        }

        private void ExecuteConnectionCommands()
        {
            this.sqlConnection.Open();
            this.sqlCommand.CommandType = CommandType.StoredProcedure;
        }
    }
}
