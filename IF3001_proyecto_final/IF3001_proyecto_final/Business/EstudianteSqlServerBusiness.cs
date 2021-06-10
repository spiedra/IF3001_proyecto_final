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

        public List<Carrera> ObtenerCarrerasEstudiante(int estudianteId)
        {
            return this.estudianteSqlServerData.ObtenerCarrerasEstudiante(estudianteId);
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

        public List<Telefono> ObtenerTelefonosEstudiante(int estudianteId)
        {
            return this.estudianteSqlServerData.ObtenerTelefonosEstudiante(estudianteId);
        }

        public void EliminarTelefonoEstudiante(int estudianteId, string numeroTelefonico)
        {
            this.estudianteSqlServerData.EliminarTelefonoEstudiante(estudianteId, numeroTelefonico);
        }

        public void InsertarTelefonoEstudiante(int estudianteId, string numeroTelefono)
        {
            this.estudianteSqlServerData.InsertarTelefonoEstudiante(estudianteId, numeroTelefono);
        }

        public void ActualizarEstudiante(Estudiante estudiante, string nuevaSede)
        {
            this.estudianteSqlServerData.ActualizarEstudiante(estudiante, nuevaSede);
        }

        public List<Curso> ObtenerTodosLosCursos()
        {
            return this.estudianteSqlServerData.ObtenerTodosLosCursos();
        }

        public List<Carrera> ObtenerTodasLasCarreras()
        {
            return this.estudianteSqlServerData.ObtenerTodasLasCarreras();
        }

        public List<Beca> ObtenerTodasLasBecas()
        {
            return this.estudianteSqlServerData.ObtenerTodasLasBeca();
        }

        public List<Sede> ObtenerTodasLasSedes()
        {
            return this.estudianteSqlServerData.ObtenerTodasLasSedes();
        }

        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            return this.estudianteSqlServerData.ObtenerTodosLosEstudiantes();
        }
    }
}
