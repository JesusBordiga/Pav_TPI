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
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "select TipoSexo, NombreSexo from TipoSexo where Borrado = 0";
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaSexo.DataSource = tabla;
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
        private bool busquedaXNombre(string nombreViejo)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "select * from TipoSexo where NombreSexo = @Nombre and Borrado = 0";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", nombreViejo);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaSexo.DataSource = tabla;
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
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "update TipoSexo set NombreSexo = @nombreNuevo where NombreSexo = @nombreViejo";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombreNuevo", nombreNuevo);
                command.Parameters.AddWithValue("@nombreViejo", nombreViejo);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaSexo.DataSource = tabla;
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
