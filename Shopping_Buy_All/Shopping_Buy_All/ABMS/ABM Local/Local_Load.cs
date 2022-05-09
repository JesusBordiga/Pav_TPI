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
    public partial class Local_Load : Form
    {
        public Local_Load()
        {
            InitializeComponent();
            CargarTablaLocal();
            CargarTipoComercio();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            txtNombreLocal.Text = "";
            cmbTipoComercio.SelectedIndex = -1;
            CargarTablaLocal();
        }

        private void CargarTipoComercio()
        {
            try
            {
                DataTable tabla = new DataTable();

                tabla = AD_TipoComercio.ObtenerTablaTipoComercioReducida();

                cmbTipoComercio.DataSource = tabla;
                cmbTipoComercio.DisplayMember = "NombreTipoComercio";
                cmbTipoComercio.ValueMember = "Tipo_Comercio";
                cmbTipoComercio.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Al Cargar Los Tipo Comercio");
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

                throw;
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

        private void btnCargarLocal_Click(object sender, EventArgs e)
        {
            if (txtNombreLocal.Text.Equals("") || cmbTipoComercio.SelectedValue == null)
            {
                MessageBox.Show("Ingrese los datos solicitados...");
            }
            else
            {
                Local l = ObtenerDatosLocal();
                try
                {
                    bool noBorrado = AD_Local.Buscar_Local(l);
                    if (noBorrado)
                    {
                        MessageBox.Show("Ya existe el Local que desea cargar...");
                        Clean();
                        txtNombreLocal.Focus();
                    }

                    else if (AD_Local.ExisteLocal(l))
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = ("Nombre Local: " + l.NombreLocal + "\nTipo Comercio: " + cmbTipoComercio.GetItemText(cmbTipoComercio.SelectedItem));

                        string titulo = "Información de Carga";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            bool resultado = AD_Local.Modificar_LocalANoBorrado(l);

                            if (resultado)
                            {
                                MessageBox.Show("Local agregado con éxito!");
                                Clean();
                                txtNombreLocal.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Error al cargar el Local");
                                txtNombreLocal.Focus();
                            }

                        }
                        else
                        {
                            txtNombreLocal.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = ("Nombre Local: " + l.NombreLocal + "\nTipo Comercio: " + cmbTipoComercio.GetItemText(cmbTipoComercio.SelectedItem));

                        string titulo = "Información de Carga";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            bool resultado = AD_Local.Agregar_Local(l);

                            if (resultado)
                            {
                                MessageBox.Show("Local agregado con éxito!");
                                Clean();
                                txtNombreLocal.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Error al cargar el Local");
                                txtNombreLocal.Focus();
                            }

                        }
                        else
                        {
                            txtNombreLocal.Focus();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar el Tipo Comercio.");
                }

            }


        }
    }
}
