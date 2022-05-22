using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All
{
    public partial class Modelo_Delete : Form
    {
        public Modelo_Delete()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaModelo();
        }
        private void cambiarModificador(bool booleano)
        {
            btnBorrar.Visible = booleano;
            btnLimpiar.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano, string text)
        {
            lblBuscar.Text = text;
            btnBuscar.Visible = booleano;
            txtNombre.Visible = booleano;
            label5.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
        }
        private void buscarModelos(string nombre)
        {
            if (nombre != "")
            {
                bool resultado = busquedaXNombre(nombre);
                if (resultado)
                {
                    cambiarModificador(true);
                    cambiarBuscador(false, "Borrar modelo");
                    txtNombre.Text = nombre;
                }
                else
                {
                    MessageBox.Show("No se encontró el modelo!", "Error", MessageBoxButtons.OK);
                    limpiarCampos();
                    cargarTablaModelo();
                }
            }
            else
            {
                MessageBox.Show("Error al buscar el modelo! \n Complete el campo por favor!", "Error", MessageBoxButtons.OK);
            }
        }
        private bool busquedaXNombre(string nombre)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "buscarModeloNoBorrado @Nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaModelos.DataSource = tabla;
                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        private void borrarModelo(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "borrarModelo @nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
        }
        private void cargarTablaModelo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "getModeloNoBorrado";
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaModelos.DataSource = tabla;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! \n Hubo un error con la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
            finally
            {
                cn.Close();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            buscarModelos(nombre);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cambiarModificador(false);
            cambiarBuscador(true, "Buscar modelo");
            cargarTablaModelo();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
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
                    borrarModelo(nombre);
                    MessageBox.Show("Modelo dado de baja con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true, "Buscar modelo");
                    cambiarModificador(false);
                    cargarTablaModelo();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al dar de baja el modelo! \n Complete los campos por favor!");
            }
        }
        private void tablaModelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaModelos.Rows[indice];
                string nombre = filaSeleccionada.Cells["NombreModelo"].Value.ToString();
                buscarModelos(nombre);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Seleccione una casilla dentro de la tabla");
            }
        }
    }
}