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

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            this.EjecutarInsertarEstudiante(estudiante);
            return this.LeerRespuestaInsertarEstudiante();
        }

        public Estudiante ObtenerEstudiantePorCarnet(string carnet)
        {
            this.EjecutarMostrarEstudiantePorCarnet(carnet);
            return LeerRespuestaMostrarEstudiantePorCarnet();
        }

        public List<Curso> ObtenerCursosEstudiante(int estudianteId)
        {
            this.EjecutarMostrarCursosEstudiante(estudianteId);
            return LeerRespuestaMostarCursosEstudiante();
        }

        public void EliminarCursoEstudiante(int cursoId)
        {
            string paramEstudianteId = "@param_ID_ESTUDIANTE  "
              , commandText = "ADMINISTRACION.sp_BORRAR_CURSO";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramEstudianteId, SqlDbType.Int, cursoId);
            this.ExecuteNonQuery();
        }

        private void EjecutarMostrarCursosEstudiante(int estudianteId)
        {
            string paramEstudianteId = "@param_ID_ESTUDIANTE  "
                , commandText = "ESTUDIANTE.sp_MOSTRAR_CURSOS_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramEstudianteId, SqlDbType.Int, estudianteId);
            this.ExcecuteReader();
        }

        private List<Curso> LeerRespuestaMostarCursosEstudiante()
        {
            List<Curso> cursos = new List<Curso>();
            while (this.sqlDataReader.Read())
            {
                Curso curso = new Curso(this.sqlDataReader.GetInt32(0), this.sqlDataReader.GetString(1)
                    , this.sqlDataReader.GetInt32(2));
                cursos.Add(curso);
            }
            return cursos;
        }

        private void EjecutarMostrarEstudiantePorCarnet(string carnet)
        {
            string paramCarnet = "@param_CARNE "
                , commandText = "ESTUDIANTE.sp_MOSTRAR_ESTUDIANTES_POR_CARNE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramCarnet, SqlDbType.VarChar, carnet);
            this.ExcecuteReader();
        }

        private Estudiante LeerRespuestaMostrarEstudiantePorCarnet()
        {
            if (this.sqlDataReader.Read())
            {
                Estudiante estudiante = new Estudiante(this.sqlDataReader.GetInt32(0), this.sqlDataReader.GetString(1)
                    , this.sqlDataReader.GetString(2), this.sqlDataReader.GetInt32(3), this.sqlDataReader.GetString(4)
                    , this.sqlDataReader.GetString(5), this.sqlDataReader.GetString(8));
                estudiante.TipoBeca = this.sqlDataReader.GetInt32(6);
                estudiante.Sede = this.sqlDataReader.GetString(7);
                return estudiante;
            }
            return null;
        }

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
            this.CreateParameter(paramAge, SqlDbType.Int, estudiante.Edad);
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
