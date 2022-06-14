using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Tarjeta
    {
        private int TipoDocumento;
        private string NroDocumento;
        private string NroTarjeta;
        private int IdMarca;
        private int IdTipo;
        private int Borrado;

        public Tarjeta(int tipoDoc, string nroDoc, string nroTar, int idMark, int idType)
        {
            TipoDocumento = tipoDoc;
            NroDocumento = nroDoc;
            NroTarjeta = nroTar;
            IdMarca = idMark;
            IdTipo = idType;
        }
        public Tarjeta()
        {

        }
        public int TipoDocumentoTarjeta
        {
            get => TipoDocumento;
            set => TipoDocumento = value;
        }
        public string NroDocumentoTarjeta
        {
            get => NroDocumento;
            set => NroDocumento = value;
        }
        public string NroTarjetaCliente

        {
            get => NroTarjeta;
            set => NroTarjeta = value;
        }
        public int IdMarcaTarjeta
        {
            get => IdMarca;
            set => IdMarca = value;
        }
        public int IdTipoTarjeta
        {
            get => IdTipo;
            set => IdTipo = value;
        }
        public int BorradoTarjeta
        {
            get => Borrado;
            set => Borrado = value;
        }
    }
}
