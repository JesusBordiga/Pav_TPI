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

namespace Shopping_Buy_All.ABM_Tipo_Tarjeta
{
    public partial class TipoTarjeta_Delete : Form
    {
        public TipoTarjeta_Delete()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaTipoTarjeta();
        }
        private void cambiarModificador(bool booleano)
        {
            btnTipoTarjetaDelete.Visible = booleano;
            btnLimpiar.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            label2.Visible = booleano;
            btnBuscarTipoTarjeta.Visible = booleano;
            txtNombre.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
        }
        private void cargarTablaTipoTarjeta()
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
        private bool busquedaXNombre(string nombre)
        {
            bool resultado = false;
            tablaTipoTarjeta.DataSource = AD_TipoTarjeta.buscarTipoTarjeta(nombre);
            if (tablaTipoTarjeta.Rows.Count == 1)
            {
                resultado = true;
            }
            return resultado;
        }
        private void buscarTipoTarjeta(string nombre)
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
                    MessageBox.Show("No se encontró el tipo de tarjeta!", "Error", MessageBoxButtons.OK);
                    limpiarCampos();
                    cargarTablaTipoTarjeta();
                }
            }
            else
            {
                MessageBox.Show("Error al buscar el tipo de tarjeta! \n Complete el campo por favor!", "Error", MessageBoxButtons.OK);
            }
        }
        private void borrarTipoTarjeta(string nombre)
        {
            AD_TipoTarjeta.borrarTipoTarjeta(nombre);
        }
        private void btnTipoTarjetaDelete_Click(object sender, EventArgs e)
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
                    borrarTipoTarjeta(nombre);
                    MessageBox.Show("Tipo de tarjeta dado de baja con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaTipoTarjeta();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al dar de baja el tipo de tarjeta! \n Complete los campos por favor!");
            }
        }
        private void btnBuscarTipoTarjeta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            buscarTipoTarjeta(nombre);
        }
        private void tablaTipoTarjeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaTipoTarjeta.Rows[indice];
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                buscarTipoTarjeta(nombre);
            }
            catch
            {
                MessageBox.Show("Error! Seleccione una casilla dentro de la tabla");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cambiarModificador(false);
            cambiarBuscador(true);
            cargarTablaTipoTarjeta();
        }
    }
}
