using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF3001_proyecto_final.Domain
{
    class Curso
    {
        public Curso(int id, string nombre, int creditos)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Creditos = creditos;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
    }
}
