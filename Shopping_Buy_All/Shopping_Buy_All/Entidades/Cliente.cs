using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Cliente
    {
        private string Documento;
        private int TipoDocumento;
        private string Apellido;
        private string Nombre;
        private string Calle;
        private int NroCalle;
        private int EstadoCivil;
        private int IdSexo;
        private DateTime FechaNacimiento;
        private int Borrado;
        
        
        public Cliente(string documento,string apellido , string nombre)
        {
            Documento = documento;
            Apellido = apellido;
            Nombre = nombre;
        }
        public Cliente()
        {

        }
        public string DocumentoCliente
        {
            get => Documento;
            set => Documento = value;
        }
        public int TipoDocumentoCliente
        {
            get => TipoDocumento;
            set => TipoDocumento = value;
        }
        public string ApellidoCliente
        {
            get => Apellido;
            set => Apellido = value;
        }
        public string NombreCliente
        {
            get => Nombre;
            set => Nombre = value;
        }
        public int EstadoCivilCliente
        {
            get => EstadoCivil;
            set => EstadoCivil = value;
        }
      
        public int SexoCliente
        {
            get => IdSexo;
            set => IdSexo = value;
        }
        public string CalleCliente
        {
            get => Calle;
            set => Calle = value;
        }
        public int NroCalleCliente
        {
            get => NroCalle;
            set => NroCalle = value;
        }
        public DateTime FechaNacimientoCliente
        {
        get => FechaNacimiento;
        set => FechaNacimiento = value;
        }
        public int BorradoCliente
        {
            get => Borrado;
            set => Borrado = value;
        }
    }
}
