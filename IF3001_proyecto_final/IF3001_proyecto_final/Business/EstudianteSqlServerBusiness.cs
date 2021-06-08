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

        public Estudiante ObtenerEstudiantePorCarnet(string carnet)
        {
            return this.estudianteSqlServerData.ObtenerEstudiantePorCarnet(carnet);
        }

        public List<Curso> ObtenerCursosEstudiante(int estudianteId)
        {
            return this.estudianteSqlServerData.ObtenerCursosEstudiante(estudianteId);
        }

        public void EliminarCursoEstudiante(string carnetEstudiante, string nombreCurso)
        {
            this.estudianteSqlServerData.EliminarCursoEstudiante(carnetEstudiante, nombreCurso);
        }

        public void InsertarCursoEstudiante(int estudianteId, string nombreCurso)
        {
            this.estudianteSqlServerData.InsertarCursoEstudiante(estudianteId, nombreCurso);
        }

        public List<Carrera> MostrarCarrerasEstudiante(int estudianteId)
        {
            return this.estudianteSqlServerData.MostrarCarrerasEstudiante(estudianteId);
        }

        public void EliminarCarreraEstudiante(string nombreCarrera, string carnetEstudiante)
        {
            this.estudianteSqlServerData.EliminarCarreraEstudiante(nombreCarrera, carnetEstudiante);
        }

        public void InsertarCarreraEstudiante(int estudianteId, string nombreCarrera)
        {
            this.estudianteSqlServerData.InsertarCarrreraEstudiante(estudianteId, nombreCarrera);
        }

        public void EliminarEstudiante(int estudianteId)
        {
            this.estudianteSqlServerData.EliminarEstudiante(estudianteId);
        }
    }
}
