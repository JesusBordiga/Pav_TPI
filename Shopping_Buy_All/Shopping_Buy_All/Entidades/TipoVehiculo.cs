using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class TipoVehiculo
    {
        public string Nombre { get; set; }
        public int Borrado { get; set; } = 0;
        public string NombreTipoVehiculo { get; internal set; }
        public int CodigoTipoVehiculo { get; internal set; }

        public TipoVehiculo()
        { }
        public TipoVehiculo(string nombre, int borrado)
        {
            this.Nombre = nombre;
            this.Borrado = borrado;
        }
        public TipoVehiculo(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
