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
    public partial class Client_Modify : Form
    {
        public Client_Modify()
        {
            InitializeComponent();
            CargarTablaClientes();
            CargarTiposDocumentos();
            CargarTipoSexo();
        }
        private void btnBuscarCliente_click(object sender, EventArgs e)
        {
            if (comboBoxDocType.SelectedIndex != 0 && textNumberDoc.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos!!");
            }
            else
            {
            Cliente c = Buscar_Cliente_Documento(comboBoxDocType.SelectedIndex.ToString(), textNumberDoc.Text);
            Cargar_Campos(c);
            SearchPanel.Visible=false;
            btnSearchClient.Visible=false;
            }
        }
        private void btnSearchClient2_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            btnSearchClient.Visible = true;

        }
        private void Clean()
        {
            comboBoxDocType.SelectedIndex = -1;
            textNumberDoc.Text = "";
            textSurnameClient.Text = "";
            textNameClient.Text = "";
            textStreetClient.Text = "";
            textStreetHeight.Text = "";
            radioButtonSingle.Checked = false;
            radioButtonMarried.Checked = false;
            textDateBirthDay.Text = "";
            comboBoxSex.SelectedIndex = -1;
        }
        private bool validarCliente()
        {
            ;
            if (comboBoxDocType.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Error, Cargar tipo de documento!");
                comboBoxDocType.Focus();
                return false;
            }
            else if (textNumberDoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar numero de documento!");
                textNumberDoc.Focus();
                return false;
            }
            else if (textSurnameClient.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar apellido de cliente!");
                textSurnameClient.Focus();
                return false;
            }
            else if (textNameClient.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar nombre de cliente!");
                textNameClient.Focus();
                return false;
            }
            else if (textStreetClient.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar domicilio de cliente!");
                textStreetClient.Focus();
                return false;
            }
            else if (textStreetHeight.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar numero de calle de cliente!");
                textStreetHeight.Focus();
                return false;
            }

            else if (radioButtonSingle.Checked == false && radioButtonMarried.Checked == false)
            {
                MessageBox.Show("Error, Cargar estado civil de cliente!");
                textDateBirthDay.Focus();
                return false;
            }
            else if (comboBoxSex.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Error, Cargar tipo de sexo!");
                comboBoxSex.Focus();
                return false;
            }
            else if (textDateBirthDay.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error, Cargar fecha de nacimiento de cliente!");
                textDateBirthDay.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }
        private void CargarTipoSexo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getTipoSexoNoBorrado";
                    //"select * from dbo.TipoSexo S where S.Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                comboBoxSex.DataSource = tabla;
                comboBoxSex.DisplayMember = "NombreSexo";
                comboBoxSex.ValueMember = "TipoSexo";
                comboBoxSex.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, No se pudo cargar el Tipo de Sexo!");
            }
            finally
            {
                cn.Close();
            }
        }
        private void Cargar_Campos(Cliente c)
        {
            //Cargar Tipo Documento
            comboBoxDocType.SelectedValue = c.TipoDocumentoCliente;
            //Cargar Documento
            textNumberDoc.Text = c.DocumentoCliente;
            //Cargar Apellido
            textSurnameClient.Text = c.ApellidoCliente;
            //Cargar Nombre
            textNameClient.Text = c.NombreCliente;
            //Cargar Calle
            textStreetClient.Text = c.CalleCliente;
            //Cargar Nro Calle
            textStreetHeight.Text = c.NroCalleCliente.ToString();
            //Cargar Estado Civil
            if (c.EstadoCivilCliente == 1)
            {
                radioButtonSingle.Checked = true;
            }
            else if (c.EstadoCivilCliente == 2)
            {
                radioButtonMarried.Checked = true;
            }
            //Cargar Tipo Sexo
            comboBoxSex.SelectedValue = c.SexoCliente;

            //Cargar Fecha Nacimiento 
            DateTime fecha = c.FechaNacimientoCliente;
            string dia = "";string mes = ""; string año = "";
            dia = fecha.Date.Day.ToString();
            if(dia.Length ==1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();
            textDateBirthDay.Text = dia+mes+año;
        }
        private void CargarTiposDocumentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getTipoDocumentoNoBorrado";
                    //"select * from dbo.TipoDocumento D where D.Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);

                comboBoxDocType.DataSource = tabla;
                comboBoxDocType.DisplayMember = "NombreDocumento";
                comboBoxDocType.ValueMember = "TipoDocumento";
                comboBoxDocType.SelectedIndex = -1;
            }
            catch (Exception )
            {

                MessageBox.Show("Error, no se pudo cargar el Tipo de Documento!");
            }
            finally
            {
                cn.Close();
            }
        }
        private void CargarTablaClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comand = new SqlCommand();
                string consulta = "getClienteNoBorrado";
                    //"SELECT TD.NombreDocumento 'TipoDocumento', C.NroDocumento, C.Apellido, C.Nombres, C.Calle, C.NroCalle, TEC.NombreEstadoCivil 'EstadoCivil', TS.NombreSexo 'Sexo', C.FechaNacimiento, C.Borrado, C.TipoDocumento 'TipoDoc' FROM Clientes C JOIN TipoDocumento TD ON(C.TipoDocumento = TD.TipoDocumento) JOIN TipoEstadoCivil TEC ON(C.EstadoCivil = TEC.TipoEstadoCivil) JOIN TipoSexo TS ON(C.Sexo = TS.TipoSexo) WHERE C.Borrado = 0";

                comand.Parameters.Clear();
                comand.CommandType = CommandType.Text;
                comand.CommandText = consulta;

                cn.Open();
                comand.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(tabla);
                tablaClientes.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                cn.Close();
            }
        }
        private Cliente Buscar_Cliente_Documento(string TipoDocumento ,string NroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente client= new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarClienteNoBorrado @tipoDocumento, @nroDocumento";
                    //"SELECT TD.NombreDocumento 'TipoDocumento', C.NroDocumento, C.Apellido, C.Nombres, C.Calle, C.NroCalle, TEC.NombreEstadoCivil 'EstadoCivil', TS.NombreSexo 'Sexo', C.FechaNacimiento, C.Borrado, C.TipoDocumento 'TipoDoc', EstadoCivil 'EstadoCiv',Sexo 'Sex' FROM Clientes C JOIN TipoDocumento TD ON(C.TipoDocumento = TD.TipoDocumento) JOIN TipoEstadoCivil TEC ON(C.EstadoCivil = TEC.TipoEstadoCivil) JOIN TipoSexo TS ON(C.Sexo = TS.TipoSexo) WHERE C.Borrado = 0 AND C.TipoDocumento like @tipoDocumento AND C.NroDocumento like @nroDocumento";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroDocumento", NroDocumento);
                cmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader DataReader = cmd.ExecuteReader();
                if (DataReader !=null && DataReader.Read())
                {
                    client.TipoDocumentoCliente = int.Parse(DataReader["TipoDoc"].ToString());
                    client.DocumentoCliente= DataReader["NroDocumento"].ToString();
                    client.ApellidoCliente = DataReader["Apellido"].ToString();
                    client.NombreCliente = DataReader["Nombres"].ToString();
                    client.CalleCliente = DataReader["Calle"].ToString();
                    client.NroCalleCliente = int.Parse(DataReader["NroCalle"].ToString());
                    client.EstadoCivilCliente = int.Parse(DataReader["EstadoCiv"].ToString());
                    client.SexoCliente = int.Parse(DataReader["Sex"].ToString());
                    client.FechaNacimientoCliente = DateTime.Parse(DataReader["FechaNacimiento"].ToString());
                }
                cn.Close();
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                tablaClientes.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar al cliente");
            }
            finally
            {
                cn.Close();
            }
            return client;

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
            SearchPanel.Visible = true;
            CargarTablaClientes();
        }
        private Cliente ObtenerDatosCliente()
        {

            Cliente c = new Cliente();
            //Tipo de documento
            c.TipoDocumentoCliente = (int)comboBoxDocType.SelectedValue;

            //Nro de documento
            c.DocumentoCliente = textNumberDoc.Text.Trim();

            //Apellido Cliente
            c.ApellidoCliente = textSurnameClient.Text.Trim();

            //Nombre de Cliente
            c.NombreCliente = textNameClient.Text.Trim();

            //Calle de Cliente
            c.CalleCliente = textStreetClient.Text.Trim();

            //Numero de calle de Cliente
            c.NroCalleCliente = int.Parse(textStreetHeight.Text.Trim());

            //Estado civil de cliente
            if (radioButtonSingle.Checked)
            {
                c.EstadoCivilCliente = 1;
            }
            else if (radioButtonMarried.Checked)
            {
                c.EstadoCivilCliente = 2;
            }
            else
            {
                MessageBox.Show("Error al elegir estado Civil de Cliente! \n" +
                    "Complete los campos por favor!");
                radioButtonSingle.Focus();
            }

            //Sexo de cliente
            c.SexoCliente = (int)comboBoxSex.SelectedValue;

            //Fecha de nacimiento de Cliente
            c.FechaNacimientoCliente = DateTime.Parse(textDateBirthDay.Text);
            return c;

        }
        private bool ModificarCliente(Cliente client)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "modificarCliente @tipoDocumento, @nroDocumento, @apellido, @nombres, @calle, @nroCalle, @estadoCivil, @sexo, @fechaNacimiento";
                //"UPDATE Clientes SET TipoDocumento = @tipoDocumento, NroDocumento = @nroDocumento, Apellido = @apellido, Nombres = @nombres, Calle = @calle, NroCalle = @nroCalle, EstadoCivil = @estadoCivil, Sexo = @sexo, FechaNacimiento = @fechaNacimiento WHERE TipoDocumento Like @tipoDocumento AND NroDocumento Like @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocumento", client.TipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@nroDocumento", client.DocumentoCliente);
                cmd.Parameters.AddWithValue("@apellido", client.ApellidoCliente);
                cmd.Parameters.AddWithValue("@nombres", client.NombreCliente);
                cmd.Parameters.AddWithValue("@calle", client.CalleCliente);
                cmd.Parameters.AddWithValue("@nroCalle", client.NroCalleCliente);
                cmd.Parameters.AddWithValue("@estadoCivil", client.EstadoCivilCliente);
                cmd.Parameters.AddWithValue("@sexo", client.SexoCliente);
                cmd.Parameters.AddWithValue("@fechaNacimiento", client.FechaNacimientoCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! Hubo un problema con la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        private void btnClientLoad_Click_1(object sender, EventArgs e)
        {
            if (validarCliente())
            {
                Cliente c = ObtenerDatosCliente();
                bool resultado = ModificarCliente(c);
                if (resultado)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    String mensajeCarga = (
                          " |Tipo Documento: " + c.TipoDocumentoCliente + " |Numero Documento: " + c.DocumentoCliente + "|" + "\n"
                        + " |Apellido: " + c.ApellidoCliente + " |Nombre: " + c.NombreCliente + "|" + "\n"
                        + " |Calle: " + c.CalleCliente + " |Nro Calle: " + c.NroCalleCliente + "|" + "\n"
                        + " |Estado Civil: " + c.EstadoCivilCliente + " |Sexo: " + c.SexoCliente + "|" + "\n"
                        + " |Fecha Nacimiento: " + c.FechaNacimientoCliente + "|" + "\n");

                    string titulo = "Información de Carga";

                    DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Cliente agregado con éxito!");
                        Clean();
                        CargarTablaClientes();
                        CargarTiposDocumentos();


                    }
                    else
                    {
                        comboBoxDocType.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error al modificar la persona!");
                }
            }
        }
        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaClientes.Rows[indice];
            string documento = filaSeleccionada.Cells["NroDocumento"].Value.ToString();
            string tipodocumento = filaSeleccionada.Cells["TipoDoc"].Value.ToString();
            Cliente c = Buscar_Cliente_Documento(tipodocumento,documento);
            Clean();
            SearchPanel.Visible = false;
            btnSearchClient.Visible = false;
            comboBoxDocType.Visible = true;
            label4.Visible = true;
            Cargar_Campos(c);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! seleccione una casilla dentro de la tabla");
            }
        }
    }
}
