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
        AD_Facturacion _accesoADatos = new AD_Facturacion();
        AD_Productos _datosProductos = new AD_Productos();
        public Facturacion_Load()
        {
            InitializeComponent();
            ActivarLocal(true, Color.Silver, Color.Black);
            ActivarCliente(false, Color.Gray, Color.DimGray);
            ActivarTarjeta(false, Color.Gray, Color.DimGray);
            ActivarProducto(false, Color.Gray, Color.DimGray);
            ActivarGuardado(false, Color.Gray, Color.DimGray);
            ActivarDetalle(false, Color.Gray, Color.DimGray);
            ActivarTabla(false);
            getNroFactura();
            CargarLocal();
            CargarTipoDocumento();
            cmbLocal.Focus();
        }
        public static class ActivarModificacion
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
        private void ActivarCliente(bool booleano, Color colorFondo, Color colorFuente)
        {
            comboBoxDocType.Enabled = booleano;
            textNumeroDocumento.Enabled = booleano;
            buttonCliente.Enabled = booleano;
            buttonCliente.BackColor = colorFondo;
            buttonCliente.ForeColor = colorFuente;
        }
        private void ActivarLocal(bool booleano, Color colorFondo, Color colorFuente)
        {
            cmbLocal.Enabled = booleano;
            buttonLocal.Enabled = booleano;
            buttonLocal.BackColor = colorFondo;
            buttonLocal.ForeColor = colorFuente;
        }
        private void ActivarTarjeta(bool booleano, Color colorFondo, Color colorFuente)
        {
            comboTarjetaCliente.Enabled = booleano;
            buttonTarjeta.Enabled = booleano;
            buttonTarjeta.BackColor = colorFondo;
            buttonTarjeta.ForeColor = colorFuente;
        }
        private void ActivarProducto(bool booleano, Color colorFondo, Color colorFuente)
        {
            textCodProducto.Enabled = booleano;
            btnBuscarProducto.Enabled = booleano;
            btnBuscarProducto.BackColor = colorFondo;
            btnBuscarProducto.ForeColor = colorFuente;

        }
        private void ActivarDetalle(bool booleano, Color colorFondo, Color colorFuente)
        {
            textCantidad.Enabled = booleano;
            buttonCargarProducto.Enabled = booleano;
            buttonCargarProducto.BackColor = colorFondo;
            buttonCargarProducto.ForeColor = colorFuente;

        }
        private void ActivarTabla(bool booleano)
        {
            tablaProducto.Enabled = booleano;
        }
        private void ActivarGuardado(bool booleano, Color colorFondo, Color colorFuente)
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
            btnModificar.ForeColor = colorFuente;
        }
        private void CargarLocal()
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

        /// <summary>
        /// Obtiene el próximo nro de factura a cargar
        /// </summary>
        private void getNroFactura()
        {
            DataTable respuestaDB = _accesoADatos.getNroFactura();
            int nroFac = (int)respuestaDB.Rows[0]["MaxNum"] + 1;
            nroFactura.Text = nroFac.ToString();
        }
        /// <summary>
        /// Una vez cargado el local habilita el siguiente paso de la carga de la factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLocal_Click(object sender, EventArgs e)
        {
            if (!cmbLocal.SelectedIndex.Equals(-1))
            {
                ActivarLocal(false, Color.Gray, Color.DimGray);
                ActivarCliente(true, Color.Silver, Color.Black);
                labelLocal.Text = cmbLocal.Text;
            }
            else
            {
                MessageBox.Show("No seleccionó un local");
            }
        }

        /// <summary>
        /// Una vez cargado el cliente habilita el siguiente paso de la carga de la factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCliente_Click(object sender, EventArgs e)
        {
            if (comboBoxDocType.SelectedIndex == -1 || textNumeroDocumento.Text.Equals(""))
            {
                MessageBox.Show("Error, Completar campos de cliente!!");
                comboBoxDocType.Focus();
            }
            else
            {
                DataTable tablaCliente = _accesoADatos.Buscar_Cliente_Documento(comboBoxDocType.SelectedValue.ToString(), textNumeroDocumento.Text);
                if (tablaCliente.Rows.Count == 1)
                {
                    Cliente c = new Cliente();
                    c.TipoDocumentoCliente = (int)tablaCliente.Rows[0]["TipoDoc"];
                    c.DocumentoCliente = tablaCliente.Rows[0]["NroDocumento"].ToString();
                    c.ApellidoCliente = tablaCliente.Rows[0]["Apellido"].ToString();
                    c.NombreCliente = tablaCliente.Rows[0]["Nombres"].ToString();
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
                                ActivarCliente(false, Color.Gray, Color.DimGray);
                                comboBoxDocType.Visible = false;
                                textNumeroDocumento.Visible = false;
                                labelTipoDoc.Text = comboBoxDocType.Text;
                                labelNroDoc.Text = textNumeroDocumento.Text.Trim();
                                CargarTarjeta(c.TipoDocumentoCliente, c.DocumentoCliente);
                                ActivarTarjeta(true, Color.Silver, Color.Black);
                                comboTarjetaCliente.Focus();
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("Error, no se encontró cliente!!");
                            }
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

        /// <summary>
        /// obtiene los datos de la tarjeta
        /// </summary>
        /// <param name="tipoDoc"></param>
        /// <param name="nroDoc"></param>
        private void CargarTarjeta(int tipoDoc, string nroDoc)
        {
            try
            {
                comboTarjetaCliente.DataSource = _accesoADatos.getTarjetaCliente(tipoDoc, nroDoc);
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

        /// <summary>
        /// Una vez seleccionada la tarjeta habilita el siguiente paso de la carga de la factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTarjeta_Click(object sender, EventArgs e)
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
                    ActivarProducto(true, Color.Silver, Color.Black);
                    ActivarTarjeta(false, Color.Gray, Color.DimGray);
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
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            DataTable producto = _datosProductos.Buscar_Producto(textCodProducto.Text.Trim());
            if (producto.Rows.Count == 1)
            {
                Producto p = new Producto();
                p.NombreProducto = producto.Rows[0]["NombreProducto"].ToString();
                p.CodigoProducto = (int)producto.Rows[0]["Codigo_Producto"];
                p.PrecioProducto = (float)Convert.ToDouble(producto.Rows[0]["Precio"]);
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
                            ActivarProducto(false, Color.Gray, Color.DimGray);
                            ActivarDetalle(true, Color.Silver, Color.Black);
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
            }
            else
            {
                MessageBox.Show("Error, no se pudo Obtener producto");
            }

        }

        /// <summary>
        /// Obtiene los datos del producto
        /// </summary>
        /// <returns></returns>
        private ProductoFactura ObtenerDatosProducto()
        {
            ProductoFactura p = new ProductoFactura();
            p.CodigoProducto = int.Parse(textCodProducto.Text.Trim());
            p.NombreProducto = labelNombreProducto.Text;
            p.PrecioProducto = float.Parse(labelPrecio.Text);
            p.CantidadProducto = int.Parse(textCantidad.Text.Trim());
            return p;
        }

        /// <summary>
        /// Agrega un producto a la tabla
        /// </summary>
        /// <param name="producto"></param>
        private void AgregarProducto(ProductoFactura producto)
        {
            DataGridViewRow fila = new DataGridViewRow();
            //Agregar Codigo
            DataGridViewTextBoxCell CodigoProducto = new DataGridViewTextBoxCell();
            CodigoProducto.Value = producto.CodigoProducto;
            fila.Cells.Add(CodigoProducto);
            //Agregar nombre
            DataGridViewTextBoxCell NombreProducto = new DataGridViewTextBoxCell();
            NombreProducto.Value = producto.NombreProducto;
            fila.Cells.Add(NombreProducto);
            //Agregar Fecha
            DataGridViewTextBoxCell Cantidad = new DataGridViewTextBoxCell();
            Cantidad.Value = producto.CantidadProducto;
            fila.Cells.Add(Cantidad);
            //Agregar Carrera
            DataGridViewTextBoxCell Precio = new DataGridViewTextBoxCell();
            Precio.Value = producto.PrecioProducto;
            fila.Cells.Add(Precio);
            //Agregar Fila
            tablaProducto.Rows.Add(fila);
            ActivarDetalle(false, Color.Gray, Color.DimGray);
            ActivarProducto(true, Color.Silver, Color.Black);
            lblTotal.Text = CalcularTotal();
            textCodProducto.Focus();
        }

        /// <summary>
        /// Añade un producto al detalle de la factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCargarProducto_Click(object sender, EventArgs e)
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
                        ActivarTabla(true);
                        btnFactura.Enabled = true;
                        ActivarGuardado(true, Color.Silver, Color.Black);
                    }
                    ProductoFactura producto = ObtenerDatosProducto();
                    if (!ValidarProductoEnTabla(producto.CodigoProducto))
                    {
                        AgregarProducto(producto);
                    }
                    else if (ActivarModificacion.EsModificacion)
                    {
                        tablaProducto.Rows.RemoveAt(ActivarModificacion.IndiceTabla);
                        ActivarModificacion.esModificacion = false;
                        ActivarModificacion.indiceTabla = -1;
                        AgregarProducto(producto);
                        ActivarGuardado(true, Color.Silver, Color.Black);
                    }
                    else
                    {
                        ActivarProducto(true, Color.Silver, Color.Black);
                        ActivarDetalle(false, Color.Gray, Color.DimGray);
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

        /// <summary>
        /// Crea el objeto factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFactura_Click(object sender, EventArgs e)
        {
            int codLocal = (int)cmbLocal.SelectedValue;
            int tipoDoc = (int)comboBoxDocType.SelectedValue;
            int documento = int.Parse(textNumeroDocumento.Text);
            int numeroFactura = int.Parse(nroFactura.Text);
            string nroTarjeta = comboTarjetaCliente.SelectedValue.ToString();
            Factura factura = new Factura(codLocal, tipoDoc, documento, nroTarjeta, DateTime.Now);
            factura.DetallesFactura = GetDetalles();
            CargarFactura(factura, numeroFactura);
            Close();
        }

        /// <summary>
        /// Crea un array de detalles obteniéndolos desde la tabla
        /// </summary>
        /// <returns></returns>
        private Detalle[] GetDetalles()
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

        /// <summary>
        /// Carga la factura en la DB
        /// </summary>
        /// <param name="factura"></param>
        /// <param name="nroFactura"></param>
        /// <returns></returns>
        private bool CargarFactura(Factura factura, int nroFactura)
        {
            bool resultado = _accesoADatos.cargarFactura(factura, nroFactura);
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

        /// <summary>
        /// Calcula el total de la factura
        /// </summary>
        /// <returns></returns>
        private string CalcularTotal()
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

        /// <summary>
        /// Resta el precio de un producto del total de la factura
        /// </summary>
        /// <param name="indiceFila"></param>
        /// <returns></returns>
        private string RestarTotal(int indiceFila)
        {
            float total = int.Parse(lblTotal.Text);
            int cantidad = (int)tablaProducto.Rows[indiceFila].Cells["Cantidad"].Value;
            float precio = (float)tablaProducto.Rows[indiceFila].Cells["Precio"].Value * cantidad;
            total -= precio;
            return total.ToString();
        }

        /// <summary>
        /// Verifica si un producto se encuentra entre los detalles
        /// </summary>
        /// <param name="codProducto"></param>
        /// <returns></returns>
        private bool ValidarProductoEnTabla(int codProducto)
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

        /// <summary>
        /// Elimina uno de los detalles de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminar_Click(object sender, EventArgs e)
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
                RestarTotal(indiceFila);
                tablaProducto.Rows.RemoveAt(indiceFila);
                MessageBox.Show("Se eliminó el producto");
            }
            if (tablaProducto.Rows.Count == 0)
            {
                ActivarGuardado(false, Color.Gray, Color.DimGray);
            }
            else
            {
                lblTotal.Text = CalcularTotal();
            }
        }
        /// <summary>
        /// Modifica uno de los detalles de la factura elegidos desde la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModificar_Click(object sender, EventArgs e)
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
                ActivarDetalle(true, Color.Silver, Color.Black);
                ActivarProducto(false, Color.Gray, Color.DimGray);
                ActivarGuardado(false, Color.Gray, Color.DimGray);
                textCodProducto.Visible = false;
                textCodProducto.Text = codProducto;
                labelCod.Text = codProducto;
                labelNombreProducto.Text = producto;
                labelPrecio.Text = precio;
                ActivarModificacion.EsModificacion = true;
                ActivarModificacion.indiceTabla = indiceFila;
                RestarTotal(indiceFila);
            }
        }
    }
}