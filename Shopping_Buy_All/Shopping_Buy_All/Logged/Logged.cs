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
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesClientes;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesMarcasTarjetas;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesProductos;

namespace Shopping_Buy_All
{
    public partial class btnEstadisticas : Form
    {
        public btnEstadisticas(User usu)
        {
            InitializeComponent();
            LabelBienvenido.Text = "Bienvenido "+ usu.userName;
            CargarUsuarios(usu);
        }
        private void Logged_Load(object sender, EventArgs e)
        {
            btnMenu1.Visible = true;
            panelMenu.Visible = false;
            MenuReportes.Visible = false;
            panelEstadisticas.Visible = false;
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
            MenuReportes.Visible = true;
        }

        private void pictureBoxMenuReportes_Click(object sender, EventArgs e)
        {
            MenuReportes.Visible = false;
            lblVolver.Visible = false;
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            ReporteClientes reporteCllientes = new ReporteClientes();
            reporteCllientes.Show();
        }

        private void btnReporteFactura_Click(object sender, EventArgs e)
        {
            ReporteFacturas reportefacturas = new ReporteFacturas();
            reportefacturas.Show();
        }

        private void btnReportesProductos_Click(object sender, EventArgs e)
        {
            ReporteProductos reporteproductos = new ReporteProductos();
            reporteproductos.Show();
        }

        private void btnReportesVehiculos_Click(object sender, EventArgs e)
        {
            ReporteVehiculos reportevehiculos = new ReporteVehiculos();
            reportevehiculos.Show();
        }

        private void pictureBoxMenuReportes_MouseHover(object sender, EventArgs e)
        {
            lblVolver.Visible = true;
        }

        private void pictureBoxMenuReportes_MouseLeave(object sender, EventArgs e)
        {
            lblVolver.Visible = false;
        }

        private void CargarUsuarios(User usu)
        {
            if (usu.permiso == 0)
            {
                panelUsuarios.Visible = true;
            }
            else
            {
                panelUsuarios.Visible = false;
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            panelEstadisticas.Visible = true;
        }

        private void VolverEstadisticas(object sender, EventArgs e)
        {
            panelEstadisticas.Visible = false;
        }

        private void pictureBox27_MouseEnter(object sender, EventArgs e)
        {
            lblVolverEstadisticas.Visible = false;
        }

        private void pictureBox27_MouseLeave(object sender, EventArgs e)
        {
            lblVolverEstadisticas.Visible = true;
        }
    }
}
