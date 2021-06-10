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

        public Estudiante ObtenerEstudiantePorCarnet(string carnet)
        {
            return this.estudianteMySqlData.EjecutarBuscarEstudianteCarne(carnet);
        }

        public List<Curso> ObtenerCursosEstudiante(int estudianteId)
        {
            return this.estudianteMySqlData.EjecutarMostrarCursosEstudiante(estudianteId);
        }

        public void EliminarCursoEstudiante(string carnetEstudiante, string nombreCurso)
        {
            this.estudianteMySqlData.QuitarCursoEstudiante(carnetEstudiante, nombreCurso);
        }

        public void InsertarCursoEstudiante(int estudianteId, string nombreCurso)
        {
            this.estudianteMySqlData.InsertarCursoEstudiante(estudianteId, nombreCurso);
        }

        public List<Carrera> ObtenerCarrerasEstudiante(int estudianteId)
        {
            return this.estudianteMySqlData.EjecutarMostrarCarreraEstudiante(estudianteId);
        }

        public void EliminarCarreraEstudiante(string nombreCarrera, string carnetEstudiante)
        {
            this.estudianteMySqlData.QuitarCarreraEstudiante(nombreCarrera, carnetEstudiante);
        }

        public void InsertarCarreraEstudiante(int estudianteId, string nombreCarrera)
        {
            this.estudianteMySqlData.InsertarCarreraEstudiante(estudianteId, nombreCarrera);
        }

        public void EliminarEstudiante(string carne)
        {
            this.estudianteMySqlData.BorrarEstudiante(carne);
        }

        public List<Telefono> ObtenerTelefonosEstudiante(int estudianteId)
        {
            return this.estudianteMySqlData.EjecutarMostrarContactoEstudiante(estudianteId);
        }

        public void EliminarTelefonoEstudiante(int estudianteId, string numeroTelefonico)
        {
            this.estudianteMySqlData.QuitarTelefonoEstudiante(estudianteId, numeroTelefonico);
        }

        public void InsertarTelefonoEstudiante(int estudianteId, string numeroTelefono)
        {
            this.estudianteMySqlData.InsertarTelefonoEstudiante(estudianteId, numeroTelefono);
        }

        public bool ActualizarEstudiante(Estudiante estudiante)
        {
            return this.estudianteMySqlData.ActualizarEstudiante(estudiante);
        }

        public List<Curso> ObtenerTodosLosCursos()
        {
            return this.estudianteMySqlData.EjecutarMostrarCursos();
        }

        public List<Carrera> ObtenerTodasLasCarreras()
        {
            return this.estudianteMySqlData.EjecutarMostrarCarreras();
        }

        public List<Sede> ObtenerTodasLasSedes()
        {
            return this.estudianteMySqlData.EjecutarMostrarSedes();
        }

        public List<Beca> ObtenerTodasLasBecas()
        {
            return this.estudianteMySqlData.EjecutarMostrarBecas();
        }

        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            return this.estudianteMySqlData.EjecutarMostrarEstudiantes();
        }
    }
}
