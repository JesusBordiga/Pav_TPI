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
using Shopping_Buy_All.ABM_Sexo;

namespace Shopping_Buy_All
{
    public partial class Clientes_Ventana : Form
    {
        public Clientes_Ventana()
        {
            InitializeComponent();
        }
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Client_Load cargaCliente = new Client_Load();
            cargaCliente.ShowDialog();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Client_Modify modificarCliente = new Client_Modify();
            modificarCliente.ShowDialog();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Client_Delete deleteCliente = new Client_Delete();
            deleteCliente.ShowDialog();
        }

        private void btnTipoSexo_Click(object sender, EventArgs e)
        {
            TipoSexo_Ventana TipoSexo = new TipoSexo_Ventana();
            TipoSexo.ShowDialog();
        }

        private void btnEstadoCivil_Click(object sender, EventArgs e)
        {
            EstadoCivil_Ventana EstadoCivil = new EstadoCivil_Ventana();
            EstadoCivil.ShowDialog();
        }

        private void btnTipoDocumento_Click(object sender, EventArgs e)
        {
            TipoDocumento_Ventana TipoDocumento = new TipoDocumento_Ventana();
            TipoDocumento.ShowDialog();
        }
    }
}
