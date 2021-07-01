using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

using System.Data;
using Newtonsoft.Json;
using Listening_assistant.Domain;

namespace Listening_assistant.Data
{
    class ConexionMySqlData
    {
        private MySqlCommand mysqlCommand;
        private MySqlConnection mysqlConnection;
        private MySqlDataReader mysqlDataReader;

        public ConexionMySqlData()
        {

        }

        public List<Auditoria> VerificarNuevosCambios(MySqlConnection mySqlConnectio)
        {
            this.mysqlConnection = mySqlConnectio;
            this.EjecutarMostrarAuditorias();
            return this.LeerRespuestaMostrarAuditorias();
        }

        public void ObtenerDatosNuevos(List<Auditoria> auditorias)
        {
            this.EjecutarObtenerNuevosDatos(auditorias);
        }

        private void EjecutarObtenerNuevosDatos(List<Auditoria> auditorias)
        {
            for (int i = 0; i < auditorias.Count; i++)
            {
                string commandText = auditorias[i].NombreProcedimiento;
                Console.WriteLine("AUDITORIO ID: " + auditorias[i].Id 
                    + ", Nombre tabla: " + auditorias[i].NombreTabla + ", sp_name: " + auditorias[i].NombreProcedimiento);
                this.InitMySqlComponents(commandText);
                this.ExcecuteReader();
                this.LeerRespuestaObtenerNuevosDatos(1, auditorias[i]);
            }
        }

        private void LeerRespuestaObtenerNuevosDatos(int i, Auditoria auditoria)
        {
            switch (auditoria.NombreTabla)
            {
                case "ESTUDIANTE.tb_ESTUDIANTE":
                    this.SendNewData(this.SerializeEstudiante(), "AUDITORIA.sp_INSERTAR_ESTUDIANTE_JSON", auditoria.NombreTabla, true);
                    break;

                case "ESTUDIANTE.tb_DIRECCION":
                    this.SendNewData(this.SerializeDireccion(), "AUDITORIA.sp_INSERTAR_DIRECCION_JSON", auditoria.NombreTabla, true);
                    break;

                case "ESTUDIANTE.tb_TELEFONO":
                    this.SendNewData(this.SerializeTelefono(), "AUDITORIA.sp_INSERTAR_TELEFONO_JSON", auditoria.NombreTabla, true);
                    break;

                case "ESTUDIANTE.tb_ESTUDIANTE_BECA":
                    this.SendNewData(this.SerializeObjectRelacion(), "AUDITORIA.sp_INSERTAR_ESTUDIANTE_BECA_JSON", auditoria.NombreTabla, false);
                    break;

                case "ESTUDIANTE.tb_ESTUDIANTE_CARRERA":
                    this.SendNewData(this.SerializeObjectRelacion(), "AUDITORIA.sp_INSERTAR_ESTUDIANTE_CARRERA_JSON", auditoria.NombreTabla, false);
                    break;

                case "ESTUDIANTE.tb_ESTUDIANTE_CURSO":
                    this.SendNewData(this.SerializeObjectRelacion(), "AUDITORIA.sp_INSERTAR_ESTUDIANTE_CURSO_JSON", auditoria.NombreTabla, false);
                    break;

                case "ESTUDIANTE.tb_ESTUDIANTE_SEDE":
                    this.SendNewData(this.SerializeObjectRelacion(), "AUDITORIA.sp_INSERTAR_ESTUDIANTE_SEDE_JSON", auditoria.NombreTabla, false);
                    break;

                case "ESTUDIANTE.tb_ESTUDIANTE_TELEFONO":
                    this.SendNewData(this.SerializeObjectRelacion(), "AUDITORIA.sp_INSERTAR_ESTUDIANTE_TELEFONO_JSON", auditoria.NombreTabla, false);
                    break;
            }
            this.mysqlConnection.Close();
            this.EjecutarMarcarAtendido(auditoria.Id);
        }

        private List<string> SerializeEstudiante()
        {
            List<string> jsonList = new List<string>();
            while (this.mysqlDataReader.Read())
            {
                Estudiante estudiante = new Estudiante(this.mysqlDataReader.GetInt32(0), this.mysqlDataReader.GetString(1)
                    , this.mysqlDataReader.GetString(2), this.mysqlDataReader.GetInt32(3), this.mysqlDataReader.GetString(4)
                     , this.mysqlDataReader.GetString(5), this.mysqlDataReader.GetString(6), this.mysqlDataReader.GetInt32(7));
                jsonList.Add(JsonConvert.SerializeObject(estudiante));
            }
            return jsonList;
        }

        private List<string> SerializeObjectRelacion()
        {
            List<string> jsonList = new List<string>();
            while (this.mysqlDataReader.Read())
            {
                ObjectoRelacion objectoRelacion = new ObjectoRelacion(this.mysqlDataReader.GetInt32(0)
                    , this.mysqlDataReader.GetInt32(1), this.mysqlDataReader.GetInt32(2));
                jsonList.Add(JsonConvert.SerializeObject(objectoRelacion));
            }
            return jsonList;
        }

        private List<string> SerializeDireccion()
        {
            List<string> jsonList = new List<string>();
            while (this.mysqlDataReader.Read())
            {
                Direccion direccion = new Direccion(this.mysqlDataReader.GetInt32(0)
                    , this.mysqlDataReader.GetString(1), this.mysqlDataReader.GetInt32(2));
                jsonList.Add(JsonConvert.SerializeObject(direccion));
            }
            return jsonList;
        }

        private List<string> SerializeTelefono()
        {
            List<string> jsonList = new List<string>();
            while (this.mysqlDataReader.Read())
            {
                Telefono telefono = new Telefono(this.mysqlDataReader.GetInt32(0)
                    , this.mysqlDataReader.GetString(1), this.mysqlDataReader.GetInt32(2));
                jsonList.Add(JsonConvert.SerializeObject(telefono));
            }
            return jsonList;
        }

        private void SendNewData(List<string> jsonList, string spName, string tableName, bool isIdentity)
        {
            ConexionSqlSereverData conexionSqlSereverData = new ConexionSqlSereverData();
            conexionSqlSereverData.SendNewDataToSqlServer(jsonList, spName, tableName, isIdentity);
        }

        private void EjecutarMarcarAtendido(int id)
        {
            Console.WriteLine("marcando atendido. Id: "+id);
            string paramId = "PARAM_ID"
                , commandText = "AUDITORIA.sp_MARCAR_ATENDIDO";
            this.InitMySqlComponents(commandText);
            this.CreateParameter(paramId, MySqlDbType.Int32, id);
            this.ExecuteNonQuery();
        }

        private void EjecutarMostrarAuditorias()
        {
            string commandText = "AUDITORIA.sp_MOSTRAR_AUDITORIAS";
            this.InitMySqlComponents(commandText);
            this.ExcecuteReader();
        }

        private List<Auditoria> LeerRespuestaMostrarAuditorias()
        {
            List<Auditoria> auditorias = new List<Auditoria>();
            while (this.mysqlDataReader.Read())
            {
                auditorias.Add(new Auditoria(this.mysqlDataReader.GetInt32(0), this.mysqlDataReader.GetString(1), this.mysqlDataReader.GetString(3)));
            }
            Console.WriteLine("Cerrando la conexion");
            this.mysqlConnection.Close();
            return auditorias;
        }

        private void InitMySqlComponents(string commandText)
        {
            this.mysqlCommand = new MySqlCommand(commandText, this.mysqlConnection);
        }

        private void CreateParameter(string parameterName, MySqlDbType mysqlDbType, object value)
        {
            this.mysqlCommand.Parameters.Add(new MySqlParameter(parameterName, mysqlDbType)).Value = value;
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
            Console.WriteLine("ABRIENDO LA CONEXION");
            this.mysqlConnection.Open();
            this.mysqlCommand.CommandType = CommandType.StoredProcedure;
        }
    }
}
