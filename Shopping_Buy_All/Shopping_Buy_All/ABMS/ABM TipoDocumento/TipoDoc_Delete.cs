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
                    modificarTipDoc(nombre);
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
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "select TipoDocumento, NombreDocumento from TipoDocumento where Borrado = 0";
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaTipDoc.DataSource = tabla;
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
        private bool busquedaXNombre(string nombre)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "select * from TipoDocumento where NombreDocumento = @Nombre and Borrado = 0";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaTipDoc.DataSource = tabla;
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
        private void modificarTipDoc(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "update TipoDocumento set Borrado = 1 where NombreDocumento = @nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaTipDoc.DataSource = tabla;
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
    }
}
