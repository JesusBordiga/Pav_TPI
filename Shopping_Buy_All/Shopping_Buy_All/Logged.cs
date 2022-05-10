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

        private void profesionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaDeProfesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesiones_Load load = new Profesiones_Load();
            load.ShowDialog();
        }

        private void bajaDeProfesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesiones_Delete load = new Profesiones_Delete();
            load.ShowDialog();
        }

        private void modificacionDeProfesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesiones_Modify load = new Profesiones_Modify();
            load.ShowDialog();
        }

        private void altaModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelo_Load load = new Modelo_Load();
            load.ShowDialog();
        }

        private void bajaModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelo_Delete load = new Modelo_Delete();
            load.ShowDialog();
        }

        private void modificacionModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelo_Modify load = new Modelo_Modify();
            load.ShowDialog();
        }
    }
}
