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
    public partial class Facturacion_Load : Form
    {
        public Facturacion_Load()
        {
            InitializeComponent();
            activarLocal(true, Color.Silver, Color.Black);
            activarCliente(false, Color.Gray, Color.DimGray);
            activarTarjeta(false, Color.Gray, Color.DimGray);
            activarProducto(false, Color.Gray, Color.DimGray);
            activarGuardado(false, Color.Gray, Color.DimGray);
            activarDetalle(false, Color.Gray, Color.DimGray);
            activarTabla(false);
            getNroFactura();
            cargarLocal();
            CargarTipoDocumento();
            cmbLocal.Focus();
        }
        public static class activarModificacion
        {
            public static bool esModificacion = false;
            public static int indiceTabla = -1;
            public static bool EsModificacion
            {
                get { return esModificacion; }
                set { esModificacion = value; }
            }
            public static int IndiceTabla
            {
                get { return indiceTabla; }
                set { indiceTabla = value; }
            }
        }
        private void Facturacion_Load1(object sender, EventArgs e)
        {
            labelFechaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelNombreProducto.Text = "";
            labelPrecio.Text = "";
            labelCliente.Text = "";
            labelLocal.Text = "";
            
        }
        private void activarCliente(bool booleano, Color colorFondo, Color colorFuente)
        {
            comboBoxDocType.Enabled = booleano;
            textNumeroDocumento.Enabled = booleano;
            buttonCliente.Enabled = booleano;
            buttonCliente.BackColor = colorFondo;
            buttonCliente.ForeColor = colorFuente;
        }
        private void activarLocal(bool booleano, Color colorFondo, Color colorFuente)
        {
            cmbLocal.Enabled = booleano;
            buttonLocal.Enabled = booleano;
            buttonLocal.BackColor = colorFondo;
            buttonLocal.ForeColor = colorFuente;
        }
        private void activarTarjeta(bool booleano, Color colorFondo, Color colorFuente)
        {
            comboTarjetaCliente.Enabled = booleano;
            buttonTarjeta.Enabled = booleano;
            buttonTarjeta.BackColor = colorFondo;
            buttonTarjeta.ForeColor = colorFuente;
        }
        private void activarProducto(bool booleano, Color colorFondo, Color colorFuente)
        {
            textCodProducto.Enabled = booleano;
            btnBuscarProducto.Enabled = booleano;
            btnBuscarProducto.BackColor = colorFondo;
            btnBuscarProducto.ForeColor = colorFuente;

        }
        private void activarDetalle(bool booleano, Color colorFondo, Color colorFuente)
        {
            textCantidad.Enabled = booleano;
            buttonCargarProducto.Enabled = booleano;
            buttonCargarProducto.BackColor = colorFondo;
            buttonCargarProducto.ForeColor = colorFuente;

        }
        private void activarTabla(bool booleano)
        {
            tablaProducto.Enabled = booleano;
        }
        private void activarGuardado(bool booleano, Color colorFondo, Color colorFuente)
        {
            lblTotal.Visible = booleano;
            label19.Visible = booleano;
            btnFactura.Enabled = booleano;
            btnFactura.BackColor = colorFondo;
            btnFactura.ForeColor = colorFuente;
            btnEliminar.Enabled = booleano;
            btnEliminar.BackColor = colorFondo;
            btnEliminar.ForeColor = colorFuente;
            btnModificar.Enabled = booleano;
            btnModificar.BackColor = colorFondo;
            btnModificar.ForeColor= colorFuente; 
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
                activarLocal(false, Color.Gray, Color.DimGray);
                activarCliente(true, Color.Silver, Color.Black);
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
                            activarCliente(false, Color.Gray, Color.DimGray);
                            comboBoxDocType.Visible = false;
                            textNumeroDocumento.Visible = false;
                            labelTipoDoc.Text = comboBoxDocType.Text;
                            labelNroDoc.Text = textNumeroDocumento.Text.Trim();
                            CargarTarjeta(c.TipoDocumentoCliente, c.DocumentoCliente);
                            activarTarjeta(true, Color.Silver, Color.Black);
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
                    activarProducto(true, Color.Silver, Color.Black);
                    activarTarjeta(false, Color.Gray, Color.DimGray);
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
                        activarProducto(false, Color.Gray, Color.DimGray);
                        activarDetalle(true, Color.Silver, Color.Black);
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
        private void agregarProducto(ProductoFactura producto)
        {
            AgregarProducto(producto);
            activarDetalle(false, Color.Gray, Color.DimGray);
            activarProducto(true, Color.Silver, Color.Black);
            lblTotal.Text = calcularTotal();
            textCodProducto.Focus();
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
                        activarGuardado(true, Color.Silver, Color.Black);
                    }
                    ProductoFactura producto = obtenerDatosProducto();
                    if (!validarProductoEnTabla(producto.CodigoProducto))
                    {
                        agregarProducto(producto);
                    }
                    else if(activarModificacion.EsModificacion)
                    {
                        tablaProducto.Rows.RemoveAt(activarModificacion.IndiceTabla);
                        activarModificacion.esModificacion = false;
                        activarModificacion.indiceTabla = -1;
                        agregarProducto(producto);
                        activarGuardado(true, Color.Silver, Color.Black);
                    }
                    else
                    {
                        activarProducto(true, Color.Silver, Color.Black);
                        activarDetalle(false, Color.Gray, Color.DimGray);
                        MessageBox.Show("Error, el producto ya se encuentra en la factura");
                    }
                        labelNombreProducto.Text = "";
                        labelCod.Text = "";
                        textCodProducto.Visible = true;
                        labelPrecio.Text = "";
                        textCodProducto.Text = "";
                        textCantidad.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Error! Hubo un error");
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
        private string calcularTotal()
        {
            float total = 0;
            int largo = tablaProducto.Rows.Count;
            for (int i = 0; i < largo; i++)
            {
                int cantidad = (int)tablaProducto.Rows[i].Cells["Cantidad"].Value;
                float precio = (float)tablaProducto.Rows[i].Cells["Precio"].Value * cantidad;
                total += precio;
            }
            return total.ToString();
        }
        private string restarTotal(int indiceFila)
        {
            float total = int.Parse(lblTotal.Text);
            int cantidad = (int)tablaProducto.Rows[indiceFila].Cells["Cantidad"].Value;
            float precio = (float)tablaProducto.Rows[indiceFila].Cells["Precio"].Value * cantidad;
            total -= precio;
            return total.ToString();
        }
        private bool validarProductoEnTabla(int codProducto)
        {
            int largo = tablaProducto.Rows.Count;
            for (int i = 0; i < largo; i++)
            {
                if (codProducto.ToString().Equals(tablaProducto.Rows[i].Cells[0].Value.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var indiceFila = tablaProducto.CurrentRow.Index;
            string producto = tablaProducto.Rows[indiceFila].Cells[1].Value.ToString();
            string cantidad = tablaProducto.Rows[indiceFila].Cells[2].Value.ToString();
            string codProducto = tablaProducto.Rows[indiceFila].Cells[0].Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = ("Eliminar producto\n"
                + "Datos: \n"
                + "\tCodigo: " + codProducto + "\n"
                + "\tProducto: " + producto + "\n"
                + "\tCantidad: " + cantidad + "\n"
                + "Desea eliminar este producto?");

            string titulo = "Eliminar producto";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                restarTotal(indiceFila);
                tablaProducto.Rows.RemoveAt(indiceFila);
                MessageBox.Show("Se eliminó el producto");
            }
            if (tablaProducto.Rows.Count == 0)
            {
                activarGuardado(false, Color.Gray, Color.DimGray);
            }
            else
            {
                lblTotal.Text = calcularTotal();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            var indiceFila = tablaProducto.CurrentRow.Index;
            string producto = tablaProducto.Rows[indiceFila].Cells[1].Value.ToString();
            string cantidad = tablaProducto.Rows[indiceFila].Cells[2].Value.ToString();
            string codProducto = tablaProducto.Rows[indiceFila].Cells[0].Value.ToString();
            string precio = tablaProducto.Rows[indiceFila].Cells[3].Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            String mensajeCarga = ("Datos: \n"
                + "\tCodigo: " + codProducto + "\n"
                + "\tProducto: " + producto + "\n"
                + "\tCantidad: " + cantidad + "\n"
                + "Desea modificar este producto?");

            string titulo = "Modificar producto";

            DialogResult result = MessageBox.Show(mensajeCarga, titulo, buttons);

            if (result == DialogResult.OK)
            {
                activarDetalle(true, Color.Silver, Color.Black);
                activarProducto(false, Color.Gray, Color.DimGray);
                activarGuardado(false, Color.Gray, Color.DimGray);
                textCodProducto.Visible = false;
                textCodProducto.Text = codProducto;
                labelCod.Text = codProducto;
                labelNombreProducto.Text = producto;
                labelPrecio.Text = precio;
                activarModificacion.EsModificacion = true;
                activarModificacion.indiceTabla = indiceFila;
                restarTotal(indiceFila);
            }
        }
    }
}