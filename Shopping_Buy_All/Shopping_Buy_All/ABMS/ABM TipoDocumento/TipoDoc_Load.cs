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

namespace Shopping_Buy_All.ABM_Tipo_Documento
{
    public partial class TipoDoc_Load : Form
    {
        public TipoDoc_Load()
        {
            InitializeComponent();
            CargarTablaTipoDocumento();
        }
        private void limpiarCampos()
        {
            txtTipoDoc.Text = "";
        }
        private void CargarTablaTipoDocumento()
        {
            try
            {
                tablaTipDoc.DataSource = AD_TipoDocumento.obtenerDatosTipoDocumento();
            }
            catch (Exception)
            {

                MessageBox.Show("Error! No se pudieron obtener los tipos de documento");
            }
        }
        private bool AgregarTipoDocumento(TipoDocumento tipDoc)
        {
            bool resultado = AD_TipoDocumento.agregarTipoDocumento(tipDoc);
            return resultado;
        }
        private void btnSexoLoad_Click_1(object sender, EventArgs e)
        {
            TipoDocumento tipDoc = new TipoDocumento(txtTipoDoc.Text.Trim(), 0);
            bool resultado = AgregarTipoDocumento(tipDoc);
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + tipDoc.NombreTipDoc + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Tipo de Documento agregado con éxito!");
                    limpiarCampos();
                    CargarTablaTipoDocumento();
                }
                else
                {
                    txtTipoDoc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el tipo de documento! \n Complete los campos por favor!");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
