using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Sexo
    {
        private string Nombre;
        private int Borrado = 0;

        public string NombreSexo
        {
            get => Nombre;
            set => Nombre = value;
        }
        public int borradoSexo
        {
            get => Borrado;
            set => Borrado = value;
        }
        public Sexo(string nombre, int borrado)
        {
            Nombre = nombre;
            Borrado = borrado;
        }
    }
}
