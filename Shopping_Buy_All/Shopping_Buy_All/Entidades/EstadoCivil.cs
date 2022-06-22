using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class EstadoCivil
    {
        private string Nombre;
        private int Borrado = 0;

        public string NombreEc
        {
            get => Nombre;
            set => Nombre = value;
        }
        public int borrarEC
        {
            get => Borrado;
            set => Borrado = value;
        }
        public EstadoCivil(string nombre, int borrado)
        {
            Nombre = nombre;
            Borrado = borrado;
        }
    }

}
