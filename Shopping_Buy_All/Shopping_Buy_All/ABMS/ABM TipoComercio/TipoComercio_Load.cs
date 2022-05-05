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
    public partial class TipoComercio_Load : Form
    {
        
        public TipoComercio_Load()
        {
            InitializeComponent();
            CargarTablaTipoComercio();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            
            txtNombreTipoComercio.Text = "";
            
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

                throw;
            }
            
        }
        private TipoComercio ObtenerDatosTipoComercio()
        {
            TipoComercio comercio = new TipoComercio();
            
            //Nombre de Tipo Comercio
            comercio.NombreTipoComercio = txtNombreTipoComercio.Text.Trim();
 
            return comercio;
        }

        private void btnCargarTipoComercio_Click(object sender, EventArgs e)
        {
            if (txtNombreTipoComercio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos solicitados...");
            }
            else
            {
                TipoComercio comercio = ObtenerDatosTipoComercio();
                try
                {
                    bool noBorrado = AD_TipoComercio.Buscar_TipoComercio(comercio.NombreTipoComercio);
                    if (noBorrado)
                    {
                        MessageBox.Show("Ya existe el Tipo Comercio que desea cargar...");
                        Clean();
                        txtNombreTipoComercio.Focus();

                    }
                    else if (AD_TipoComercio.ExisteTipoComercio(comercio.NombreTipoComercio))
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = ("Nombre Tipo Comercio: " + comercio.NombreTipoComercio);

                        string titulo = "Información de Carga";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            bool resultado = AD_TipoComercio.Modificar_TipoComercio(comercio);

                            if (resultado)
                            {
                                MessageBox.Show("Tipo Comercio agregado con éxito!");
                                Clean();
                            }
                            else
                            {
                                MessageBox.Show("Error al cargar el TipoComercio! \n" +
                                        "Complete los campos por favor!");
                            }

                        }
                        else
                        {
                            txtNombreTipoComercio.Focus();
                        }
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = ("Nombre Tipo Comercio: " + comercio.NombreTipoComercio);

                        string titulo = "Información de Carga";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                            bool resultado = AD_TipoComercio.Agregar_TipoComercio(comercio);

                            if (resultado)
                            {
                                MessageBox.Show("Tipo Comercio agregado con éxito!");
                                Clean();
                            }
                            else
                            {
                                MessageBox.Show("Error al cargar el TipoComercio! \n" +
                                        "Complete los campos por favor!");
                            }
                            
                        }
                        else
                        {
                            txtNombreTipoComercio.Focus();
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
