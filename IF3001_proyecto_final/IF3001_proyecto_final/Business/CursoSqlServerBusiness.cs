using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IF3001_proyecto_final.Data;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Business
{
    class CursoSqlServerBusiness
    {
        private CursoSqlServerData CursoSqlServerData;
        public CursoSqlServerBusiness()
        {
            CursoSqlServerData = new CursoSqlServerData();
        }

        public List<Curso> ObtenerTodosLosCursos()
        {
            return this.CursoSqlServerData.ObtenerTodosLosCursos();
        }
    }
}
