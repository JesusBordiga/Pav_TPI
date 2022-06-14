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
namespace Shopping_Buy_All
{
    public partial class Logged : Form
    {
        public Logged(User usu)
        {
            InitializeComponent();
            LabelBienvenido.Text = "Bienvenido "+ usu.userName;
        }
        private void Logged_Load(object sender, EventArgs e)
        {
            btnMenu1.Visible = true;
            panelMenu.Visible = false;

        }
        private void btnClientLoad_Click(object sender, EventArgs e)
        {
            btnMenu1.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnMenu2_Click(object sender, EventArgs e)
        {
            btnMenu1.Visible = true;
            panelMenu.Visible = false;
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes_Ventana client_ventana = new Clientes_Ventana();
            client_ventana.Show();
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
        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos_Ventana auto_ventana = new Vehiculos_Ventana();
            auto_ventana.Show();
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios_Ventana Usuarios = new Usuarios_Ventana();
            Usuarios.Show();
        }
        private void HourTime_Tick(object sender, EventArgs e)
        {
            labelHora.Text = "Hora: " + DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnProfesiones_Click(object sender, EventArgs e)
        {
            Profesiones_Ventana profesiones_Ventana = new Profesiones_Ventana();
            profesiones_Ventana.Show();
        }

        private void buttonFacturacion_Click(object sender, EventArgs e)
        {
            Facturacion_Ventana facturacion_ventana = new Facturacion_Ventana();
            facturacion_ventana.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes_Ventana reportes_ventana = new Reportes_Ventana();
            reportes_ventana.Show();
        }
    }
}
