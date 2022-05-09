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
    public partial class Local_Modify : Form
    {
        public Local_Modify()
        {
            InitializeComponent();            
        }

        private void Local_Modify_Load(object sender, EventArgs e)
        {
            CargarTablaLocal();
            CargarComboTipoComercio();
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

        private void btnBuscar_click(object sender, EventArgs e)
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

                        btnBuscar.Visible = false;
                        btnModificarLocal.Visible = true;
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
                        txtCodigo.Text = codigo.ToString();
                        btnModificarLocal.Visible = true;
                        btnBuscar.Visible = false;
                        MessageBox.Show("El Local se encontro, ya puede proceder a modificarlo");
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
        
        private void Clean()
        {
            txtNombreLocal.Text = "";
            txtCodigo.Text = "";
            cmbTipoComercio.SelectedValue = -1;
            txtCodigo.Enabled = true;
            btnBuscar.Visible = true;
            btnModificarLocal.Visible = false;
            CargarTablaLocal();
        }
        private void Cargar_Campos(int Id, string Nombre)
        {
            cmbTipoComercio.SelectedValue = Id;
            txtNombreLocal.Text = Nombre;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
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
            btnModificarLocal.Visible = true;

            txtCodigo.Enabled = false;

            Cargar_Campos(Id, Nombre);
            txtCodigo.Text = Codigo;
        }

        private void btnModificarTipoComercio_Click(object sender, EventArgs e)
        {
            if (txtNombreLocal.Text.Equals("") || cmbTipoComercio.SelectedValue == null || txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar los campos vacios...");
                txtCodigo.Focus();
            }
            else
            {
                Local l = new Local(txtNombreLocal.Text.Trim(), (int)cmbTipoComercio.SelectedValue);
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = ("Codigo Local: "+ txtCodigo.Text +"\nNombre Local: " + l.NombreLocal + "\nTipo Comercio: " + l.TipoComercio);

                string titulo = "Información de Carga";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        if(AD_Local.Buscar_Local(l))
                        {
                            MessageBox.Show("Ya existe un Local con esos datos");
                        }
                        else
                        {
                            //bool resultado = AD_TipoComercio.ModificarNombre_TipoComercio(int.Parse(txtId.Text) ,comercio);
                            bool resultado = AD_Local.Modificar_Local(txtCodigo.Text.Trim(), l);
                            if (resultado)
                            {
                                MessageBox.Show("Local modificado con éxito!");
                                Clean();
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar el Local");
                            }
                        }
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al modificar el Local");
                    }
                    

                }
                else
                {
                    txtCodigo.Focus();
                }
            }
        }

        
    }
}
