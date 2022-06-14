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

namespace Shopping_Buy_All.ABM_Estado_Civil
{
    public partial class EstadoCivil_Load : Form
    {
        public EstadoCivil_Load()
        {
            InitializeComponent();
            CargarTablaEsCiv();
        }
        private void limpiarCampos()
        {
            txtNombreEC.Text = "";
        }
        private void CargarTablaEsCiv()
        {
            try
            {
                tablaEsCiv.DataSource = AD_EstadoCivil.obtenerDatosEstadoCivil();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudieron obtener los datos de los Estados Civiles");
            }
        }
        private void btnECLoad_Click(object sender, EventArgs e)
        {
            EstadoCivil esCiv = new EstadoCivil(txtNombreEC.Text.Trim(), 0);
            bool resultado = Agregar_EstadoCivil(esCiv);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + esCiv.NombreEc + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Estado Civil agregado con éxito!");
                    limpiarCampos();
                    CargarTablaEsCiv();
                }
                else
                {
                    txtNombreEC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Estado Civil! \n Complete los campos por favor!");
            }
        }
        private bool Agregar_EstadoCivil(EstadoCivil esCiv)
        {
            bool resultado = AD_EstadoCivil.agregarEstadoCivil(esCiv);
            return resultado;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
