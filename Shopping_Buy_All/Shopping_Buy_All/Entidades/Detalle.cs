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
        
        public Detalle(int codProducto,int cantidad,float precio)
        {
            CodProducto = codProducto;
            Cantidad = cantidad;
            Precio = precio;
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
        public float PrecioDetalle
        {
            get => Precio;
            set => Precio = value;
        }
    }
}
