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

        }

        private void modificacionDeLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bajaDeLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaDeTipoComercioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificacionDeTipoComercioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bajaDeTipoComercioToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
