using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Shopping_Buy_All.Entidades;
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All.ABM_Tipo_Tarjeta
{
    public partial class TipoTarjeta_Load : Form
    {
        public TipoTarjeta_Load()
        {
            InitializeComponent();
            CargarTablaTipoTarjeta();
        }
        private void limpiarCampos()
        {
            txtNombreTdT.Text = "";
        }
        private void CargarTablaTipoTarjeta()
        {
            try
            {
                tablaTipoTarjeta.DataSource = AD_TipoTarjeta.obtenerDatosTipoTarjeta();
            }
            catch (Exception)
            {

                MessageBox.Show("Error! No se pudieron obtener los datos de los tipos de tarjeta");
            }
        }
        private bool Agregar_TipoTarjeta(TipoTarjeta tipoTarjeta)
        {
            bool resultado = AD_TipoTarjeta.agregarTipoTarjeta(tipoTarjeta);
            return resultado;
        }
        private void btnTipoTarjetaLoad_Click(object sender, EventArgs e)
        {
            TipoTarjeta tipoTarjeta = new TipoTarjeta(txtNombreTdT.Text.Trim(), 0);
            bool resultado = Agregar_TipoTarjeta(tipoTarjeta);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + tipoTarjeta.NombreTipoTarjeta + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Tipo de Tarjeta agregado con éxito!");
                    limpiarCampos();
                    CargarTablaTipoTarjeta();
                }
                else
                {
                    txtNombreTdT.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Tipo de Tarjeta! \n Complete los campos por favor!");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
