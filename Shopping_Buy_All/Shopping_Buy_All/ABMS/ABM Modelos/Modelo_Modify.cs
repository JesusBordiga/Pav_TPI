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
    public partial class Modelo_Modify : Form
    {
        public Modelo_Modify()
        {
            InitializeComponent();
            cambiarModificador(false, "Buscar modelo");
            cargarTablaModelo();
        }
        private void cambiarModificador(bool booleano, string texto)
        {
            btnModificar.Visible = booleano;
            btnLimpiar.Visible = booleano;
            panelModificador.Visible = booleano;
            lblBuscar.Text = texto;
        }
        private void cambiarBuscador(bool booleano)
        {
            btnBuscar.Visible = booleano;
            txtNombre.Visible = booleano;
            label5.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtNombreNuevo.Text = "";
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
        private void cargarMarca()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getMarcaNoBorrado";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                cmbMarca.DataSource = tabla;
                cmbMarca.DisplayMember = "Descripcion";
                cmbMarca.ValueMember = "Id";
                cmbMarca.SelectedIndex = -1;
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
        private void cargarTipoAuto()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getTipoAutoNoBorrado";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                cmbTipoAuto.DataSource = tabla;
                cmbTipoAuto.DisplayMember = "Nombre";
                cmbTipoAuto.ValueMember = "Cod_tipo";
                cmbTipoAuto.SelectedIndex = -1;
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
            cambiarModificador(false, "Buscar modelo");
            cambiarBuscador(true);
            cargarTablaModelo();

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombre.Text.Trim();
            string nombre = txtNombreNuevo.Text.Trim();
            int marca = -1;
            int tipoAuto = -1;
            if (cmbMarca.SelectedValue != null && cmbTipoAuto.SelectedValue != null)
            {
                marca = (int)cmbMarca.SelectedValue;
                tipoAuto = (int)cmbTipoAuto.SelectedValue;
            }
            if (validarCampos(nombre, nombreViejo, marca, tipoAuto))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = ("Nombre: " + nombre + "\n" + "Marca: " + cmbMarca.Text + "\n" + "Tipo de Auto: " + cmbTipoAuto.Text);
                string titulo = "Información de Modificacion";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
                if (result == DialogResult.OK)
                {
                    modificarModelo(nombre, nombreViejo, marca, tipoAuto);
                    MessageBox.Show("Modelo modificado con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false, "Buscar modelo");
                    cargarTablaModelo();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar el modelo! \n Complete los campos por favor!");
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
        private bool validarCampos(string a, string b, int c, int d)
        {
            bool resultado = false;
            if (a != "" && b != "" && c != -1 && d != -1)
            {
                resultado = true;
            }
            return resultado;
        }
        private void buscarModelos(string nombre)
        {
            if (nombre != "")
            {
                bool resultado = busquedaXNombre(nombre);
                if (resultado)
                {
                    cambiarModificador(true, "Modificar modelo");
                    cambiarBuscador(false);
                    cargarTipoAuto();
                    cargarMarca();
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
        private void modificarModelo(string nombre, string nombreViejo, int marca, int tipoAuto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "modificarModelo @nombre, @marca, @tipoAuto, @nombreViejo";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@marca", marca);
                command.Parameters.AddWithValue("@tipoAuto", tipoAuto);
                command.Parameters.AddWithValue("@nombreViejo", nombreViejo);
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
    }
}