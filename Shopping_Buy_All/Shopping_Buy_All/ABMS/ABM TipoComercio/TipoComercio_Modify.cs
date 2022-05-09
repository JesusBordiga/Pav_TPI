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
using Shopping_Buy_All.ABMS.AccesoADatos;
using Shopping_Buy_All.Entidades;

namespace Shopping_Buy_All
{
    public partial class TipoComercio_Modify : Form
    {
        public TipoComercio_Modify()
        {
            InitializeComponent();
            CargarTablaTipoComercio();
        }

        private void btnBuscarCliente_click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("") && txtNombreTipoComercio.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar al menos un campo!!");
            }

            else if (!txtNombreTipoComercio.Text.Equals("") && !txtId.Text.Equals(""))
            {
                //Buscamos el Tipo Comercio con el ID y el Nombre
                try
                {
                    bool existe = AD_TipoComercio.Buscar_TipoComercioPorIdyNombre(txtId.Text.Trim(), txtNombreTipoComercio.Text.Trim());
                    if (existe)
                    {
                        txtId.Enabled = false;
                        btnModificarTipoComercio.Enabled = true;
                        MessageBox.Show("El Tipo Comercio se encontro, ya puede proceder a modificar");
                    }
                    else
                    {
                        MessageBox.Show("No se encontro Tipo Comercio con ese ID y Nombre");
                        txtId.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al buscar el Tipo Comercio");

                }
            }

            else if (txtNombreTipoComercio.Text.Equals(""))
            {
                //Buscamos el Tipo Comercio con el ID
                try
                {
                    string nombre = AD_TipoComercio.Buscar_TipoComercioPorId(txtId.Text.Trim());
                    if (nombre.Equals(""))
                    {
                        MessageBox.Show("No se encontro Tipo Comercio con ese ID");
                        txtId.Focus();
                    }
                    else
                    {
                        Cargar_Campos(int.Parse(txtId.Text.Trim()), nombre);
                        txtId.Enabled = false;
                        btnModificarTipoComercio.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al buscar el Tipo Comercio");

                }
            }
            else
            {
                //Buscamos el Tipo Comercio con el Nombre
                try
                {
                    int Id = AD_TipoComercio.Buscar_TipoComercioPorNombre(txtNombreTipoComercio.Text.Trim());
                    if (Id == -1)
                    {
                        MessageBox.Show("No se encontro Tipo Comercio con ese nombre");
                        txtId.Focus();
                    }
                    else
                    {
                        Cargar_Campos(Id, txtNombreTipoComercio.Text.Trim());
                        txtId.Enabled = false;
                        btnModificarTipoComercio.Enabled = true;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al buscar el Tipo Comercio");
                }
            }
        }
        
        private void Clean()
        {
            txtNombreTipoComercio.Text = "";
            txtId.Text = "";
            txtId.Enabled = true;
            btnBuscarTipoComercio.Visible = true;
            btnModificarTipoComercio.Enabled = false;
            CargarTablaTipoComercio();
        }
        private void Cargar_Campos(int Id, string Nombre)
        {
            txtId.Text = Id.ToString();
            txtNombreTipoComercio.Text = Nombre;
        }

        private void CargarTablaTipoComercio()
        {
            try
            {
                tablaTipoComercio.DataSource = AD_TipoComercio.ObtenerTablaTipoComercioReducida();
            }
            catch (Exception)
            {
                throw;
            }
        }  

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        } 

        private void tablaClientes_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaTipoComercio.Rows[indice];
            string Nombre = filaSeleccionada.Cells["NombreTipoComercio"].Value.ToString();
            int Id = int.Parse(filaSeleccionada.Cells["Tipo_Comercio"].Value.ToString());

            txtId.Enabled = false;
            btnBuscarTipoComercio.Visible = false;
            btnModificarTipoComercio.Enabled = true;

            Cargar_Campos(Id, Nombre);
        }

        private void btnModificarTipoComercio_Click(object sender, EventArgs e)
        {
            if (txtNombreTipoComercio.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar el campo Nombre vacio, ingrese el dato...");
                txtNombreTipoComercio.Focus();
            }
            else
            {
                TipoComercio comercio = new TipoComercio(txtNombreTipoComercio.Text.Trim());
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = ("Nombre Tipo Comercio: " + comercio.NombreTipoComercio);

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        if (AD_TipoComercio.Buscar_TipoComercio(comercio.NombreTipoComercio))
                        {
                            MessageBox.Show("Ya existe un Tipo Comercio con esos datos");
                        }
                        else
                        {
                            bool resultado = AD_TipoComercio.ModificarNombre_TipoComercio(int.Parse(txtId.Text), comercio);

                            if (resultado)
                            {
                                MessageBox.Show("Tipo Comercio modificado con éxito!");
                                Clean();
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar el Tipo Comercio");
                            }
                        }
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al modificar el Tipo Comercio");
                    }
                    

                }
                else
                {
                    txtNombreTipoComercio.Focus();
                }
            }
        }
    }
}
