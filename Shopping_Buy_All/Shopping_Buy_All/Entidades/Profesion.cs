using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Profesion
    {
        public string NombreProfesion { get; set; }
        public int Borrado { get; set; } = 0;


        public Profesion(string nombreProfesion, int borrado)
        {
            this.NombreProfesion = nombreProfesion;
            this.Borrado = borrado;
        }

        public Profesion(string nombreProfesion)
        {
            this.NombreProfesion = nombreProfesion;
        }

        public Profesion()
        {

        }
    }
}
