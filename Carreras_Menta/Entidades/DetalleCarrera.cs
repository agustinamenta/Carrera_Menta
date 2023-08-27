using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras_Menta.Entidades
{
    internal class DetalleCarrera
    {
        public int AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public string Materia { get; set; }

        public DetalleCarrera(int anioCursado, int cuatrimestre, string materia)
        {
            AnioCursado = anioCursado;
            Cuatrimestre = cuatrimestre;
            Materia = materia;
        }
    }
}
