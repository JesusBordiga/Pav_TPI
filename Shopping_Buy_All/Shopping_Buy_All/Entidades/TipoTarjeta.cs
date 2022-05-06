using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class TipoTarjeta
    {
        private string Nombre;
        private int Borrado = 0;

        public string NombreTipoTarjeta
        {
            get => Nombre;
            set => Nombre = value;
        }
        public int borradoTipoTarjeta
        {
            get => Borrado;
            set => Borrado = value;
        }
        public TipoTarjeta(string nombre, int borrado)
        {
            Nombre = nombre;
            Borrado = borrado;
        }
    }
}
