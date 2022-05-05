using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class TipoDocumento
    {
        private string Nombre;
        private int Borrado = 0;

        public string NombreTipDoc
        {
            get => Nombre;
            set => Nombre = value;
        }
        public int borradoTipDoc
        {
            get => Borrado;
            set => Borrado = value;
        }
        public TipoDocumento(string nombre, int borrado)
        {
            Nombre = nombre;
            Borrado = borrado;
        }
    }
}
