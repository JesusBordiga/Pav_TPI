using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Client
    {
        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Altura { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string FechaNacimiento { get; set; }
        public string EstadoClienteBand { get; set; }
    }
}
