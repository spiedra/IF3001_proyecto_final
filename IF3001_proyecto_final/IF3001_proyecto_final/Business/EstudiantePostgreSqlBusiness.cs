using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IF3001_proyecto_final.Data;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Business
{
    class EstudiantePostgreSqlBusiness
    {
        private EstudiantePostgreSqlData estudiantePostgreSqlData;

        public EstudiantePostgreSqlBusiness()
        {
            this.estudiantePostgreSqlData = new EstudiantePostgreSqlData();
        }

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            return this.estudiantePostgreSqlData.AgregarEstudiante(estudiante);
        }
    }
}
