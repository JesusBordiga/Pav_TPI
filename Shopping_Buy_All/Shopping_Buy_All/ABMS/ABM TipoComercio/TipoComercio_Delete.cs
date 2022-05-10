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
    public partial class TipoComercio_Delete : Form
    {
        public TipoComercio_Delete()
        {
            InitializeComponent();
        }
        private void Client_Delete_Load(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;
            btnDeleteTipoComercio.Visible = false;

            CargarTablaTipoComercio();
        }
        private void CargarTablaTipoComercio()
        {
            try
            {
                tablaTipoComercio.DataSource = AD_TipoComercio.ObtenerTablaTipoComercioReducida();
            }
            catch (Exception)
            {
                MessageBox.Show("Error! \n Hubo un error!");
            }
        }
        private void Clean()
        {
            txtId.Text = "";
            txtNombreTipoComercio.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
            CargarTablaTipoComercio();
            btnDeleteTipoComercio.Visible = false;
            btnBuscar.Visible = true;
            txtId.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                        btnDeleteTipoComercio.Visible = true;
                        btnBuscar.Visible = false;
                        MessageBox.Show("El Tipo Comercio se encontro, ya puede proceder a borrarlo");
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
                        btnDeleteTipoComercio.Visible = true;
                        btnBuscar.Visible = false;
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
                        btnDeleteTipoComercio.Visible = true;
                        btnBuscar.Visible = false;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al buscar el Tipo Comercio");
                }
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = ("Desea eliminar el Tipo Comercio " + txtNombreTipoComercio.Text + " ?");

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                try
                {
                    bool resultado = AD_TipoComercio.BorrarTipoComercio(txtNombreTipoComercio.Text.Trim());
                    if (resultado)
                    {
                        MessageBox.Show("Tipo Comercio Borrado con éxito!");
                        Clean();
                        btnDeleteTipoComercio.Visible = false;
                        btnBuscar.Visible = true;
                        txtId.Enabled=true;
                        CargarTablaTipoComercio();
                        txtId.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El Tipo Comercio No fue Borrado!");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al borrar el Tipo Comercio");
                }
                
            }
            else
            {
                txtId.Focus();
            }
        }

        private void tablaTipoComercio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaTipoComercio.Rows[indice];
            string Nombre = filaSeleccionada.Cells["NombreTipoComercio"].Value.ToString();
            int Id = int.Parse(filaSeleccionada.Cells["Tipo_Comercio"].Value.ToString());

            txtId.Enabled = false;
            btnBuscar.Visible = false;
            btnDeleteTipoComercio.Visible = true;
            Cargar_Campos(Id, Nombre);
        }
        private void Cargar_Campos(int Id, string Nombre)
        {
            txtId.Text = Id.ToString();
            txtNombreTipoComercio.Text = Nombre;
        }
    }   
}

