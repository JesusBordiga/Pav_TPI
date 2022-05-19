using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Automovil
    {
        private string Documento;
        private int TipoDocumento;
        private int Modelo;
        private string Patente;
        private int Borrado;


        public Automovil(string documento, string patente, string nombre)
        {
            Documento = documento;
            Patente = patente;
            Modelo = Modelo;
        }

        public Automovil()
        {

        }

        public string DocumentoPropietario
        {
            get => Documento;
            set => Documento = value;
        }
        public int TipoDocumentoPropietario
        {
            get => TipoDocumento;
            set => TipoDocumento = value;
        }
        public string PatenteAutomovil
        {
            get => Patente;
            set => Patente = value;
        }
        public int ModeloAutomovil
        {
            get => Modelo;
            set => Modelo = value;
        }
        public int BorradoAutomovil
        {
            get => Borrado;
            set => Borrado = value;
        }

    }
}






