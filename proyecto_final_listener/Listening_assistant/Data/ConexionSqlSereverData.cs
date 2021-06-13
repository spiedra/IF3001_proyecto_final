using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Listening_assistant.Cluster;


namespace Listening_assistant.Data
{
    class ConexionSqlSereverData
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;
        private SqlParameter parameterReturn;

        public void SendNewDataToSqlServer(List<string> jsonList, string spName, string tableName, bool isIdentity)
        {
            string paramJsonList = "@param_JSON_DATA"
              , commandText = spName;

            this.EjecutarBorrarDatosTabla(tableName, isIdentity);
            foreach (string jsonObjet in jsonList)
            {
                this.InitSqlComponents(commandText);
                this.CreateParameter(paramJsonList, SqlDbType.NVarChar, jsonObjet);
                this.ExecuteNonQuery();
            }
        }

        public void EjecutarBorrarDatosTabla(string tableName, bool isIdentity)
        {
            string paramTable = "@param_TABLA"
             , commandText = "";

            if (isIdentity)
            {
                commandText = "AUDITORIA.sp_BORRAR_DATOS_TABLA";
            }
            else
            {
                commandText = "AUDITORIA.sp_BORRAR_DATOS_TABLA_NON_IDENTITY";
            }

            this.InitSqlComponents(commandText);
            this.CreateParameter(paramTable, SqlDbType.VarChar, tableName);
            this.ExecuteNonQuery();
        }

        private void InitSqlComponents(string commandText)
        {
            ConexionSqlServerCluster conexionSqlServerCluster = new ConexionSqlServerCluster();
            this.sqlConnection = (SqlConnection)conexionSqlServerCluster.EstablishSqlServerConnection();
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
