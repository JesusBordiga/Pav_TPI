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
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReporteEstadisticasClientes;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion.RecaudacionPorMes;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasRecaudacion;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesLocales;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesRubro;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoSexo;
using Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesTipoDocumentos;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasLocales;
using Shopping_Buy_All.Estadisticas.Ventanas_Estadisticas.EstadisticasTipoComercio;

namespace Shopping_Buy_All
{
    public partial class Logged : Form
    {
        public Logged(User usu)
        {
            InitializeComponent();
            LabelBienvenido.Text = "Bienvenido " + usu.userName;
            CargarUsuarios(usu);

        }
        private void CargarUsuarios(User usu)
        {
            if (usu.permiso == 0)
            {
                panelUsuarios.Visible = false;
                btnAdmin.Visible = true;
            }
            else
            {
                panelUsuarios.Visible = false;
                btnAdmin.Visible = false;
            }
        }
        private void HourTime_Tick(object sender, EventArgs e)
        {
            labelHora.Text = "Hora: " + DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Logged_Load(object sender, EventArgs e)
        {
            btnMenu1.Visible = true;
            panelMenu.Visible = false;
            MenuReportes.Visible = false;
            panelEstadisticas.Visible = false;
            lblVolver.Visible = false;
            lblVolverEstadisticas.Visible = false;
        }
        private void btnClientLoad_Click(object sender, EventArgs e)
        {
            btnMenu1.Visible = false;
            panelMenu.Visible = true;
        }

        //MENU PRINCIPAL

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

        //MENU REPORTES 

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            ReporteClientes reporteClientes = new ReporteClientes();
            reporteClientes.Show();
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
        private void btnMarcaAutomovil_Click(object sender, EventArgs e)
        {
            ReporteMarcasAutomovil reporteMarcasAutomovil = new ReporteMarcasAutomovil();
            reporteMarcasAutomovil.Show();
        }

        private void btnReportesUsuarios_Click(object sender, EventArgs e)
        {
            ReporteUsuarios reporteUsuarios = new ReporteUsuarios();
            reporteUsuarios.Show();
        }

        private void btnReportesLocales_Click(object sender, EventArgs e)
        {
            ReporteLocales reportelocales = new ReporteLocales();
            reportelocales.Show();
        }
        private void btnReportesRubro_Click(object sender, EventArgs e)
        {
            ReporteRubro reporteRubro = new ReporteRubro();
            reporteRubro.Show();
        }
        private void btnReporteAutomovil_Click(object sender, EventArgs e)
        {
            ReporteMarcasAutomovil ventana = new ReporteMarcasAutomovil();
            ventana.Show();
        }

        //ACCIONES DE REPORTE
        private void pictureBoxMenuReportes_MouseHover(object sender, EventArgs e)
        {
            lblVolver.Visible = true;
        }

        private void pictureBoxMenuReportes_MouseLeave(object sender, EventArgs e)
        {
            lblVolver.Visible = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ReporteTipoSexo reporteTipoSexo = new ReporteTipoSexo();
            reporteTipoSexo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReporteTipoDocumentos ventana = new ReporteTipoDocumentos();
            ventana.Show();
        }
        //BOTONES REPORTES
        private void btnReportes_Click(object sender, EventArgs e)
        {
            MenuReportes.Visible = true;
        }

        private void VolverReportes_Click(object sender, EventArgs e)
        {
            MenuReportes.Visible = false;
            lblVolver.Visible = false;
        }

        //MENU DE ESTADISTICAS
        private void btnmarcatarjetaReport_Click(object sender, EventArgs e)
        {
            ReporteMarcaTarjeta reportemarcatarjeta = new ReporteMarcaTarjeta();
            reportemarcatarjeta.Show();
        }

        private void EstadisticasClientes_Click(object sender, EventArgs e)
        {
            ReporteEstadisticasClientes reporteEstadisticasClientes = new ReporteEstadisticasClientes();
            reporteEstadisticasClientes.Show();
        }
        private void btnFacturaEstadisticas_Click(object sender, EventArgs e)
        {
            ReporteEstadisticasFacturacion reporteEstadisticasFacturacion = new ReporteEstadisticasFacturacion();
            reporteEstadisticasFacturacion.Show();
        }
        private void btnEstadisticasRecaudacion_Click(object sender, EventArgs e)
        {
            VentanaRecaudacion ventanaRecaudacion = new VentanaRecaudacion();
            ventanaRecaudacion.Show();
        }
        private void btnEstadsiticasLocales(object sender, EventArgs e)
        {
            EstadisticaLocalesPorRubro ventana = new EstadisticaLocalesPorRubro();
            ventana.Show();
        }
        private void btnEstadsiticasRubros(object sender, EventArgs e)
        {
            EstadisticasTipoComercio ventana = new EstadisticasTipoComercio();
            ventana.Show();
        }
        private void btnMarcasTarjeta_Click(object sender, EventArgs e)
        {
            VentanaEstadisticasTarjetas ventana = new VentanaEstadisticasTarjetas();
            ventana.Show();
        }
        //ACCIONES DE ESTADISTICAS
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            panelEstadisticas.Visible = true;
        }

        private void pictureBox27_MouseLeave(object sender, EventArgs e)
        {
            lblVolverEstadisticas.Visible = true;
        }
        private void pictureBox27_MouseEnter(object sender, EventArgs e)
        {
            lblVolverEstadisticas.Visible = false;
        }
        //BOTONES ESTADISTICAS
        private void VolverEstadisticas(object sender, EventArgs e)
        {
            panelEstadisticas.Visible = false;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panelUsuarios.Visible = true;
            btnAdmin.Visible = false;
        }

        private void btnAdmin2_Click(object sender, EventArgs e)
        {
            btnAdmin.Visible = true;
            panelUsuarios.Visible = false;
        }

    }
}

