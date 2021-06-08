using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace IF3001_proyecto_final.Data
{
    class ConexionPostgreSqlData
    {
        public ConexionPostgreSqlData()
        {
            this.ConnectToDatabase();
        }

        public object ConnectToDatabase()
        {
            try
            {
                NpgsqlConnection npgsqlConnection = new NpgsqlConnection(GetConnectionString());
                return npgsqlConnection;
            }
            catch (NpgsqlException npgsqlException)
            {
                return npgsqlException.ErrorCode;
            }
        }

        static private string GetConnectionString()
        {
            return "Data Source=163.178.107.10; database=IF4101_B97452_LAB1; User Id=laboratorios; Password=KmZpo.2796";
        }
    }
}
