using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listening_assistant.Domain
{
    class Auditoria
    {
        public Auditoria(int id, string nombreTabla, string nombreProcedimiento)
        {
            this.Id = id;
            this.NombreTabla = nombreTabla;
            this.NombreProcedimiento = nombreProcedimiento;
        }

        public int Id { get; set; }
        public string NombreTabla { get; set; }
        public string NombreProcedimiento { get; set; }
    }
}
