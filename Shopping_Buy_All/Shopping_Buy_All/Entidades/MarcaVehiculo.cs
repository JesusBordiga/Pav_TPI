using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class MarcaVehiculo
    {
        private string Marca;
        private int Borrado;


        public MarcaVehiculo(string marca)
        {

            Marca = marca;

        }
        public MarcaVehiculo()
        {

        }
        public string MarcaVeh
        {
            get => Marca;
            set => Marca = value;
        }
        public int BorradoMarcaVeh
        {
            get => Borrado;
            set => Borrado = value;
        }
    }
}