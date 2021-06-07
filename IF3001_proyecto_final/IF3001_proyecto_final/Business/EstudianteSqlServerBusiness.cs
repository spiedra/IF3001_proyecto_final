using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IF3001_proyecto_final.Data;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Business
{
    class EstudianteSqlServerBusiness
    {
        private EstudianteSqlServerData estudianteSqlServerData;
        public EstudianteSqlServerBusiness()
        {
            estudianteSqlServerData = new EstudianteSqlServerData();
        }

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            return this.estudianteSqlServerData.AgregarEstudiante(estudiante);
        }
    }
}
