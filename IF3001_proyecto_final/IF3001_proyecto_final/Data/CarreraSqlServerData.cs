using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Data
{
    class CarreraSqlServerData
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;

        public List<Carrera> ObtenerTodasLasCarreras()
        {
            this.EjecutarMostrarCarreras();
            return this.LeerRespuestaMostrarCarreras();
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

        private void InitSqlComponents(string commandText)
        {
           // ConexionSqlServerData conexionSqlServerData = new ConexionSqlServerData();
          //  this.sqlConnection = (SqlConnection)conexionSqlServerData.ConnectToDatabase();
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
