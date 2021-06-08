using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IF3001_proyecto_final.Data;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Business
{
    class CarreraSqlServerBusiness
    {
        private CarreraSqlServerData carreraSqlServerData;
        public CarreraSqlServerBusiness()
        {
            carreraSqlServerData = new CarreraSqlServerData();
        }

        public List<Carrera> ObtenerTodasLasCarreras()
        {
            return this.carreraSqlServerData.ObtenerTodasLasCarreras();
        }
    }
}
