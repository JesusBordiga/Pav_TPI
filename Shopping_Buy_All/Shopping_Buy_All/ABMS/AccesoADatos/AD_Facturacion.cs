﻿using Shopping_Buy_All.Entidades;
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
    public class AD_Facturacion
    {
        private AccesoADatos _DB = new AccesoADatos();

        /// <summary>
        /// obtiene un cliente por un tipo de documento y un nro de documento dado
        /// </summary>
        /// <param name="TipoDocumento"></param>
        /// <param name="NroDocumento"></param>
        /// <returns></returns>
        public DataTable Buscar_Cliente_Documento(string TipoDocumento, string NroDocumento)
        {
            string consulta = "buscarClienteNoBorrado " + TipoDocumento + "," + NroDocumento;
            return _DB.Consultar(consulta);
        }

        /// <summary>
        /// obtiene el numero de factura más alto
        /// </summary>
        /// <returns></returns>
        public DataTable getNroFactura()
        {
            string consulta = "getMaxNroFactura";
            return _DB.Consultar(consulta);
        }

        /// <summary>
        /// obtiene la tarjeta de un cliente dado
        /// </summary>
        /// <param name="tipoDoc"></param>
        /// <param name="nroDoc"></param>
        /// <returns></returns>
        public DataTable getTarjetaCliente(int tipoDoc, string nroDoc)
        {
            string consulta = "getTarjetaClienteFactura " + nroDoc + ", " + tipoDoc.ToString();
            return _DB.Consultar(consulta);
        }

        /// <summary>
        /// carga una nueva factura y su detalle
        /// </summary>
        /// <param name="factura"></param>
        /// <param name="nroFactura"></param>
        /// <returns></returns>
        public bool cargarFactura(Factura factura, int nroFactura)
        {
            bool resultado = false;

            string codLocal = factura.CodigoLocalFactura.ToString();
            string tipDoc = factura.TipoDocumentoFactura.ToString();
            string nroDoc = factura.DocumentoFactura.ToString();
            string nroTarj = factura.NroTarjetaFactura.ToString();
            string fec = factura.FechaCompraFactura.ToShortDateString();
            string consulta = "agregarFactura " + codLocal + ", " + tipDoc + ", " + nroDoc + ", " + nroTarj + ", '" + fec + "'";
            try
            {
                _DB.IniciarTransaccion();
                _DB.ModificarDB(consulta);

                foreach (var detalle in factura.DetallesFactura)
                {
                    string codProd = detalle.CodigoPorductoDetalle.ToString();
                    string cant = detalle.CantidadProductoDetalle.ToString();
                    string prec = detalle.PrecioDetalle.ToString();
                    string consultaDetalle = "agregarDetalleFactura " + nroFactura.ToString() + ", " + codLocal + ", " + codProd + ", " + cant + ", " + prec;
                    _DB.ModificarDB(consultaDetalle);
                }
                _DB.FinalizarTransaccion();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la Base de Datos\nEl error en la base de datos:\n" + ex.Message);
            }
            return resultado;
        }

        /// <summary>
        /// Obtiene las facturas realizadas en un periodo de tiempo dado ordenadas por fecha
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public DataTable _Rpt_Clientes(string inicio, string final)
        {
            string consulta = "select * from ComprasPorCliente where Borrado = 0 and FechaCompra between " + inicio + " and " + final + " order by FechaCompra";
            return _DB.Consultar(consulta);
        }

        /// <summary>
        /// obtiene las facturas emitidas por un local dado ordenadas por nro de factura
        /// </summary>
        /// <param name="local"></param>
        /// <returns></returns>
        public DataTable _Rpt_Clientes(string local)
        {
            string consulta = "select * from ComprasPorCliente where Borrado = 0 and Codigo_Local = " + local + "order by Numero_Factura";
            return _DB.Consultar(consulta);
        }

        /// <summary>
        /// obtiene las facturas ordenadas por nro de factura
        /// </summary>
        /// <returns></returns>
        public DataTable _Rpt_Clientes()
        {
            string consulta = "select * from ComprasPorCliente where Borrado = 0 order by Numero_Factura";
            return _DB.Consultar(consulta);
        }
    }
}
