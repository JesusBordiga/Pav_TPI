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
            activarLocal(true);
            activarCliente(false);
            activarTarjeta(false);
            activarDetalle(false);
            activarGuardado(false);
            getNroFactura();
            cargarLocal();
            CargarTipoDocumento();
        }
        private void Facturacion_Load(object sender, EventArgs e)
        {
            CargarTipoDocumento();
            textCodProducto.Enabled = false;
            btnBuscarProducto.Enabled = false;
            textCantidad.Enabled = false;
            labelFechaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelNombrePorducto.Text = "";
            labelPrecio.Text = "";
            labelCliente.Text = "";
            labelLocal.Text = "";
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
        
        /*
        */

        private void activarCliente(bool booleano)
        {
            comboBoxDocType.Enabled = booleano;
            textNumeroDocumento.Enabled = booleano;
            buttonCliente.Enabled = booleano;
        }
        private void activarLocal(bool booleano)
        {
            cmbLocal.Enabled = booleano;
            buttonLocal.Enabled = booleano;
        }
        private void activarTarjeta(bool booleano)
        {
            comboTarjetaCliente.Enabled = booleano;
            buttonTarjeta.Enabled = booleano;
        }
        private void activarDetalle(bool booleano)
        {
            textCodProducto.Enabled = booleano;
            btnBuscarProducto.Enabled = booleano;
            textCantidad.Enabled = booleano;
            buttonCargarProducto.Enabled = booleano;
            tablaProducto.Enabled = booleano;
        }
        private void activarGuardado(bool booleano)
        {
            btnFactura.Enabled = booleano;
        }
        private void cargarLocal()
        {
            try
            {
                cmbLocal.DataSource = AD_Local.ObtenerTablaLocalReducida();
                cmbLocal.DisplayMember = "Nombre";
                cmbLocal.ValueMember = "CodigoLocal";
                cmbLocal.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, no se pudieron obtener los datos de los locales");
            }
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
        private void getNroFactura()
        {
            string pou = AD_Facturacion.getNroFactura().ToString();
            if (!pou.Equals("-1"))
            {
                nroFactura.Text = pou;
            }
            else
            {
                MessageBox.Show("No se pudo obtener un numero para la factura");
            }
        }
        private void buttonLocal_Click(object sender, EventArgs e)
        {
            if (!cmbLocal.SelectedIndex.Equals(-1))
            {
                activarLocal(false);
                activarCliente(true);
                labelLocal.Text = cmbLocal.Text;
            }
            else
            {
                MessageBox.Show("No seleccionó un local");
            }         
        }
        public void buttonCliente_Click(object sender, EventArgs e)
        {
            if (comboBoxDocType.SelectedIndex != 0 || textNumeroDocumento .Text.Equals(""))
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
                    activarCliente(false);
                    CargarTarjeta(c.TipoDocumentoCliente, c.DocumentoCliente);
                    activarTarjeta(true);
                    comboTarjetaCliente.Focus();
                }
                else
                {
                    comboBoxDocType.Focus();
                }
            }
        }
        private void CargarTarjeta(int tipoDoc, string nroDoc)
        {
            try
            {
                comboTarjetaCliente.DataSource = AD_Facturacion.getTarjetaCliente(tipoDoc, nroDoc);
                comboTarjetaCliente.DisplayMember = "Tarjeta";
                comboTarjetaCliente.ValueMember = "NroTarjeta";
                comboTarjetaCliente.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se pudo Obtener Datos de Tipos de Documentos");
            }
        }
    }
}
