using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Buy_All.Entidades
{
    public class Modelo
    {
        private int CodigoModelo;
        private string NombreModelo;
        private int idMarca;
        private int CodigoTipoAuto;
        private int Borrado;

        public Modelo(int codigoModelo)
        {
            CodigoModelo = codigoModelo;
        }

        public Modelo(string nombreModelo)
        {
            NombreModelo = nombreModelo;
        }
        public Modelo()
        {

        }
        public int CodigoModeloAuto
        {
            get => CodigoModelo;
            set => CodigoModelo = value;
        }
        public string NombreModeloAuto
        {
            get => NombreModelo;
            set => NombreModelo = value;
        }
        public int idMarcaAuto
        {
            get => idMarca;
            set => idMarca = value;
        }
        public int CodBorradoigoTipoAuto
        {
            get => Borrado;
            set => Borrado = value;
        }
    }
}
