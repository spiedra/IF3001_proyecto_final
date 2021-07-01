using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listening_assistant.Domain
{
    class Telefono
    {
        public Telefono(int id, string numero, int isDeleted)
        {
            this.Id = id;
            this.Numero = numero;
            this.IsDeleted = isDeleted;
        }

        public int Id { get; set; }
        public string Numero { get; set; }
        public int IsDeleted { get; set; }
    }
}
