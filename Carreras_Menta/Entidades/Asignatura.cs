using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras_Menta.Entidades
{
    internal class Asignatura
    {
        public int IdAsignatura { get; set; }
        public string NombreAsignatura { get; set; }

        public Asignatura(int idAsignatura, string nombreAsignatura)
        {
            IdAsignatura = idAsignatura;
            NombreAsignatura = nombreAsignatura;
        }


        public override string ToString()
        {
           return NombreAsignatura;
        }
    }
}
