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
    public partial class Modelo_Load : Form
    {
        public Modelo_Load()
        {
            InitializeComponent();
            cargarTablaModelo();
            cargarMarca();
            cargarTipoAuto();
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            cmbMarca.SelectedIndex = -1;
            cmbTipoAuto.SelectedIndex = -1;
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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private bool agregarModelo(string nombre, int marca, int tipoAuto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "agregarModelo @nombre, @marca, @tipoAuto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@tipoAuto", tipoAuto);
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
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
        private void btnCargar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            int marca = -1;
            int tipoAuto = -1;
            bool resultado = false;
            if (cmbMarca.SelectedValue != null && cmbTipoAuto.SelectedValue != null)
            {
                marca = (int)cmbMarca.SelectedValue;
                tipoAuto = (int)cmbTipoAuto.SelectedValue;
            }
            if (nombre != "")
            {
                resultado = agregarModelo(nombre, marca, tipoAuto);
            }
            if (resultado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = ("Nombre: " + nombre + "\n" + "Marca: " + cmbMarca.Text + "\n" + "Tipo de Auto: " + cmbTipoAuto.Text);
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Modelo agregado con éxito!");
                    limpiarCampos();
                    cargarTablaModelo();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el Modelo! \n Complete los campos por favor!");
            }
        }
    }
}
