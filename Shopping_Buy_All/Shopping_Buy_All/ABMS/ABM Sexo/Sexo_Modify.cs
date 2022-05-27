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
    public partial class Sexo_Modify : Form
    {
        public Sexo_Modify()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaSexo();
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
                MessageBox.Show("Error! \n Seleccione una casilla dentro de la tabla");
            }
        }
        private void btnSexoModify_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreSexo.Text.Trim();
            string nombreNuevo = txtNuevoNombre.Text.Trim();
            if (nombreNuevo != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + nombreNuevo + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
                if (result == DialogResult.OK)
                {
                    modificarSexo(nombreNuevo, nombreViejo);
                    MessageBox.Show("Nombre de sexo modificado con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaSexo();
                }
                else
                {
                    txtNombreSexo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar el nombre de sexo! \n Complete los campos por favor!");
            }
        }
        private void btnBuscarSexo_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreSexo.Text.Trim();
            buscarSexo(nombreViejo);
        }
        private void cambiarModificador(bool booleano)
        {
            label4.Visible = booleano;
            txtNuevoNombre.Visible = booleano;
            btnSexoModify.Visible = booleano;
            btnLimpiar.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            txtNombreSexo.Visible = booleano;
            label2.Visible = booleano;
            btnBuscarSexo.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNuevoNombre.Text = "";
            txtNombreSexo.Text = "";
        }
        private void cargarTablaSexo()
        {
            try
            {
                tablaSexo.DataSource = AD_Sexo.obtenerDatosSexo();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Otener Datos del Cliente");
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
        private void buscarSexo(string nombreViejo)
        {
            if (nombreViejo != "")
            {
                bool resultado = busquedaXNombre(nombreViejo);
                if (resultado)
                {
                    cambiarModificador(true);
                    cambiarBuscador(false);
                    txtNombreSexo.Text = nombreViejo;
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
        private void modificarSexo(string nombreNuevo, string nombreViejo)
        {
            AD_Sexo.modificarSexo(nombreNuevo, nombreViejo);
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
