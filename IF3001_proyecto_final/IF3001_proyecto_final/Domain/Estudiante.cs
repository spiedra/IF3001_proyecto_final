using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF3001_proyecto_final.Domain
{
    class Estudiante
    {
        public Estudiante()
        {

        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Promedio { get; set; }
        public string Carnet { get; set; }
    }
}
