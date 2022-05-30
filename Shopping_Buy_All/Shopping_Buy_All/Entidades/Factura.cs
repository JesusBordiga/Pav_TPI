using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Factura
    {
        private int CodLocal;
        private int TipoDocumento;
        private int Documento;
        private int NroTarjeta;
        private DateTime FechaCompra;
        
        
        public Factura(int codLocal,int tipoDocumento, int documento, int nroTarjeta, DateTime fechaCompra)
        {
            CodLocal = codLocal;
            TipoDocumento = tipoDocumento;
            Documento = documento;
            NroTarjeta = nroTarjeta;
            FechaCompra = fechaCompra;
        }
        public Factura()
        {

        }
        public int CodigoLocalFactura
        {
            get => CodLocal;
            set => CodLocal = value;
        }
        public int TipoDocumentoFactura
        {
            get => TipoDocumento;
            set => TipoDocumento = value;
        }
        public int DocumentoFactura
        {
            get => Documento;
            set => Documento = value;
        }
        public int NroTarjetaFactura
        {
            get => NroTarjeta;
            set => NroTarjeta = value;
        }
        public DateTime FechaCompraFactura
        {
            get => FechaCompra;
            set => FechaCompra = value;
        }
    }
}
