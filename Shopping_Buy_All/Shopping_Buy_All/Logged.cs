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
using Shopping_Buy_All.ABM_Estado_Civil;
using Shopping_Buy_All.ABM_Sexo;
using Shopping_Buy_All.ABM_Tipo_Documento;
using Shopping_Buy_All.ABM_Tipo_Tarjeta;

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
        // ABM Estado Civil
        private void altaDeEstadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoCivil_Load escivLoad = new EstadoCivil_Load();
            escivLoad.ShowDialog();
        }
        private void bajaDeEstadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoCivil_Delete estadoCivil_Delete = new EstadoCivil_Delete();
            estadoCivil_Delete.ShowDialog();
        }

        private void modificacionDeEstadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoCivil_Modify estadoCivil_Modify = new EstadoCivil_Modify();
            estadoCivil_Modify.ShowDialog();
        }
        // ABM Sexo
        private void altaDeSexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sexo_Load sexoLoad = new Sexo_Load();
            sexoLoad.ShowDialog();
        }
        private void bajaDeSexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sexo_Delete sexo_Delete = new Sexo_Delete();
            sexo_Delete.ShowDialog();
        }

        private void modificacionDeSexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sexo_Modify sexo_Modify = new Sexo_Modify();
            sexo_Modify.ShowDialog();
        }
        // ABM Tipo Documento
        private void altaDeTipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDoc_Load tipoDoc_Load = new TipoDoc_Load();
            tipoDoc_Load.ShowDialog();
        }
        private void bajaDeTipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDoc_Delete tipoDoc_Delete = new TipoDoc_Delete();
            tipoDoc_Delete.ShowDialog();
        }

        private void modificacionDeTipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDoc_Modify tipoDoc_Modify = new TipoDoc_Modify();
            tipoDoc_Modify.ShowDialog();
        }
        // ABM Tipo Tarjeta
        private void altaDeTipoDeTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoTarjeta_Load tipoTarjeta_Load = new TipoTarjeta_Load();
            tipoTarjeta_Load.ShowDialog();
        }

        private void modificacionDeTipoDeTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoTarjeta_Modify tipoTarjeta_Modify = new TipoTarjeta_Modify();
            tipoTarjeta_Modify.ShowDialog();
        }

        private void bajaDeTipoDeTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoTarjeta_Delete tipoTarjeta_Delete = new TipoTarjeta_Delete();
            tipoTarjeta_Delete.ShowDialog();
        }
    }
}
