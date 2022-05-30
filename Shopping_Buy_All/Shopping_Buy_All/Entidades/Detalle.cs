using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Detalle
    {
        private int CodProducto;
        private int Cantidad;
        private float Precio;
        private string Nombre;
        
        
        public Detalle(int codProducto,int cantidad,float precio,string nombre)
        {
            CodProducto = codProducto;
            Cantidad = cantidad;
            Precio = precio;
            Nombre = nombre;


        }
        public Detalle()
        {

        }
        public int CodigoPorductoDetalle
        {
            get => CodProducto;
            set => CodProducto = value;
        }
        public int CantidadProductoDetalle
        {
            get => Cantidad;
            set => Cantidad= value;
        }
        public string PrecioDetalle
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
