using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF3001_proyecto_final.Domain
{
    class Beca
    {
        public Beca(int id, int tipoBeca)
        {
            this.Id = id;
            this.TipoBeca = tipoBeca;
        }

        public int Id { get; set; }
        public int TipoBeca { get; set; }
    }    
}
