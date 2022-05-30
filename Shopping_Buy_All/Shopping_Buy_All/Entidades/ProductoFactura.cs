using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class ProductoFactura
    {
        private int Codigo;
        private string Nombre;
        private float Precio;
        private int Cantidad;


        public ProductoFactura(int codigo, string nombre, int precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
        public ProductoFactura()
        {

        }
        public int CodigoProducto
        {
            get => Codigo;
            set => Codigo = value;
        }
        public string NombreProducto
        {
            get => Nombre;
            set => Nombre = value;
        }
        public float PrecioProducto
        {
            get => Precio;
            set => Precio = value;
        }
        public int CantidadProducto
        {
            get => Cantidad;
            set => Cantidad= value;
        }
    }
}
