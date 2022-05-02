using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Producto
    {
        private int Codigo;
        private string Nombre;
        private float Precio;


        public Producto(int codigo, string nombre, int precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }
        public Producto()
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
    }
}
