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
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All.ABM_Estado_Civil
{
    public partial class EstadoCivil_Modify : Form
    {
        public EstadoCivil_Modify()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaEstadoCivil();
        }
        private void tablaEstadoCivil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaEstadoCivil.Rows[indice];
            string nombre = filaSeleccionada.Cells["NombreEstadoCivil"].Value.ToString();
            buscarEstadoCivil(nombre);
        }
        private void btnEstadoCivilModify_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreEC.Text.Trim();
            string nombreNuevo = txtNuevoNombre.Text.Trim();
            if (nombreNuevo != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + nombreNuevo + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
                if (result == DialogResult.OK)
                {
                    modificarEstadoCivil(nombreNuevo, nombreViejo);
                    MessageBox.Show("Estado Civil modificado con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaEstadoCivil();
                }
                else
                {
                    txtNombreEC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar el Estado Civil! \n Complete los campos por favor!");
            }
        }
        private void btnBuscarEstadoCivil_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreEC.Text.Trim();
            buscarEstadoCivil(nombreViejo);
        }
        private void cambiarModificador(bool booleano)
        {
            label4.Visible = booleano;
            txtNuevoNombre.Visible = booleano;
            btnEstadoCivilModify.Visible = booleano;
            btnLimpiar.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            txtNombreEC.Visible = booleano;
            label2.Visible = booleano;
            btnBuscarEstadoCivil.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNuevoNombre.Text = "";
            txtNombreEC.Text = "";
        }
        private void cargarTablaEstadoCivil()
        {
            try
            {
                tablaEstadoCivil.DataSource = AD_EstadoCivil.obtenerDatosEstadoCivil();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudieron obtener los datos de los Estados Civiles");
            }
        }
        private bool busquedaXNombre(string nombreViejo)
        {
            bool resultado = false;
            tablaEstadoCivil.DataSource = AD_EstadoCivil.buscarEstadoCivil(nombreViejo);
            if (tablaEstadoCivil.Rows.Count == 1)
            {
                resultado = true;
            }
            return resultado;
        }
        private void buscarEstadoCivil(string nombreViejo)
        {
            if (nombreViejo != "")
            {
                bool resultado = busquedaXNombre(nombreViejo);
                if (resultado)
                {
                    cambiarModificador(true);
                    cambiarBuscador(false);
                    txtNombreEC.Text = nombreViejo;
                }
                else
                {
                    MessageBox.Show("No se encontró el Estado Civil!", "Error", MessageBoxButtons.OK);
                    limpiarCampos();
                    cargarTablaEstadoCivil();
                }
            }
            else
            {
                MessageBox.Show("Error al buscar el Estado Civil! \n Complete el campo por favor!", "Error", MessageBoxButtons.OK);
            }
        }
        private void modificarEstadoCivil(string nombreNuevo, string nombreViejo)
        {
            AD_EstadoCivil.modificarEstadoCivil(nombreNuevo, nombreViejo);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cambiarModificador(false);
            cambiarBuscador(true);
            cargarTablaEstadoCivil();
        }
    }
}
