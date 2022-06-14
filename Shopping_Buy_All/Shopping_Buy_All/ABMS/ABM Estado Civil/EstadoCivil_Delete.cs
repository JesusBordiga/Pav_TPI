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
    public partial class EstadoCivil_Delete : Form
    {
        public EstadoCivil_Delete()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaEC();
        }
        private void cambiarModificador(bool booleano)
        {
            btnECDelete.Visible = booleano;
            btnLimpiar.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            label2.Visible = booleano;
            btnBuscarEC.Visible = booleano;
            txtNombre.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
        }
        private void cargarTablaEC()
        {
            try
            {
                tablaEC.DataSource = AD_EstadoCivil.obtenerDatosEstadoCivil();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudieron obtener los datos de los Estados Civiles");
            }
        }
        private bool busquedaXNombre(string nombre)
        {
            bool resultado = false;
            tablaEC.DataSource = AD_EstadoCivil.buscarEstadoCivil(nombre);
            if (tablaEC.Rows.Count == 1)
            {
                resultado = true;
            }
            return resultado;
        }
        private void buscarEC(string nombre)
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
                    MessageBox.Show("No se encontró el estado civil!", "Error", MessageBoxButtons.OK);
                    limpiarCampos();
                    cargarTablaEC();
                }
            }
            else
            {
                MessageBox.Show("Error al buscar el estado civil! \n Complete el campo por favor!", "Error", MessageBoxButtons.OK);
            }
        }
        private void borrarEC(string nombre)
        {
            AD_EstadoCivil.borrarEstadoCivil(nombre);
        }
        private void btnECDelete_Click(object sender, EventArgs e)
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
                    borrarEC(nombre);
                    MessageBox.Show("Estado civil dado de baja con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaEC();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al dar de baja el estado civil! \n Complete los campos por favor!");
            }
        }
        private void btnBuscarEC_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            buscarEC(nombre);
        }
        private void tablaEC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaEC.Rows[indice];
                string nombre = filaSeleccionada.Cells["NombreEstadoCivil"].Value.ToString();
                buscarEC(nombre);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Seleccione una casilla dentro de la tabla");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cambiarModificador(false);
            cambiarBuscador(true);
            cargarTablaEC();
        }
    }
}