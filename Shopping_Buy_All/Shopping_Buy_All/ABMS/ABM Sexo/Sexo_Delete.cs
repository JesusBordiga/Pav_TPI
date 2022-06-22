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

namespace Shopping_Buy_All.ABM_Sexo
{
    public partial class Sexo_Delete : Form
    {
        public Sexo_Delete()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaSexo();
        }
        private void btnSexoDelete_Click(object sender, EventArgs e)
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
                    borrarSexo(nombre);
                    MessageBox.Show("Nombre de sexo dado de baja con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaSexo();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al dar de baja el nombre de sexo! \n Complete los campos por favor!");
            }
        }
        private void btnBuscarSexo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            buscarSexo(nombre);
        }
        private void tablaSexo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaSexo.Rows[indice];
                string nombre = filaSeleccionada.Cells["NombreSexo"].Value.ToString();
                buscarSexo(nombre);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Seleccione una casilla dentro de la tabla");
            }
        }
        private void cambiarModificador(bool booleano)
        {
            btnSexoDelete.Visible = booleano;
            btnLimpiar.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            label2.Visible = booleano;
            btnBuscarSexo.Visible = booleano;
            txtNombre.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
        }
        private void cargarTablaSexo()
        {
            try
            {
                tablaSexo.DataSource = AD_Sexo.obtenerDatosSexo();
            }
            catch (Exception)
            {

                MessageBox.Show("Error! No se pudieron obtener los datos de los sexos");
            }
        }
        private bool busquedaXNombre(string nombreViejo)
        {
            bool resultado = false;
            tablaSexo.DataSource = AD_Sexo.buscarSexo(nombreViejo);
            if (tablaSexo.Rows.Count == 1)
            {
                resultado = true;
            }
            return resultado;
        }
        private void buscarSexo(string nombre)
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
                    MessageBox.Show("No se encontró el nombre de sexo!", "Error", MessageBoxButtons.OK);
                    limpiarCampos();
                    cargarTablaSexo();
                }
            }
            else
            {
                MessageBox.Show("Error al buscar el nombre de sexo! \n Complete el campo por favor!", "Error", MessageBoxButtons.OK);
            }
        }
        private void borrarSexo(string nombre)
        {
            AD_Sexo.borrarSexo(nombre);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cambiarModificador(false);
            cambiarBuscador(true);
            cargarTablaSexo();
        }
    }
}