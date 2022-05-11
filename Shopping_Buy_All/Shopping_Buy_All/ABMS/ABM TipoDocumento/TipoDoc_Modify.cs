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
    public partial class TipoDoc_Modify : Form
    {
        public TipoDoc_Modify()
        {
            InitializeComponent();
            cambiarModificador(false);
            cargarTablaTipDoc();
        }
        private void btnTipDocModify_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreTipDoc.Text.Trim();
            string nombreNuevo = txtNuevoNombre.Text.Trim();
            if (nombreNuevo != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string mensajeCarga = (" |Nombre: " + nombreNuevo + "|");
                string titulo = "Información de Carga";
                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
                if (result == DialogResult.OK)
                {
                    modificarTipDoc(nombreNuevo, nombreViejo);
                    MessageBox.Show("Tipo de documento modificado con éxito!");
                    limpiarCampos();
                    cambiarBuscador(true);
                    cambiarModificador(false);
                    cargarTablaTipDoc();
                }
                else
                {
                    txtNombreTipDoc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar el tipo de documento! \n Complete los campos por favor!");
            }
        }
        private void btnBuscarTipDoc_Click(object sender, EventArgs e)
        {
            string nombreViejo = txtNombreTipDoc.Text.Trim();
            buscarTipDoc(nombreViejo);
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
                MessageBox.Show("Error! Seleccione una casilla de la tabla");
            }
        }
        private void cambiarModificador(bool booleano)
        {
            label4.Visible = booleano;
            txtNuevoNombre.Visible = booleano;
            btnTipDocModify.Visible = booleano;
        }
        private void cambiarBuscador(bool booleano)
        {
            txtNombreTipDoc.Visible = booleano;
            label2.Visible = booleano;
            btnBuscarTipDoc.Visible = booleano;
        }
        private void limpiarCampos()
        {
            txtNuevoNombre.Text = "";
            txtNombreTipDoc.Text = "";
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
        private bool busquedaXNombre(string nombreViejo)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "select * from TipoDocumento where NombreDocumento = @Nombre and Borrado = 0";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", nombreViejo);
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
        private void buscarTipDoc(string nombreViejo)
        {
            if (nombreViejo != "")
            {
                bool resultado = busquedaXNombre(nombreViejo);
                if (resultado)
                {
                    cambiarModificador(true);
                    cambiarBuscador(false);
                    txtNombreTipDoc.Text = nombreViejo;
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
        private void modificarTipDoc(string nombreNuevo, string nombreViejo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand command = new SqlCommand();
                string consulta = "update TipoDocumento set NombreDocumento = @nombreNuevo where NombreDocumento = @nombreViejo";
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
