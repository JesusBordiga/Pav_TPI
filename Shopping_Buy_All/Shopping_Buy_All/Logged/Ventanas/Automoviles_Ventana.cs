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
//using Shopping_Buy_All.ABMS.ABM_Estado_Civil;
//using Shopping_Buy_All.ABMS.
//using Shopping_Buy_All.ABMS.
//using Shopping_Buy_All.ABMS.
//using Shopping_Buy_All.ABMS.
//using Shopping_Buy_All.ABMS.

namespace Shopping_Buy_All
{
    public partial class Vehiculos_Ventana : Form
    {
        public Vehiculos_Ventana()
        {
            InitializeComponent();
        }

        private void btnAltaTipoVehiculo_Click(object sender, EventArgs e)
        {
            VehicleType_Load vehicleType_Load = new VehicleType_Load();
            vehicleType_Load.ShowDialog();
        }

        private void btnModificarTipoVehiculo_Click(object sender, EventArgs e)
        {
            VehicleType_Modify vehicleType_Modify = new VehicleType_Modify();
            vehicleType_Modify.ShowDialog();
        }

        private void btnEliminarTipoVehiculo_Click(object sender, EventArgs e)
        {
            VehicleType_Delete vehicleType_Delete = new VehicleType_Delete();
            vehicleType_Delete.ShowDialog();
        }

        private void btnAltaVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {

        }
    }
}
