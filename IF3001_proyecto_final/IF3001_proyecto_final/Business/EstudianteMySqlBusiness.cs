using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IF3001_proyecto_final.Data;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Business
{
    class EstudianteMySqlBusiness
    {
        private EstudianteMySqlData estudianteMySqlData;

        public EstudianteMySqlBusiness()
        {
            this.estudianteMySqlData = new EstudianteMySqlData();
        }

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            return this.estudianteMySqlData.AgregarEstudiante(estudiante);
        }
    }
}
