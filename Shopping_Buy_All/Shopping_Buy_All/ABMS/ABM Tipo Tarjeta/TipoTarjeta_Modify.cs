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

namespace Shopping_Buy_All.ABM_Tipo_Tarjeta
{
    public partial class TipoTarjeta_Modify : Form
    {
        public TipoTarjeta_Modify()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaTipoTarjeta();
        }
        private void cambiarModificador(bool booleano)
        {
            label4.Visible = booleano;
            txtNuevoNombre.Visible = booleano;
            btnTipoTarjetaModify.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            txtNombreTdT.Visible = booleano;
            label2.Visible = booleano;
            btnBuscarTipoTarjeta.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNuevoNombre.Text = "";
            txtNombreTdT.Text = "";
        }
        private void cargarTablaTipoTarjeta()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "select idTipo, Nombre from TipoTarjeta where Borrado = 0";
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaTipoTarjeta.DataSource = tabla;
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
                string consulta = "select idTipo, Nombre from TipoTarjeta where Nombre = @Nombre and Borrado = 0";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", nombreViejo);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaTipoTarjeta.DataSource = tabla;
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
        private void buscarTipoTarjeta(string nombreViejo)
        {
            if (nombreViejo != "")
            {
                bool resultado = busquedaXNombre(nombreViejo);
                if (resultado)
                {
                    cambiarModificador(true);
                    cambiarBuscador(false);
                    txtNombreTdT.Text = nombreViejo;
                }
                else
                {
                    MessageBox.Show("No se encontró el Tipo de Tarjeta!", "Error", MessageBoxButtons.OK);
                    limpiarCampos();
                    cargarTablaTipoTarjeta();
                }
            }
            else
            {
                MessageBox.Show("Error al buscar el Tipo de Tarjeta! \n Complete el campo por favor!", "Error", MessageBoxButtons.OK);
            }
        }
        private void modificarTipoTarjeta(string nombreNuevo, string nombreViejo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "update TipoTarjeta set Nombre = @nombreNuevo where Nombre = @nombreViejo";
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
                tablaTipoTarjeta.DataSource = tabla;
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
        private void btnBuscarTipoTarjeta_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreTdT.Text.Trim();
            buscarTipoTarjeta(nombreViejo);
        }
        private void btnTipoTarjetaModify_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreTdT.Text.Trim();
            string nombreNuevo = txtNuevoNombre.Text.Trim();
            if (nombreNuevo != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + nombreNuevo + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
                if (result == DialogResult.OK)
                {
                    modificarTipoTarjeta(nombreNuevo, nombreViejo);
                    MessageBox.Show("Tipo de Tarjeta modificado con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaTipoTarjeta();
                }
                else
                {
                    txtNombreTdT.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar el Tipo de Tarjeta! \n Complete los campos por favor!");
            }
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
            catch (Exception)
            {
                MessageBox.Show("Error! Seleccione una casilla dentro de la tabla");
            }
        }
    }
}
