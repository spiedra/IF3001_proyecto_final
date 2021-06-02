using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF3001_proyecto_final.Domain
{
    class Telefono
    {
        public Telefono(int id, string numero)
        {
            this.Id = id;
            this.Numero = numero;
        }

        public int Id { get; set; }
        public string Numero { get; set; }
    }
}
