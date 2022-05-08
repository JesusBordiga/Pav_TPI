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
    public  partial class Logged : Form
    {
        public Logged(User usu)
        {
            InitializeComponent();
            LabelBienvenido.Text = "Bienvenido "+ usu.userName;
        }

        private void Logged_Load(object sender, EventArgs e)
        {
            btnMenu1.Visible = true;
            panel.Visible = true;

        }

        private void btnClientLoad_Click(object sender, EventArgs e)
        {
            btnMenu1.Visible = false;
            panel.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes_Ventana client_ventana = new Clientes_Ventana();
            client_ventana.Show();
        }

        private void btnProfesiones_Click(object sender, EventArgs e)
        {
            Profesiones_Ventana prof_ventana = new Profesiones_Ventana();
            prof_ventana.Show();
        }

        private void btnLocales_Click(object sender, EventArgs e)
        {
            Locales_Ventana loc_ventana = new Locales_Ventana();
            loc_ventana.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos_Ventana prod_ventana = new Productos_Ventana();
            prod_ventana.Show();
        }

        private void btnMarcasTarjetas_Click(object sender, EventArgs e)
        {
            MarcaTarjeta_Ventana marc_ventana = new MarcaTarjeta_Ventana();
            marc_ventana.Show();
        }

        private void btnAutomoviles_Click(object sender, EventArgs e)
        {
            Automoviles_Ventana auto_ventana = new Automoviles_Ventana();
            auto_ventana.Show();
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            btnMenu1.Visible = true;
            panel.Visible = true;
        }
    }
}
