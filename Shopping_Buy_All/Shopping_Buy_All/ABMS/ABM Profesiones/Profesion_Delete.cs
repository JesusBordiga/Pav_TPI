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

namespace Shopping_Buy_All.ABMS.ABM_Profesiones
{
    public partial class Profesion_Delete : Form
    {
        public Profesion_Delete()
        {
            InitializeComponent();
            cambiarModificador(false, "Buscar\nprofesion");
            cargarTablaProfesiones();
        }
        private void cargarTablaProfesiones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getProfesionNoBorrado";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaProfesiones.DataSource = tabla;
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
        private void btnBuscarProf_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProf.Text.Trim();
            buscarProfesion(nombre);
        }
        private void buscarProfesion(string nombre)
        {
            if (nombre != "")
            {
                bool resultado = busquedaXNombre(nombre);
                if (resultado)
                {
                    cambiarModificador(true, "Borrar\nprofesion");
                    cambiarBuscador(false);
                    txtNombreProf.Text = nombre;
                }
                else
                {
                    MessageBox.Show("No se encontró la profesion!", "Error", MessageBoxButtons.OK);
                    limpiarCampos();
                    cargarTablaProfesiones();
                }
            }
            else
            {
                MessageBox.Show("Error al buscar la profesion! \n Complete el campo por favor!", "Error", MessageBoxButtons.OK);
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
                string consulta = "buscarProfesionNoBorrado @Nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", nombreViejo);
                command.CommandType = CommandType.Text;
                command.CommandText = consulta;

                cn.Open();
                command.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                tablaProfesiones.DataSource = tabla;
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
        private void tablaProfesiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = tablaProfesiones.Rows[indice];
                string nombreViejo = filaSeleccionada.Cells["Nombre"].Value.ToString();
                buscarProfesion(nombreViejo);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Seleccione una casilla de la tabla");
            }
        }
        private void cambiarModificador(bool booleano, string label)
        {
            btnProfBorrar.Visible = booleano;
            btnLimpiar.Visible = booleano;
            label1.Text = label;
        }
        private void cambiarBuscador(bool booleano)
        {
            btnBuscarProf.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNombreProf.Text = "";
            cargarTablaProfesiones();
            cambiarModificador(false, "Buscar\nprofesion");
            cambiarBuscador(true);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void btnProfBorrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProf.Text.Trim();
            if (nombre != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + nombre + "|");
                string titulo = "Información de Baja";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
                if (result == DialogResult.OK)
                {
                    borrarProfesion(nombre);
                    MessageBox.Show("Profesión dada de baja con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false, "Buscar\nprofesion");
                    cargarTablaProfesiones();
                }
                else
                {
                    txtNombreProf.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al dar de baja la profesion! \n Complete los campos por favor!");
            }
        }
        private void borrarProfesion(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "borrarProfesion @nombre";
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
    }
}
