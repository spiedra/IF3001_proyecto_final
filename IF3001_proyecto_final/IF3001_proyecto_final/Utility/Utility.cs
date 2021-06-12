using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IF3001_proyecto_final.Layouts;

namespace IF3001_proyecto_final.Utility
{
    class Utility
    {
        public static bool IsConnect { get; set; }
        public static bool IsClick { get; set; }

        public static void OpenGestionEstudianteForm()
        {
            GestionEstudianteForm gestionEstudianteForm = new GestionEstudianteForm();
            gestionEstudianteForm.Show();
        }
    }
}
