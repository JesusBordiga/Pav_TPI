using System;
using Shopping_Buy_All.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopping_Buy_All.Productos;
using Shopping_Buy_All.ABMS.ABM_TipoVehiculo;
using Shopping_Buy_All.ABMS.ABM_Vehiculos;

namespace Shopping_Buy_All
{
    public partial class Logged : Form
    {
        public Logged(User usu)
        {
            InitializeComponent();
            LabelBienvenido.Text = "Bienvenido \n"+ usu.userName;
        }

        private void Logged_Load(object sender, EventArgs e)
        {
        }

        private void altaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Client_Load load = new Client_Load();
            load.ShowDialog();
        }

        private void modificacionDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_Modify modify = new Client_Modify();
            modify.ShowDialog();
        }

        private void bajaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_Delete delete = new Client_Delete();
            delete.ShowDialog();
        }

        private void altaLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Local_Load local = new Local_Load();
            local.ShowDialog();
        }

        private void modificacionDeLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Local_Modify local_Modify = new Local_Modify();
            local_Modify.ShowDialog();
        }

        private void bajaDeLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Local_Delete local_Delete = new Local_Delete();
            local_Delete.ShowDialog();
        }

        private void altaDeTipoComercioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoComercio_Load loadTipoComercio = new TipoComercio_Load();
            loadTipoComercio.ShowDialog();
        }

        private void modificacionDeTipoComercioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoComercio_Modify modifyTipoComercio = new TipoComercio_Modify();
            modifyTipoComercio.ShowDialog();
        }

        private void bajaDeTipoComercioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoComercio_Delete delTipoComercio = new TipoComercio_Delete();
            delTipoComercio.ShowDialog();
        }

        private void altaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Load loadp = new Product_Load();
            loadp.ShowDialog();
        }

        private void modificaciónProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Modify modifyp = new Product_Modify();
            modifyp.ShowDialog();
        }

        private void bajaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Delete deletep = new Product_Delete();
            deletep.ShowDialog();
        }

        private void altaTipoDeAutomovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleType_Load loadTV = new VehicleType_Load();
            loadTV.ShowDialog();
        }

        private void modificacionTipoDeAutomovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleType_Modify modify = new VehicleType_Modify();
            modify.ShowDialog();
        }

        private void bajaTipoDeAutomovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleType_Delete delete = new VehicleType_Delete();
            delete.ShowDialog();
        }

        private void altaAutomovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle_Load LoadA = new Vehicle_Load();
            LoadA.ShowDialog();
        }

        private void modificacionAutomovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle_Modify modify = new Vehicle_Modify ();
            modify.ShowDialog();
        }

        private void bajaAutomovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle_Delete delete = new Vehicle_Delete ();          
            delete. ShowDialog();
        }
    }
}
