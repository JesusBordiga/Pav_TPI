using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesLocales
{
    public partial class ReporteLocales : Form
    {
        public ReporteLocales()
        {
            InitializeComponent();
        }

        private void ReporteLocales_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
