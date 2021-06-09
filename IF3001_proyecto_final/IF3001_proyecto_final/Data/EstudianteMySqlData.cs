﻿using System;
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
            this.CreateParameter(paramName, MySqlDbType.Int32, estudiante.Nombre);
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

        public Estudiante EjecutarBuscarEstudianteCarne(string carne)
        {
            string paramCarne = "param_CARNE"
            ,commandText="ESTUDIANTE.sp_MOSTRAR_ESTUDIANTES_POR_CARNE";   //posible error parentesis
            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramCarne, MySqlDbType.VarChar, carne);
            this.ExcecuteReader();

            return this.LeerRespuestaBuscarEstudianteCarne();
        }

        private Estudiante LeerRespuestaBuscarEstudianteCarne()
        {
            if (this.mysqlDataReader.Read())
            {
                Estudiante estudiante = new Estudiante(this.mysqlDataReader.GetInt32(0), this.mysqlDataReader.GetString(1)
                    , this.mysqlDataReader.GetString(2), this.mysqlDataReader.GetInt32(3), this.mysqlDataReader.GetString(4)
                    , this.mysqlDataReader.GetString(5), this.mysqlDataReader.GetString(8), this.mysqlDataReader.GetString(7)
                    ,this.mysqlDataReader.GetString(6));
                return estudiante;
            }
            return null;
        }

        public List<Estudiante> EjecutarMostrarEstudiantes()
        {
            string commandText = "ESTUDIANTE.sp_MOSTRAR_ESTUDIANTES";   //posible error parentesis
            this.InitNpgsqlComponents(commandText);
            this.ExcecuteReader();

            return this.leerRespuestaMostrarEstudiantes();
        }

        private List<Estudiante> leerRespuestaMostrarEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            while (this.mysqlDataReader.Read())
            {
                Estudiante estudiante = new Estudiante(this.mysqlDataReader.GetInt32(0), this.mysqlDataReader.GetString(1)
                    , this.mysqlDataReader.GetString(2), this.mysqlDataReader.GetInt32(3), this.mysqlDataReader.GetString(4)
                    , this.mysqlDataReader.GetString(5), this.mysqlDataReader.GetString(8), this.mysqlDataReader.GetString(7)
                    , this.mysqlDataReader.GetString(6));
                estudiantes.Add(estudiante);
            }
            return estudiantes;
        }

        public List<Curso> EjecutarMostrarCursosEstudiante(int estudianteId)
        {
            string paramId = "param_ID_ESTUDIANTE"
                , commandText = "ESTUDIANTE.sp_MOSTRAR_CURSOS_ESTUDIANTE";   //posible error parentesis
            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramId, MySqlDbType.Int32, estudianteId);
            this.ExcecuteReader();

            return this.leerRespuestaMostrarCursosEstudiantes();
        }

        private List<Curso> leerRespuestaMostrarCursosEstudiantes()
        {
            List<Curso> cursos = new List<Curso>();
            while (this.mysqlDataReader.Read())
            {
                Curso curso = new Curso(this.mysqlDataReader.GetInt32(0), this.mysqlDataReader.GetString(1)
                    , this.mysqlDataReader.GetInt32(2));
                cursos.Add(curso);
            }
            return cursos;
        }

        public List<Carrera> EjecutarMostrarCarreraEstudiante(int estudianteId)
        {
            string paramId = "param_ID_ESTUDIANTE"
                , commandText = "ESTUDIANTE.sp_MOSTRAR_CARRERA_ESTUDIANTE";   //posible error parentesis
            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramId, MySqlDbType.Int32, estudianteId);
            this.ExcecuteReader();

            return this.leerRespuestaMostrarCarrerasEstudiante();
        }

        private List<Carrera> leerRespuestaMostrarCarrerasEstudiante()
        {
            List<Carrera> carreras = new List<Carrera>();
            while (this.mysqlDataReader.Read())
            {
                Carrera carrera = new Carrera(-1, this.mysqlDataReader.GetString(0));
                carreras.Add(carrera);
            }
            return carreras;
        }

        public List<Telefono> EjecutarMostrarContactoEstudiante(int estudianteId)
        {
            string paramId = "param_ID_ESTUDIANTE"
                , commandText = "ESTUDIANTE.sp_MOSTRAR_CONTACTOS_ESTUDIANTE";   //posible error parentesis
            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramId, MySqlDbType.Int32, estudianteId);
            this.ExcecuteReader();

            return this.LeerRespuestaContactoEstudiante();
        }

        private List<Telefono> LeerRespuestaContactoEstudiante()
        {
            List<Telefono> telefonos = new List<Telefono>();
            while (this.mysqlDataReader.Read())
            {
                Telefono telefono = new Telefono(-1, this.mysqlDataReader.GetString(0));
                telefonos.Add(telefono);
            }
            return telefonos;
        }

        public List<Curso> EjecutarMostrarCursos()
        {
            string commandText = "ADMINISTRACION.sp_MOSTRAR_CURSOS";   //posible error parentesis
            this.InitNpgsqlComponents(commandText);
            this.ExcecuteReader();

            return this.leerRespuestaMostrarCursos(); 
        }

        private List<Curso> leerRespuestaMostrarCursos()
        {
            List<Curso> cursos = new List<Curso>();
            while (this.mysqlDataReader.Read())
            {
                Curso curso = new Curso(this.mysqlDataReader.GetInt32(0), this.mysqlDataReader.GetString(1)
                    , this.mysqlDataReader.GetInt32(2));
                cursos.Add(curso);
            }
            return cursos;
        }

        public List<Carrera> EjecutarMostrarCarreras()
        {
            string commandText = "ADMINISTRACION.sp_MOSTRAR_CARRERAS";   //posible error parentesis
            this.InitNpgsqlComponents(commandText);
            this.ExcecuteReader();

            return this.LeerRespuestaMostrarCarreras();
        }

        private List<Carrera> LeerRespuestaMostrarCarreras()
        {
            List<Carrera> carreras = new List<Carrera>();
            while (this.mysqlDataReader.Read())
            {
                Carrera carrera = new Carrera(-1, this.mysqlDataReader.GetString(0));
                carreras.Add(carrera);
            }
            return carreras;
        }

        public List<Beca> EjecutarMostrarBecas()
        {
            string commandText = "ADMINISTRACION.sp_MOSTRAR_BECAS";   //posible error parentesis
            this.InitNpgsqlComponents(commandText);
            this.ExcecuteReader();

            return this.LeerRespuestaMostrarBecas();
        }

        private List<Beca> LeerRespuestaMostrarBecas()
        {
            List<Beca> becas = new List<Beca>();
            while (this.mysqlDataReader.Read())
            {
                Beca beca = new Beca(-1, this.mysqlDataReader.GetString(0));
                becas.Add(beca);
            }
            return becas;
        }

        public List<Sede> EjecutarMostrarSedes()
        {
            string commandText = "ADMINISTRACION.sp_MOSTRAR_SEDES";   //posible error parentesis
            this.InitNpgsqlComponents(commandText);
            this.ExcecuteReader();

            return this.leerRespuestaMostrarSedes();
        }

        private List<Sede> leerRespuestaMostrarSedes()
        {
            List<Sede> sedes = new List<Sede>();
            while (this.mysqlDataReader.Read())
            {
                Sede sede = new Sede(-1, this.mysqlDataReader.GetString(0));
                sedes.Add(sede);
            }
            return sedes;
        }


        public bool InsertarCursoEstudiante(int estudianteId, string nombreCurso)
        {
            string paramStudentId = "param_ID_ESTUDIANTE"
              , paramCourseName = "param_NOMBRE_CURSO"
               , paramOut = "msg"
              , commandText = "ESTUDIANTE.sp_INSERTAR_CURSO_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramStudentId, MySqlDbType.Int32, estudianteId);
            this.CreateParameter(paramCourseName, MySqlDbType.VarChar, nombreCurso);
            this.CreateParameterOutput(paramOut, MySqlDbType.Int32, 0);
            this.ExecuteNonQuery();

            return this.LeerRespuesta();
        }



        public bool QuitarCursoEstudiante(string carneEstudiante, string nombreCurso)
        {
            string paramStudentId = "param_CARNE_ESTUDIANTE"
              , paramCourseName = "param_NOMBRE_CURSO"
               , paramOut = "msg"
              , commandText = "ESTUDIANTE.sp_QUITAR_CURSO_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramStudentId, MySqlDbType.VarChar, carneEstudiante);
            this.CreateParameter(paramCourseName, MySqlDbType.VarChar, nombreCurso);
            this.CreateParameterOutput(paramOut, MySqlDbType.Int32, 0);
            this.ExecuteNonQuery();

            return this.LeerRespuesta();
        }

       

        public bool InsertarCarreraEstudiante(int estudianteId, string nombreCarrera)
        {
            string paramStudentId = "param_ID_ESTUDIANTE"
              , paramMajorName = "param_NOMBRE_CARRERA"
               , paramOut = "msg"
              , commandText = "ESTUDIANTE.sp_INSERTAR_CARRERA_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramStudentId, MySqlDbType.Int32, estudianteId);
            this.CreateParameter(paramMajorName, MySqlDbType.VarChar, nombreCarrera);
            this.CreateParameterOutput(paramOut, MySqlDbType.Int32, 0);
            this.ExecuteNonQuery();

            return this.LeerRespuesta();
        }

        

        public bool QuitarCarreraEstudiante(string nombreCarrera, string carneEstudiante)
        {
            string paramStudentId = "param_CARNE_ESTUDIANTE"
              , paramMajorName = "param_NOMBRE_CARRERA"
               , paramOut = "msg"
              , commandText = "ESTUDIANTE.sp_QUITAR_CARRERA_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramStudentId, MySqlDbType.VarChar, carneEstudiante);
            this.CreateParameter(paramMajorName, MySqlDbType.VarChar, nombreCarrera);
            this.CreateParameterOutput(paramOut, MySqlDbType.Int32, 0);
            this.ExecuteNonQuery();

            return this.LeerRespuesta();
        }

        


        public bool InsertarTelefonoEstudiante(int estudianteId, string numeroTelefono)
        {
            string paramPhoneNumber = "param_NUMERO_TELEFONO"
              , paramStudentId = "param_ID_ESTUDIANTE"
               , paramOut = "msg"
              , commandText = "ESTUDIANTE.sp_INSERTAR_TELEFONO_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramPhoneNumber, MySqlDbType.VarChar, numeroTelefono);
            this.CreateParameter(paramStudentId, MySqlDbType.Int32, estudianteId);
            this.CreateParameterOutput(paramOut, MySqlDbType.Int32, 0);
            this.ExecuteNonQuery();

            return this.LeerRespuesta();
        }

        

        public bool QuitarTelefonoEstudiante(int estudianteId, string numeroTelefonico)
        {
            string paramStudentId = "param_ID_ESTUDIANTE"
               , paramNumber = "param_NUMERO"
                , paramOut = "msg"
               , commandText = "ESTUDIANTE.sp_QUITAR_TELEFONO_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramStudentId, MySqlDbType.Int32, estudianteId);
            this.CreateParameter(paramNumber, MySqlDbType.VarChar, numeroTelefonico);
            this.CreateParameterOutput(paramOut, MySqlDbType.Int32, 0);
            this.ExecuteNonQuery();

            return this.LeerRespuesta();
        }

        private bool LeerRespuesta()
        {
            if (Convert.ToInt32(this.mysqlCommand.Parameters["msg"].Value) == 1)
                return true;

            return false;
        }

        public bool ActualizarEstudiante(Estudiante estudiante, string nuevaSede)
        {
            string paramId = "param_ID_ESTUDIANTE"
               , paramName = "param_NOMBRE_ESTUDIANTE"
               , paramLastName = "param_APELLIDOS_ESTUDIANTE"
               , paramAge = "param_EDAD"
               , paramAverage = "param_PROMEDIO"
               , paramCarnet = "param_CARNE"
               , paramAddress = "param_direccion"
               , paramSName = "param_NOMBRE_SEDE"
                , paramOut = "msg"
               , commandText = "ESTUDIANTE.sp_ACTUALIZAR_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramId, MySqlDbType.Int32, estudiante.Id);
            this.CreateParameter(paramName, MySqlDbType.VarChar, estudiante.Nombre);
            this.CreateParameter(paramLastName, MySqlDbType.VarChar, estudiante.Apellidos);
            this.CreateParameter(paramAge, MySqlDbType.Int32, estudiante.Edad);
            this.CreateParameter(paramAverage, MySqlDbType.VarChar, estudiante.Promedio);
            this.CreateParameter(paramCarnet, MySqlDbType.VarChar, estudiante.Carnet);
            this.CreateParameter(paramAddress, MySqlDbType.VarChar, estudiante.Direccion);
            this.CreateParameter(paramSName, MySqlDbType.VarChar, estudiante.Sede);
            this.CreateParameterOutput(paramOut, MySqlDbType.Int32, 0);
            this.ExecuteNonQuery();

            return this.LeerRespuesta;
        }

        public bool BorrarEstudiante(int id)
        {
            string paramStudentId = "param_ID_ESTUDIANTE"
                            , paramOut = "msg"
                           , commandText = "ESTUDIANTE.sp_BORRAR_ESTUDIANTE";

            this.InitNpgsqlComponents(commandText);
            this.CreateParameter(paramStudentId, MySqlDbType.Int32, id);
            this.CreateParameterOutput(paramOut, MySqlDbType.Int32, 0);
            this.ExecuteNonQuery();

            return LeerRespuesta();
        }


        private void InitNpgsqlComponents(string commandText)
        {
            ListenerCluster listenerCluster = new ListenerCluster();
            this.mysqlConnection = listenerCluster.ConnectToMySqlInstance();
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
