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
    public partial class Local_Delete : Form
    {
        public Local_Delete()
        {
            InitializeComponent();
        }

        private void Local_Delete_Load(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;
            btnDeleteLocal.Visible = false;

            CargarTablaLocal();
            CargarComboTipoComercio();

        }

        private void CargarTablaLocal()
        {
            try
            {
                tablaLocales.DataSource = AD_Local.ObtenerTablaLocalReducida();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la tabla locales.");
            }
        }

        private void CargarComboTipoComercio()
        {
            try
            {
                cmbTipoComercio.DataSource = AD_TipoComercio.ObtenerTablaTipoComercioReducida();
                cmbTipoComercio.DisplayMember = "NombreTipoComercio";
                cmbTipoComercio.ValueMember = "Tipo_Comercio";
                cmbTipoComercio.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la tabla locales.");
            }

        }

        private void Clean()
        {
            txtNombreLocal.Text = "";
            txtCodigo.Text = "";
            cmbTipoComercio.SelectedIndex = -1;
            btnDeleteLocal.Visible = false;
            btnBuscar.Visible = true;
            txtCodigo.Enabled = true;
            txtNombreLocal.Enabled = true;
            cmbTipoComercio.Enabled = true;
            CargarTablaLocal();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtCodigo.Text.Equals(""))
            {
                try
                {
                    Local l = AD_Local.Buscar_LocalPorCodigo(txtCodigo.Text.Trim());
                    if (l.NombreLocal != null)
                    {
                        txtNombreLocal.Text = l.NombreLocal;
                        cmbTipoComercio.SelectedValue = l.TipoComercio;

                        txtCodigo.Enabled = false;
                        txtNombreLocal.Enabled = false;
                        cmbTipoComercio.Enabled = false;
                        btnDeleteLocal.Visible = true;
                        btnBuscar.Visible = false;
                        MessageBox.Show("El Local se encontro, ya puede proceder a modificarlo");
                    }
                    else
                    {
                        MessageBox.Show("Local no encontrado");
                        txtCodigo.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al buscar el Local");
                }
                
            }

            else if (txtCodigo.Text.Equals("") && !txtNombreLocal.Text.Equals("") && cmbTipoComercio.SelectedValue != null)
            {
                
                //Buscamos el Local por Nombre y Tipo Comercio
                try
                {
                    Local local = ObtenerDatosLocal();
                    int codigo = AD_Local.Buscar_LocalPorNombreYTipoComercio(local);
                    
                    if (codigo != -1)
                    {
                        txtCodigo.Enabled = false;
                        txtNombreLocal.Enabled = false;
                        cmbTipoComercio.Enabled = false;
                        txtCodigo.Text = codigo.ToString();
                        btnDeleteLocal.Visible = true;
                        btnBuscar.Visible = false;
                        MessageBox.Show("El Local se encontro, ya puede proceder a borrarlo");
                    }
                    else
                    {
                        MessageBox.Show("No se encontro Local con ese Nombre y Tipo Comercio");
                        txtCodigo.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al buscar el Local");

                }
            }
            else
            {
                MessageBox.Show("Error, Completar al menos el campo Codigo o el campo Nombre y Tipo Comercio...!!");
                txtCodigo.Focus();
            }
        }

        private void btnDeleteLocal_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = ("Desea eliminar el siguiente Local?:\nCodigo: "+ txtCodigo.Text + "\nNombre: " + txtNombreLocal.Text +
                "\nTipo Comercio: "+ cmbTipoComercio.GetItemText(cmbTipoComercio.SelectedItem));

            string titulo = "Información de Eliminación";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                try
                {
                    bool resultado = AD_Local.BorrarLocal(int.Parse(txtCodigo.Text.Trim()));
                    if (resultado)
                    {
                        MessageBox.Show("Local Borrado con éxito!");
                        Clean();
                        btnDeleteLocal.Visible = false;
                        btnBuscar.Visible = true;

                        txtCodigo.Enabled = true;
                        txtNombreLocal.Enabled = true;
                        cmbTipoComercio.SelectedValue = -1;
                        cmbTipoComercio.Enabled = true;

                        CargarTablaLocal();
                        txtCodigo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El Local No fue Borrado!");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al borrar el Local");
                }

            }
            else
            {
                txtCodigo.Focus();
            }
        }

        private Local ObtenerDatosLocal()
        {
            Local l = new Local();

            //Nombre de Local
            l.NombreLocal = txtNombreLocal.Text.Trim();
            l.TipoComercio = (int)cmbTipoComercio.SelectedValue;

            return l;
        }
        private void tablaLocal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = tablaLocales.Rows[indice];
            string Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
            int Id = int.Parse(filaSeleccionada.Cells["TipoComercio"].Value.ToString());
            string Codigo = filaSeleccionada.Cells["CodigoLocal"].Value.ToString();

            btnBuscar.Visible = false;
            btnDeleteLocal.Visible = true;

            txtCodigo.Enabled = false;
            txtNombreLocal.Enabled = false;
            cmbTipoComercio.Enabled = false;
            Cargar_Campos(Id, Nombre);
            txtCodigo.Text = Codigo;
        }
        private void Cargar_Campos(int Id, string Nombre)
        {
            cmbTipoComercio.SelectedValue = Id;
            txtNombreLocal.Text = Nombre;
        }
    }   
}

