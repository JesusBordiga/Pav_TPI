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
using Shopping_Buy_All.ABMS.AccesoADatos;

namespace Shopping_Buy_All
{
    public partial class Facturacion_Ventana : Form
    {
        public Facturacion_Ventana()
        {
            InitializeComponent();
        }
        private void Facturacion_Load(object sender, EventArgs e)
        {
            
            CargarTipoDocumento();
            comboBoxDocType.Enabled = false;
            textNumeroDocumento.Enabled = false;
            buttonCliente.Enabled = false;
            comboTarjetaCliente.Enabled = false;
            textCodProducto.Enabled = false;
            btnBuscarProducto.Enabled = false;
            textCantidad.Enabled = false;
            labelFechaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelNombrePorducto.Text = "";
            labelPrecio.Text = "";
            labelCliente.Text = "";
            labelLocal.Text = "";
            textNumberLocal.Focus();

        }
        private void CargarTipoDocumento()
        {
            try
            {
                comboBoxDocType.DataSource = AD_Cliente.ObtenerTipoDocumento();
                comboBoxDocType.DisplayMember = "NombreDocumento";
                comboBoxDocType.ValueMember = "TipoDocumento";
                comboBoxDocType.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Obtener Datos de Tipos de Documentos");
            }
        }
        private Tarjeta ObtenerDatosBuscar()
        {
            Tarjeta t = new Tarjeta();
            if (comboBoxDocType.SelectedIndex == -1)
            {
                t.TipoDocumentoTarjeta = 0;
            }
            else
            {
                t.TipoDocumentoTarjeta = (int)comboBoxDocType.SelectedValue;
            }
            t.NroDocumentoTarjeta = textNumeroDocumento.Text.Trim();
            return t;
        }

        private void buttonLocal_Click(object sender, EventArgs e)
        {
            if (!textNumberLocal.Text.Equals(""))
            {
                try
                {
                    Local l = AD_Local.Buscar_LocalPorCodigo(textNumberLocal.Text.Trim());
                    if (l.NombreLocal != null)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        String mensajeCarga = ("Local encontrado!\n"
                            +"Nombre: "+ l.NombreLocal.ToString()+"\n"
                            + "Desea cargar este local?");

                        string titulo = "Local";

                        DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                        if (result == DialogResult.OK)
                        {
                                labelLocal.Text = l.NombreLocal;
                                comboBoxDocType.Enabled = true;
                                textNumeroDocumento.Enabled = true;
                                buttonCliente.Enabled = true;
                                comboBoxDocType.Focus();
                        }
                        else
                        {
                            textNumberLocal.Focus();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Local no encontrado");
                        textNumberLocal.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al buscar el Local");
                }

            }
        }

        public void buttonCliente_Click(object sender, EventArgs e)
        {
            if (comboBoxDocType.SelectedIndex != 0 && textNumeroDocumento .Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos de cliente!!");
                comboBoxDocType.Focus();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = ("Cliente encontrado!\n"
                    +"Desea cargar este cliente?");

                string titulo = "Cliente";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                        Cliente c = AD_Facturacion.Buscar_Cliente_Documento(comboBoxDocType.SelectedValue.ToString(), textNumeroDocumento.Text);
                        labelCliente.Text = c.NombreCliente.ToString() + " " + c.ApellidoCliente.ToString();
                        comboTarjetaCliente.Enabled = true;
                        comboTarjetaCliente.Focus();
                }
                else
                {
                    comboBoxDocType.Focus();
                }
            }

            

        }
        private void CargarTarjeta()
        {
            try
            {
                comboBoxDocType.DataSource = AD_Cliente.ObtenerTipoDocumento();
                comboBoxDocType.DisplayMember = "NombreDocumento";
                comboBoxDocType.ValueMember = "TipoDocumento";
                comboBoxDocType.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Obtener Datos de Tipos de Documentos");
            }
        }

        private void buttonTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta t = ObtenerDatosBuscar();
            if (AD_Facturacion.Buscar_Tarjeta(t)!=null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = ("Tarjeta encontrada!\n"
                    + "Nombre: "+"\n"
                    +"Desea cargar esta tarjeta?");

                string titulo = "Tarjeta";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    textCodProducto.Enabled = false;
                    btnBuscarProducto.Enabled = false;
                    textCodProducto.Focus();
                }
                else
                {
                    comboTarjetaCliente.Focus();
                }
  
            }
            else
            {
                MessageBox.Show("Error, Al seleccionar tarjeta!!");
                comboTarjetaCliente.Focus();
            }
            textCodProducto.Enabled = true;
            textCodProducto.Focus();
            btnBuscarProducto.Enabled = true;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = ("Producto encontrado!\n"
                +"Desea cargar este prodcuto?");

            string titulo = "Producto";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                try
                {
                    Producto p = AD_Productos.Buscar_Producto(textCodProducto.Text.Trim());
                    labelNombrePorducto.Text = p.NombreProducto;
                    labelPrecio.Text = p.PrecioProducto.ToString();
                    textCantidad.Enabled = true;
                    textCantidad.Focus();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error, no se pudo Obtener producto");
                }
            }
            else
            {
                textCodProducto.Focus();
            }
        }

        private void buttonCargarProducto_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = ("|Codigo: "+textCodProducto.Text+" "+"|Nombre: "+labelNombrePorducto.Text+"|"+"\n"
                +"|Cantidad: "+""+textCantidad.Text +""+ "|Precio: "+labelPrecio.Text+"|"+"\n"
                +"Desea cargar este producto?");
            string titulo = "Producto";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    AgregarProducto(obtenerDatosProducto());
                    labelNombrePorducto.Text = "";
                    labelPrecio.Text = "";
                    textCodProducto.Text = "";
                    textCantidad.Text = "";
                    textCodProducto.Focus();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error, no se pudo Obtener producto");
                }
            }
            else
            {
                textCodProducto.Focus();
            }
            
        }

        private ProductoFactura obtenerDatosProducto()
        {
            ProductoFactura p = new ProductoFactura();
            p.CodigoProducto = int.Parse(textCodProducto.Text.Trim());
            p.NombreProducto = labelNombrePorducto.Text;
            p.PrecioProducto = float.Parse(labelPrecio.Text);
            p.CantidadProducto = int.Parse(textCantidad.Text.Trim());
            return p;
        }
        public void AgregarProducto(ProductoFactura prod)
        {
            DataGridViewRow fila = new DataGridViewRow();
            //Agregar Codigo
            DataGridViewTextBoxCell CodigoProducto = new DataGridViewTextBoxCell();
            CodigoProducto.Value = prod.CodigoProducto;
            fila.Cells.Add(CodigoProducto);
            //Agregar nombre
            DataGridViewTextBoxCell NombreProducto = new DataGridViewTextBoxCell();
            NombreProducto.Value = prod.NombreProducto;
            fila.Cells.Add(NombreProducto);
            //Agregar Fecha
            DataGridViewTextBoxCell Cantidad = new DataGridViewTextBoxCell();
            Cantidad.Value = prod.CantidadProducto;
            fila.Cells.Add(Cantidad);
            //Agregar Carrera
            DataGridViewTextBoxCell Precio = new DataGridViewTextBoxCell();
            Precio.Value = prod.PrecioProducto;
            fila.Cells.Add(Precio);
            //Agregar Fila
            tablaProducto.Rows.Add(fila);
        }
    }
}
