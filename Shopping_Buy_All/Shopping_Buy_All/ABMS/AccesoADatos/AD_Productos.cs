using Shopping_Buy_All.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping_Buy_All.ABMS;
using System.Windows.Forms;

namespace Shopping_Buy_All.ABMS.AccesoADatos
{
    public class AD_Productos
    {
        AccesoADatos _DB = new AccesoADatos();

        //PRODUCT LOAD
        public void Cargar_Producto(Producto product)
        {
            string consulta = "agregarProducto '" + product.NombreProducto + "', " + product.PrecioProducto.ToString();
            _DB.ModificarDB(consulta);
        }
        public DataTable CargarTablaProductos()
        {
            string consulta = "getProductoNoBorrado";
            return _DB.Consultar(consulta);
        }

        //PRODUCT MODIFY
        public DataTable Buscar_Producto(string Code)
        {
            string consulta = "BuscarProductoNoBorrado " + Code;
            return _DB.Consultar(consulta);
        }
        public void ModificarProducto(Producto prod)
        {
            string consulta = "ModificarProducto'" + prod.NombreProducto + "', " + prod.PrecioProducto + ", " + prod.CodigoProducto.ToString();
            _DB.ModificarDB(consulta);
        }

        //PRODUCT DELETE
        public void BorrarProducto(int Codigo, int Borrado)
        {
            string consulta = "BorrarProducto " + Codigo + ", " + Borrado;
            _DB.ModificarDB(consulta);
        }
        
        //REPORTES PRODUCTOS
        public DataTable _Rpt_Productos()
        {
            string consulta = "SELECT * FROM Productos WHERE Borrado = 0 ORDER BY Codigo_Producto";
            return _DB.Consultar(consulta);
        }
        public DataTable _Rpt_Productos(string letra)
        {
            string consulta = "SELECT * FROM Productos WHERE Borrado = 0 and NombreProducto LIKE '" + letra.Trim() + "%' ORDER BY NombreProducto";
            return _DB.Consultar(consulta);

        }
        public DataTable _Rpt_Productos(string inicio, string final)
        {
            string consulta = "SELECT * FROM Productos WHERE Borrado = 0 and Precio BETWEEN " + inicio + " AND " + final + " ORDER BY Precio";
            return _DB.Consultar(consulta);
        }
    }
}
