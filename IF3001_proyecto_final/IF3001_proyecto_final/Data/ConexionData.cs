using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace IF3001_proyecto_final.Data
{
    class ConexionData
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;

        public ConexionData()
        {
            this.ConnectToDatabase();
        }

        public object ConnectToDatabase()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(GetConnectionString());
                return sqlConnection;
            }
            catch (SqlException sqlException)
            {
                return sqlException.Number;
            }
        }

        static private string GetConnectionString()
        {
            return "Data Source=163.178.107.10; database=IF4101_B97452_LAB1; User Id=laboratorios; Password=KmZpo.2796";
        }
    }
}
