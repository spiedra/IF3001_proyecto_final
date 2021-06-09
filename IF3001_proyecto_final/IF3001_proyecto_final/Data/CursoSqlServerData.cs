using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using IF3001_proyecto_final.Domain;
using IF3001_proyecto_final.Cluster;

namespace IF3001_proyecto_final.Data
{
    class CursoSqlServerData
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;

        public List<Curso> ObtenerTodosLosCursos()
        {
            this.EjecutarMostrarCursos();
            return this.LeerRespuestaMostrarCursos();
        }

        private void EjecutarMostrarCursos()
        {
            string  commandText = "ADMINISTRACION.sp_MOSTRAR_CURSOS";
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

        private void InitSqlComponents(string commandText)
        {
            ListenerCluster listenerCluster = new ListenerCluster();
            this.sqlConnection = (SqlConnection)listenerCluster.ConnectToDatabaseInstance();
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
