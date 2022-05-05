using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class TipoComercio
    {
        public string NombreTipoComercio { get; set; }
        public bool Borrado { get; set; } = false;


        public TipoComercio(string nombreTipoComercio, bool borrado)
        {
            this.NombreTipoComercio = nombreTipoComercio;    
            this.Borrado = borrado;
        }

        public TipoComercio(string nombreTipoComercio)
        {
            this.NombreTipoComercio = nombreTipoComercio;
        }

        public TipoComercio() { }
    }
}
