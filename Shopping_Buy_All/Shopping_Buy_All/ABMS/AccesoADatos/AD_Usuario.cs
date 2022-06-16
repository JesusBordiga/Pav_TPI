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
    public class AD_Usuario
    {
        private AccesoADatos _DB = new AccesoADatos();


        /// <summary>
        /// Obtiene los usuarios dentro de un rango de IDs
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public DataTable _Rpt_Usuarios(int min, int max)
        {
            string consulta = "getUsuariosPorRangoID " + min.ToString() + "," + max.ToString();
            return _DB.Consultar(consulta);
        }

        /// <summary>
        /// obtiene todos los usuarios
        /// </summary>
        /// <returns></returns>
        public DataTable _Rpt_Usuarios()
        {
            string consulta = "getUsuariosNoBorrados";
            return _DB.Consultar(consulta);
        }

        /// <summary>
        /// Obtiene los usuarios que comienzan con una letra
        /// </summary>
        /// <param name="letr"></param>
        /// <returns></returns>
        public DataTable _Rpt_Usuarios(string letr)
        {
            string consulta = "getUsuariosPorLetra " + letr;
            return _DB.Consultar(consulta);
        }

        //USUARIO LOAD

        //USUARIO MODIFY

        //USUARIO DELETE
    }
}
