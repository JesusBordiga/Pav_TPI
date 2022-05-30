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
            activarProducto(false);
            activarGuardado(false);
            activarDetalle(false);
            activarTabla(false);
            getNroFactura();
            cargarLocal();
            CargarTipoDocumento();
            cmbLocal.Focus();
        }
        private void Facturacion_Load(object sender, EventArgs e)
        {
            labelFechaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelNombreProducto.Text = "";
            labelPrecio.Text = "";
            labelCliente.Text = "";
            labelLocal.Text = "";
        }
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
        private void activarProducto(bool booleano)
        {
            textCodProducto.Enabled = booleano;
            btnBuscarProducto.Enabled = booleano;

        }
        private void activarDetalle(bool booleano)
        {
            textCantidad.Enabled = booleano;
            buttonCargarProducto.Enabled = booleano;

        }
        private void activarTabla(bool booleano)
        {
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
            if (comboBoxDocType.SelectedIndex == -1 || textNumeroDocumento.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos de cliente!!");
                comboBoxDocType.Focus();
            }
            else
            {

                Cliente c = AD_Facturacion.Buscar_Cliente_Documento(comboBoxDocType.SelectedValue.ToString(), textNumeroDocumento.Text);
                if (c != null)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    String mensajeCarga = ("Cliente encontrado!\n"
                        + "|Nombre y Apellido: " + c.NombreCliente.ToString() + " " + c.ApellidoCliente.ToString() + "\n"
                        + "Desea cargar este cliente?");

                    string titulo = "Cliente";

                    DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            labelCliente.Text = c.NombreCliente.ToString() + " " + c.ApellidoCliente.ToString();
                            activarCliente(false);
                            comboBoxDocType.Visible = false;
                            textNumeroDocumento.Visible = false;
                            labelTipoDoc.Text = comboBoxDocType.Text;
                            labelNroDoc.Text = textNumeroDocumento.Text.Trim();
                            CargarTarjeta(c.TipoDocumentoCliente, c.DocumentoCliente);
                            activarTarjeta(true);
                            comboTarjetaCliente.Focus();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Error, no se encontró cliente!!");
                        }

                    }
                    else
                    {
                        comboBoxDocType.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error, no se encontró cliente!!");
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
        private Tarjeta ObtenerDatosBuscar()
        {
            Tarjeta t = new Tarjeta();
            if (comboBoxDocType.SelectedIndex == -1)
            {
                t.NroTarjetaCliente = "";
            }
            else
            {
                t.NroTarjetaCliente = comboTarjetaCliente.SelectedValue.ToString();
            }
            t.NroDocumentoTarjeta = textNumeroDocumento.Text.Trim();
            return t;
        }
        private void buttonTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta t = ObtenerDatosBuscar();
            if (!t.NroTarjetaCliente.Equals(""))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = ("Tarjeta encontrada!\n"
                    + "Datos: " + comboTarjetaCliente.Text + "\n"
                    + "Desea cargar esta tarjeta?");

                string titulo = "Tarjeta";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    activarProducto(true);
                    activarTarjeta(false);
                    labelTarjeta.Text = comboTarjetaCliente.Text;
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
            Producto p = AD_Productos.Buscar_Producto(textCodProducto.Text.Trim());
            if (p != null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String mensajeCarga = ("Producto encontrado!\n"
                    + p.NombreProducto + "\n"
                    + "Desea cargar este producto?");

                string titulo = "Producto";

                DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        labelNombreProducto.Text = p.NombreProducto;
                        labelPrecio.Text = p.PrecioProducto.ToString();
                        activarProducto(false);
                        activarDetalle(true);
                        textCodProducto.Visible = false;
                        textCantidad.Focus();
                        labelCod.Text = textCodProducto.Text.Trim();
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
            else
            {
                MessageBox.Show("Error, no se pudo Obtener producto");
            }

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
        private ProductoFactura obtenerDatosProducto()
        {
            ProductoFactura p = new ProductoFactura();
            p.CodigoProducto = int.Parse(textCodProducto.Text.Trim());
            p.NombreProducto = labelNombreProducto.Text;
            p.PrecioProducto = float.Parse(labelPrecio.Text);
            p.CantidadProducto = int.Parse(textCantidad.Text.Trim());
            return p;
        }
        private void buttonCargarProducto_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = ("|Codigo: " + textCodProducto.Text + " " + "|Nombre: " + labelNombreProducto.Text + "|" + "\n"
                + "|Cantidad: " + "" + textCantidad.Text + "" + "|Precio: " + labelPrecio.Text + "|" + "\n"
                + "Desea cargar este producto?");
            string titulo = "Producto";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    if (tablaProducto.Rows.Count == 0)
                    {
                        activarTabla(true);
                        btnFactura.Enabled = true;
                    }
                    AgregarProducto(obtenerDatosProducto());
                    activarDetalle(false);
                    activarProducto(true);
                    labelNombreProducto.Text = "";
                    labelCod.Text = "";
                    textCodProducto.Visible = true;
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
        private void btnFactura_Click(object sender, EventArgs e)
        {
            int codLocal = (int)cmbLocal.SelectedValue;
            int tipoDoc = (int)comboBoxDocType.SelectedValue;
            int documento = int.Parse(textNumeroDocumento.Text);
            int numeroFactura = int.Parse(nroFactura.Text);
            string nroTarjeta = comboTarjetaCliente.SelectedValue.ToString();
            Factura factura = new Factura(codLocal, tipoDoc, documento, nroTarjeta, DateTime.Now);
            factura.DetallesFactura = getDetalles();
            cargarFactura(factura, numeroFactura);
            Close();
        }
        private Detalle[] getDetalles()
        {
            int largo = tablaProducto.Rows.Count;
            Detalle[] detalle = new Detalle[largo];
            for (int i = 0; i < largo; i++)
            {
                int codProducto = (int)tablaProducto.Rows[i].Cells["CodigoProducto"].Value;
                int cantidad = (int)tablaProducto.Rows[i].Cells["Cantidad"].Value;
                float precio = (float)tablaProducto.Rows[i].Cells["Precio"].Value * cantidad;
                Detalle fila = new Detalle(codProducto, cantidad, precio);
                detalle[i] = fila;
            }
            return detalle;
        }
        private bool cargarFactura(Factura factura, int nroFactura)
        {
            bool resultado = AD_Facturacion.cargarFactura(factura, nroFactura);
            if (resultado)
            {
                MessageBox.Show("Se cargó la factura exitosamente");
            }
            else
            {
                MessageBox.Show("Error, no se pudo cargar la factura");
            }
            return resultado;
        }
    }
}