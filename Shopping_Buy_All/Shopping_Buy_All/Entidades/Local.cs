using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Local
    {
        public string NombreLocal { get; set; }
        public int TipoComercio { get; set; }
        public int Borrado { get; set; } = 0;


        public Local( string nombreLocal, int tipoComercio, int borrado)
        {
            this.NombreLocal = nombreLocal; 
            this.TipoComercio = tipoComercio;   
            this.Borrado = borrado;
        }

        public Local(string nombreLocal, int tipoComercio)
        {
            this.NombreLocal = nombreLocal;
            this.TipoComercio = tipoComercio;
        }

        public Local()
        {

        }
    }
}
