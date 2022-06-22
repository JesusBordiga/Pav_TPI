using Shopping_Buy_All.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping_Buy_All.ABMS;

namespace Shopping_Buy_All.ABMS.AccesoADatos
{
    public class AD_Rubros
    {
        AccesoADatos _DB = new AccesoADatos();

        public DataTable _Rpt_Rubros()
        {
            string consulta = "SELECT * FROM Rubros WHERE Borrado = 0 ORDER BY CodigoRubro";
            return _DB.Consultar(consulta);
        }
        public DataTable _Rpt_Rubros(string letra)
        {
            string consulta = "SELECT * FROM Rubros WHERE Borrado = 0 and Nombre LIKE '" + letra.Trim() + "%' ORDER BY Nombre";
            return _DB.Consultar(consulta);

        }



    }
}
