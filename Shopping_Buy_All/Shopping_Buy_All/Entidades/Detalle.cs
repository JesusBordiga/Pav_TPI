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
        
        
        public Detalle(int CodProducto,int Cantidad,float Precio,string Nombre)
        {
            CodProducto = CodProducto;
            Cantidad=Cantidad;
            Precio=Precio;
            Nombre=Nombre;


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
