using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IF3001_proyecto_final.Domain;
using System.Threading.Tasks;
using IF3001_proyecto_final.Cluster;

namespace IF3001_proyecto_final.Data
{
    class EstudianteSqlServerData
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;
        private SqlParameter parameterReturn;

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

        public void EliminarCursoEstudiante(string carnetEstudiante, string nombreCurso)
        {
            string paramStudentCarnet = "@param_CARNE_ESTUDIANTE"
                , paramCourseName = "@param_NOMBRE_CURSO"
                , commandText = "ESTUDIANTE.sp_QUITAR_CURSO_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramStudentCarnet, SqlDbType.VarChar, carnetEstudiante);
            this.CreateParameter(paramCourseName, SqlDbType.VarChar, nombreCurso);
            this.ExecuteNonQuery();
        }

        public void InsertarCursoEstudiante(int estudianteId, string nombreCurso)
        {
            string paramStudentId = "@param_ID_ESTUDIANTE"
               , paramCourseName = "@param_NOMBRE_CURSO"
               , commandText = "ESTUDIANTE.sp_INSERTAR_CURSO_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramStudentId, SqlDbType.Int, estudianteId);
            this.CreateParameter(paramCourseName, SqlDbType.VarChar, nombreCurso);
            this.ExecuteNonQuery();
        }

        public List<Carrera> ObtenerCarrerasEstudiante(int estudianteId)
        {
            this.EjecutarMostraCarreraEstudiante(estudianteId);
            return LeerRespuestaMostrarCarreraEstudiante();
        }

        public void EliminarCarreraEstudiante(string nombreCarrera, string carnetEstudiante)
        {
            string paramStudentCarnet = "@param_CARNE_ESTUDIANTE"
                , paramMajorName = "@param_NOMBRE_CURSO"
                , commandText = "ESTUDIANTE.QUITAR_CARRERA_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramMajorName, SqlDbType.VarChar, nombreCarrera);
            this.CreateParameter(paramStudentCarnet, SqlDbType.VarChar, carnetEstudiante);
            this.ExecuteNonQuery();
        }

        public void InsertarCarrreraEstudiante(int estudianteId, string nombreCarrera)
        {
            string paramStudentId = "@param_ID_ESTUDIANTE"
               , paramMajorName = "@param_NOMBRE_CARRERA"
               , commandText = "ESTUDIANTE.sp_INSERTAR_CARRERA_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramStudentId, SqlDbType.Int, estudianteId);
            this.CreateParameter(paramMajorName, SqlDbType.VarChar, nombreCarrera);
            this.ExecuteNonQuery();
        }

        public void EliminarEstudiante(string carne)
        {
            string paramStudentId = "@param_CARNE"
              , commandText = "ESTUDIANTE.sp_BORRAR_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramStudentId, SqlDbType.VarChar, carne);
            this.ExecuteNonQuery();
        }

        public List<Telefono> ObtenerTelefonosEstudiante(int estudianteId)
        {
            this.EjecutarVerContactosEstudiante(estudianteId);
            return this.LeerRespuestaVerContactorEstudiante();
        }

        public void EliminarTelefonoEstudiante(int estudianteId, string numeroTelefonico)
        {
            string paramStudentId = "@param_ID_ESTUDIANTE"
               , paramNumber = "@param_NUMERO"
               , commandText = "ESTUDIANTE.sp_QUITAR_TELEFONO_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramStudentId, SqlDbType.Int, estudianteId);
            this.CreateParameter(paramNumber, SqlDbType.VarChar, numeroTelefonico);
            this.ExecuteNonQuery();
        }

        public void InsertarTelefonoEstudiante(int estudianteId, string numeroTelefono)
        {
            string paramPhoneNumber = "@param_NUMERO_TELEFONO "
              , paramStudentId = "@param_ID_ESTUDIANTE "
              , commandText = "ESTUDIANTE.sp_INSERTAR_TELEFONO_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramPhoneNumber, SqlDbType.VarChar, numeroTelefono);
            this.CreateParameter(paramStudentId, SqlDbType.Int, estudianteId);
            this.ExecuteNonQuery();
        }

        public bool ActualizarEstudiante(Estudiante estudiante)
        {
            string paramId = "@param_ID_ESTUDIANTE"
               , paramName = "@param_NOMBRE_ESTUDIANTE"
               , paramLastName = "@param_APELLIDOS_ESTUDIANTE"
               , paramAge = "@param_EDAD"
               , paramAverage = "@param_PROMEDIO"
               , paramCarnet = "@param_CARNE"
               , paramAddress = "@param_direccion"
               , paramSName = "@param_NOMBRE_SEDE "
               , paramBeca="@param_TIPO_BECA"
               , commandText = "ESTUDIANTE.sp_ACTUALIZAR_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramId, SqlDbType.Int, estudiante.Id);
            this.CreateParameter(paramName, SqlDbType.VarChar, estudiante.Nombre);
            this.CreateParameter(paramLastName, SqlDbType.VarChar, estudiante.Apellidos);
            this.CreateParameter(paramAge, SqlDbType.Int, estudiante.Edad);
            this.CreateParameter(paramAverage, SqlDbType.VarChar, estudiante.Promedio);
            this.CreateParameter(paramCarnet, SqlDbType.VarChar, estudiante.Carnet);
            this.CreateParameter(paramAddress, SqlDbType.VarChar, estudiante.Direccion);
            this.CreateParameter(paramSName, SqlDbType.VarChar, estudiante.Sede);
            this.CreateParameter(paramBeca, SqlDbType.VarChar, estudiante.TipoBeca);
            this.ExecuteNonQuery();

            return true;
        }

        public List<Curso> ObtenerTodosLosCursos()
        {
            this.EjecutarMostrarCursos();
            return this.LeerRespuestaMostrarCursos();
        }

        public List<Carrera> ObtenerTodasLasCarreras()
        {
            this.EjecutarMostrarCarreras();
            return this.LeerRespuestaMostrarCarreras();
        }

        public List<Sede> ObtenerTodasLasSedes()
        {
            this.EjecutarMostrarSedes();
            return this.LeerRespuestaMostrarSedes();
        }

        public List<Beca> ObtenerTodasLasBeca()
        {
            this.EjecutarMostrarBecas();
            return this.LeerRespuestaMostrarBecas();
        }

        private void EjecutarMostrarBecas()
        {
            string commandText = "ADMINISTRACION.sp_MOSTRAR_BECAS";
            this.InitSqlComponents(commandText);
            this.ExcecuteReader();
        }

        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            this.EjecutarMostrarEstudiantes();
            return this.LeerRespuestaMostrarEstudiantes();
        }

        private void EjecutarMostrarEstudiantes()
        {
            string commandText = "ESTUDIANTE.sp_MOSTRAR_ESTUDIANTES";   
            this.InitSqlComponents(commandText);
            this.ExcecuteReader();
        }

        private List<Estudiante> LeerRespuestaMostrarEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            while (this.sqlDataReader.Read())
            {
                Estudiante estudiante = new Estudiante(this.sqlDataReader.GetInt32(0), this.sqlDataReader.GetString(1)
                    , this.sqlDataReader.GetString(2), this.sqlDataReader.GetInt32(3), this.sqlDataReader.GetString(4)
                    , this.sqlDataReader.GetString(5), this.sqlDataReader.GetString(6), this.sqlDataReader.GetString(7)
                    , this.sqlDataReader.GetString(8));
                estudiantes.Add(estudiante);
            }
            return estudiantes;
        }

        private List<Beca> LeerRespuestaMostrarBecas()
        {
            List<Beca> becas = new List<Beca>();
            while (this.sqlDataReader.Read())
            {
                becas.Add(new Beca(this.sqlDataReader.GetInt32(0), this.sqlDataReader.GetString(1)));
            }
            return becas;
        }

        private void EjecutarMostrarSedes()
        {
            string commandText = "ADMINISTRACION.MOSTRAR_SEDES";
            this.InitSqlComponents(commandText);
            this.ExcecuteReader();
        }

        private List<Sede> LeerRespuestaMostrarSedes()
        {
            List<Sede> sedes = new List<Sede>();
            while (this.sqlDataReader.Read())
            {
                sedes.Add(new Sede(this.sqlDataReader.GetInt32(0), this.sqlDataReader.GetString(1)));
            }
            return sedes;
        }

        private void EjecutarMostrarCursos()
        {
            string commandText = "ADMINISTRACION.sp_MOSTRAR_CURSOS";
            this.InitSqlComponents(commandText);
            this.ExcecuteReader();
        }

        private List<Curso> LeerRespuestaMostrarCursos()
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

        private void EjecutarMostrarCarreras()
        {
            string commandText = "ADMINISTRACION.sp_MOSTRAR_CARRERAS";
            this.InitSqlComponents(commandText);
            this.ExcecuteReader();
        }

        private List<Carrera> LeerRespuestaMostrarCarreras()
        {
            List<Carrera> carreras = new List<Carrera>();
            while (this.sqlDataReader.Read())
            {
                Carrera carrera = new Carrera(this.sqlDataReader.GetInt32(1), this.sqlDataReader.GetString(1));
                carreras.Add(carrera);
            }
            return carreras;
        }

        private void EjecutarVerContactosEstudiante(int estudianteId)
        {
            string paramEstudianteId = "@param_ID_ESTUDIANTE"
                , commandText = "ESTUDIANTE.sp_VER_CONTACTOS_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramEstudianteId, SqlDbType.Int, estudianteId);
            this.ExcecuteReader();
        }

        private List<Telefono> LeerRespuestaVerContactorEstudiante()
        {
            List<Telefono> telefonos = new List<Telefono>();
            while (this.sqlDataReader.Read())
            {
                Telefono telefono = new Telefono(-1, this.sqlDataReader.GetString(0));
                telefonos.Add(telefono);
            }
            return telefonos;
        }

        private void EjecutarMostraCarreraEstudiante(int estudianteId)
        {
            string paramStudentId = "@param_ID_ESTUDIANTE"
            , commandText = "ESTUDIANTE.sp_MOSTRAR_CARRERA_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramStudentId, SqlDbType.Int, estudianteId);
            this.ExecuteNonQuery();
        }

        private List<Carrera> LeerRespuestaMostrarCarreraEstudiante()
        {
            List<Carrera> carreras = new List<Carrera>();
            while (this.sqlDataReader.Read())
            {
                Carrera carrera = new Carrera(-1, this.sqlDataReader.GetString(0));
                carreras.Add(carrera);
            }
            return carreras;
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
            string paramCarnet = "@param_CARNE"
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
                    , this.sqlDataReader.GetString(5), this.sqlDataReader.GetString(8), null, null);
                estudiante.TipoBeca = this.sqlDataReader.GetString(6);
                estudiante.Sede = this.sqlDataReader.GetString(7);
                return estudiante;
            }
            return null;
        }

        private void EjecutarInsertarEstudiante(Estudiante estudiante)
        {
            string paramName = "@param_NOMBRE_ESTUDIANTE"
                , paramLastName = "@param_APELLIDOS_ESTUDIANTE"
                , paramAge = "@param_EDAD"
                , paramAverage = "@param_PROMEDIO"
                , paramCarnet = "@param_CARNE"
                , paramAddress = "@param_direccion"
                , paramSede = "@param_sede"
                , paramBecaType = "@param_tipo_beca"
                , commandText = "ESTUDIANTE.sp_INSERTAR_ESTUDIANTE";

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramName, SqlDbType.VarChar, estudiante.Nombre);
            this.CreateParameter(paramLastName, SqlDbType.VarChar, estudiante.Apellidos);
            this.CreateParameter(paramAge, SqlDbType.Int, estudiante.Edad);
            this.CreateParameter(paramAverage, SqlDbType.VarChar, estudiante.Promedio);
            this.CreateParameter(paramCarnet, SqlDbType.VarChar, estudiante.Carnet);
            this.CreateParameter(paramAddress, SqlDbType.VarChar, estudiante.Direccion);
            this.CreateParameter(paramSede, SqlDbType.VarChar, estudiante.Sede);
            this.CreateParameter(paramBecaType, SqlDbType.VarChar, estudiante.TipoBeca);
            this.CreateParameterOutput();
            this.ExecuteNonQuery();
        }

        private bool LeerRespuestaInsertarEstudiante()
        {
            if ((int)this.parameterReturn.Value == 1)
                return true;

            this.sqlConnection.Close();
            return false;
        }

        private void InitSqlComponents(string commandText)
        {
            ListenerCluster listenerCluster = new ListenerCluster();
            this.sqlConnection = listenerCluster.ConnectToSqlServerInstance();
            this.sqlCommand = new SqlCommand(commandText, this.sqlConnection);
        }

        private void CreateParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter sqlParameter = new SqlParameter(parameterName, dbType);
            sqlParameter.Value = value;
            this.sqlCommand.Parameters.Add(sqlParameter);
        }

        private void CreateParameterOutput()
        {
            this.parameterReturn = new SqlParameter();
            parameterReturn.Direction = ParameterDirection.ReturnValue;
            this.sqlCommand.Parameters.Add(this.parameterReturn);
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
