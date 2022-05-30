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
    public partial class TipoDoc_Modify : Form
    {
        public TipoDoc_Modify()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaTipDoc();
        }
        private void btnTipDocModify_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreTipDoc.Text.Trim();
            string nombreNuevo = txtNuevoNombre.Text.Trim();
            if (nombreNuevo != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + nombreNuevo + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
                if (result == DialogResult.OK)
                {
                    modificarTipDoc(nombreNuevo, nombreViejo);
                    MessageBox.Show("Tipo de documento modificado con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaTipDoc();
                }
                else
                {
                    txtNombreTipDoc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar el tipo de documento! \n Complete los campos por favor!");
            }
        }
        private void btnBuscarTipDoc_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreTipDoc.Text.Trim();
            buscarTipDoc(nombreViejo);
        }
        private void tablaTipDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaTipDoc.Rows[indice];
                string nombre = filaSeleccionada.Cells["NombreDocumento"].Value.ToString();
                buscarTipDoc(nombre);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Seleccione una casilla de la tabla");
            }
        }
        private void cambiarModificador(bool booleano)
        {
            label4.Visible = booleano;
            txtNuevoNombre.Visible = booleano;
            btnTipDocModify.Visible = booleano;
            btnLimpiar.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            txtNombreTipDoc.Visible = booleano;
            label2.Visible = booleano;
            btnBuscarTipDoc.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNuevoNombre.Text = "";
            txtNombreTipDoc.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cambiarModificador(false);
            cambiarBuscador(true);
            cargarTablaTipDoc();
        }
        private void cargarTablaTipDoc()
        {
            try
            {
                tablaTipDoc.DataSource = AD_TipoDocumento.obtenerDatosTipoDocumento();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudieron obtener los datos de los Tipos de Documento");
            }
        }
        private bool busquedaXNombre(string nombreViejo)
        {
            bool resultado = false;
            tablaTipDoc.DataSource = AD_TipoDocumento.buscarTipoDocumento(nombreViejo);
            if (tablaTipDoc.Rows.Count == 1)
            {
                    resultado = true;
            }
            return resultado;
        }
        private void buscarTipDoc(string nombreViejo)
        {
            if (nombreViejo != "")
            {
                bool resultado = busquedaXNombre(nombreViejo);
                if (resultado)
                {
                    cambiarModificador(true);
                    cambiarBuscador(false);
                    txtNombreTipDoc.Text = nombreViejo;
                }
                else
                {
                    MessageBox.Show("No se encontró el tipo de documento!", "Error", MessageBoxButtons.OK);
                    limpiarCampos();
                    cargarTablaTipDoc();
                }
            }
            else
            {
                MessageBox.Show("Error al buscar el tipo de documento! \n Complete el campo por favor!", "Error", MessageBoxButtons.OK);
            }
        }
        private void modificarTipDoc(string nombreNuevo, string nombreViejo)
        {
            AD_TipoDocumento.modificarTipoDocumento(nombreNuevo, nombreViejo);
        }
    }
}
