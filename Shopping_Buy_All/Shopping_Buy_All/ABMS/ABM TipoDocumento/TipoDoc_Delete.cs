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
    public partial class TipoDoc_Delete : Form
    {
        public TipoDoc_Delete()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaTipDoc();
        }
        private void btnBuscarTipDoc_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            buscarTipDoc(nombre);
        }
        private void btnTipDocDelete_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (nombre != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + nombre + "|");
                string titulo = "Información de Baja";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
                if (result == DialogResult.OK)
                {
                    borrarTipDoc(nombre);
                    MessageBox.Show("Tipo de documento dado de baja con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaTipDoc();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al dar de baja el tipo de documento! \n Complete los campos por favor!");
            }
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
                MessageBox.Show("Error! Seleccione una casilla dentro de la tabla!");
            }
        }
        private void cambiarModificador(bool booleano)
        {
            btnTipDocDelete.Visible = booleano;
            btnLimpiar.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            label2.Visible = booleano;
            btnBuscarTipDoc.Visible = booleano;
            txtNombre.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
        }
        private void cargarTablaTipDoc()
        {
            try
            {
                tablaTipDoc.DataSource = AD_TipoDocumento.obtenerDatosTipoDocumento();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Otener Datos del Cliente");
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
        private void buscarTipDoc(string nombre)
        {
            if (nombre != "")
            {
                bool resultado = busquedaXNombre(nombre);
                if (resultado)
                {
                    cambiarModificador(true);
                    cambiarBuscador(false);
                    txtNombre.Text = nombre;
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
        private void borrarTipDoc(string nombre)
        {
            AD_TipoDocumento.borrarTipoDocumento(nombre);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cambiarModificador(false);
            cambiarBuscador(true);
            cargarTablaTipDoc();
        }
    }
}
