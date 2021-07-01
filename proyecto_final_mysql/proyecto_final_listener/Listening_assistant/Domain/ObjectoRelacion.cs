using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listening_assistant.Domain
{
    class ObjectoRelacion
    {
        public ObjectoRelacion(int id1, int id2, int isDeleted)
        {
            this.Id1 = id1;
            this.Id2 = id2;
            this.IsDeleted = isDeleted;
        }

        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public int IsDeleted { get; set; }
    }
}
