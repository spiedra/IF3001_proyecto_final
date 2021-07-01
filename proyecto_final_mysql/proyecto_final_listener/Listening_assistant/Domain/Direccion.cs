using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listening_assistant.Domain
{
    class Direccion
    {
        public Direccion(int idDireccion, string detalles, int isDeleted)
        {
            this.IdDireccion = idDireccion;
            this.Detalles = detalles;
            this.IsDeleted = IsDeleted;
        }

        public int IdDireccion { get; set; }
        public string Detalles { get; set; }
        public int IsDeleted { get; set; }
    }
}
