using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopping_Buy_All.Entidades;
using Shopping_Buy_All.ABMS.ABM_TipoVehiculo;

namespace Shopping_Buy_All
{
    public partial class MarcaVehiculo_Ventana : Form
    {
        public MarcaVehiculo_Ventana()
        {
            InitializeComponent();
        }

        private void btnAltaVehicleType_Click(object sender, EventArgs e)
        {
            MarcaVehiculo_Load MarcaVeh = new MarcaVehiculo_Load();
            MarcaVeh.ShowDialog();
        }

        private void btnModificarVehicleType_Click(object sender, EventArgs e)
        {
            MarcaVeh_Modify MarcaVeh_Modify = new MarcaVeh_Modify();
            MarcaVeh_Modify.ShowDialog();
        }

        private void btnEliminarVehicleType_Click(object sender, EventArgs e)
        {
            MarcaVeh_Delete marcaVeh_Delete = new MarcaVeh_Delete();
            marcaVeh_Delete.ShowDialog();
        }
    }
}
