using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasLocales;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTipoComercio;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoDocumentos;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoSexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
    }
}
