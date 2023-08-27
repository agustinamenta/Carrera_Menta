using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras_Menta.Entidades
{
    internal class Carrera
    {
        public int IdCarrera { get; set; }
        public string NombreCarrera { get; set; }

        public Carrera(int idCarrera, string nombreCarrera)
        {
            IdCarrera = idCarrera;
            NombreCarrera = nombreCarrera;
        }
    }
}
