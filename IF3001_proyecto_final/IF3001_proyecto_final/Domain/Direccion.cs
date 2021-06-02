using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF3001_proyecto_final.Domain
{
    class Direccion
    {
        public Direccion(int id, string detalles)
        {
            this.Id = id;
            this.Detalles = detalles;
        }

        public int Id { get; set; }
        public string Detalles { get; set; }
    }
}
