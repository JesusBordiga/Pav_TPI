namespace Shopping_Buy_All
{
    partial class Facturacion_Ventana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion_Ventana));
            this.label1 = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.fechaCompra = new System.Windows.Forms.Panel();
            this.labelFechaCompra = new System.Windows.Forms.Label();
            this.nroFactura = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDetalle = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnFactura = new System.Windows.Forms.Button();
            this.buttonCargarProducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tablaProducto = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textCodProducto = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelNombreProducto = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.buttonTarjeta = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboTarjetaCliente = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textNumeroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.labelTarjeta = new System.Windows.Forms.Label();
            this.labelNroDoc = new System.Windows.Forms.Label();
            this.labelTipoDoc = new System.Windows.Forms.Label();
            this.grbLocal = new System.Windows.Forms.GroupBox();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLocal = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.fechaCompra.SuspendLayout();
            this.grbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).BeginInit();
            this.grbCliente.SuspendLayout();
            this.grbLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura";
            // 
            // fechaCompra
            // 
            this.fechaCompra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fechaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fechaCompra.Controls.Add(this.labelFechaCompra);
            this.fechaCompra.Controls.Add(this.nroFactura);
            this.fechaCompra.Controls.Add(this.label11);
            this.fechaCompra.Controls.Add(this.label2);
            this.fechaCompra.Controls.Add(this.label1);
            this.fechaCompra.Controls.Add(this.grbDetalle);
            this.fechaCompra.Controls.Add(this.grbCliente);
            this.fechaCompra.Controls.Add(this.grbLocal);
            this.fechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCompra.Location = new System.Drawing.Point(9, 10);
            this.fechaCompra.Name = "fechaCompra";
            this.fechaCompra.Size = new System.Drawing.Size(588, 677);
            this.fechaCompra.TabIndex = 2;
            // 
            // labelFechaCompra
            // 
            this.labelFechaCompra.AutoSize = true;
            this.labelFechaCompra.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCompra.ForeColor = System.Drawing.Color.White;
            this.labelFechaCompra.Location = new System.Drawing.Point(450, 37);
            this.labelFechaCompra.Name = "labelFechaCompra";
            this.labelFechaCompra.Size = new System.Drawing.Size(96, 17);
            this.labelFechaCompra.TabIndex = 40;
            this.labelFechaCompra.Text = "dd/mm/aaaa";
            // 
            // nroFactura
            // 
            this.nroFactura.AutoSize = true;
            this.nroFactura.BackColor = System.Drawing.Color.Transparent;
            this.nroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroFactura.ForeColor = System.Drawing.Color.White;
            this.nroFactura.Location = new System.Drawing.Point(119, 45);
            this.nroFactura.Name = "nroFactura";
            this.nroFactura.Size = new System.Drawing.Size(71, 17);
            this.nroFactura.TabIndex = 39;
            this.nroFactura.Text = "#######";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Factura nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(435, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de compra";
            // 
            // grbDetalle
            // 
            this.grbDetalle.Controls.Add(this.btnEliminar);
            this.grbDetalle.Controls.Add(this.btnModificar);
            this.grbDetalle.Controls.Add(this.lblTotal);
            this.grbDetalle.Controls.Add(this.label19);
            this.grbDetalle.Controls.Add(this.btnFactura);
            this.grbDetalle.Controls.Add(this.buttonCargarProducto);
            this.grbDetalle.Controls.Add(this.label6);
            this.grbDetalle.Controls.Add(this.tablaProducto);
            this.grbDetalle.Controls.Add(this.label9);
            this.grbDetalle.Controls.Add(this.textCantidad);
            this.grbDetalle.Controls.Add(this.label5);
            this.grbDetalle.Controls.Add(this.label10);
            this.grbDetalle.Controls.Add(this.textCodProducto);
            this.grbDetalle.Controls.Add(this.label16);
            this.grbDetalle.Controls.Add(this.btnBuscarProducto);
            this.grbDetalle.Controls.Add(this.labelPrecio);
            this.grbDetalle.Controls.Add(this.label14);
            this.grbDetalle.Controls.Add(this.labelNombreProducto);
            this.grbDetalle.Controls.Add(this.labelCod);
            this.grbDetalle.Location = new System.Drawing.Point(19, 258);
            this.grbDetalle.Name = "grbDetalle";
            this.grbDetalle.Size = new System.Drawing.Size(549, 404);
            this.grbDetalle.TabIndex = 56;
            this.grbDetalle.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(387, 374);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 24);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(306, 374);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 24);
            this.btnModificar.TabIndex = 61;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(85, 374);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 17);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "#######";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(22, 374);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 59;
            this.label19.Text = "Total: $";
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.Silver;
            this.btnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.Black;
            this.btnFactura.Location = new System.Drawing.Point(468, 374);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(75, 24);
            this.btnFactura.TabIndex = 48;
            this.btnFactura.Text = "Aceptar";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // buttonCargarProducto
            // 
            this.buttonCargarProducto.BackColor = System.Drawing.Color.Silver;
            this.buttonCargarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCargarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarProducto.ForeColor = System.Drawing.Color.Black;
            this.buttonCargarProducto.Location = new System.Drawing.Point(468, 48);
            this.buttonCargarProducto.Name = "buttonCargarProducto";
            this.buttonCargarProducto.Size = new System.Drawing.Size(75, 24);
            this.buttonCargarProducto.TabIndex = 11;
            this.buttonCargarProducto.Text = "Cargar";
            this.buttonCargarProducto.UseVisualStyleBackColor = false;
            this.buttonCargarProducto.Click += new System.EventHandler(this.buttonCargarProducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, -6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Detalle";
            // 
            // tablaProducto
            // 
            this.tablaProducto.AllowUserToAddRows = false;
            this.tablaProducto.AllowUserToDeleteRows = false;
            this.tablaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProducto.BackgroundColor = System.Drawing.Color.DimGray;
            this.tablaProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.NombreProducto,
            this.Cantidad,
            this.Precio});
            this.tablaProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.tablaProducto.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaProducto.Location = new System.Drawing.Point(23, 116);
            this.tablaProducto.MultiSelect = false;
            this.tablaProducto.Name = "tablaProducto";
            this.tablaProducto.ReadOnly = true;
            this.tablaProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProducto.RowHeadersVisible = false;
            this.tablaProducto.RowHeadersWidth = 10;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tablaProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProducto.Size = new System.Drawing.Size(504, 252);
            this.tablaProducto.TabIndex = 42;
            this.tablaProducto.TabStop = false;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.DataPropertyName = "Codigo_Producto";
            this.CodigoProducto.FillWeight = 60F;
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.FillWeight = 250F;
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.FillWeight = 60F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.FillWeight = 70F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cod producto";
            // 
            // textCantidad
            // 
            this.textCantidad.BackColor = System.Drawing.Color.White;
            this.textCantidad.ForeColor = System.Drawing.Color.Black;
            this.textCantidad.Location = new System.Drawing.Point(236, 46);
            this.textCantidad.Mask = "9999";
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(32, 23);
            this.textCantidad.TabIndex = 10;
            this.textCantidad.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(212, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(324, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Precio";
            // 
            // textCodProducto
            // 
            this.textCodProducto.BackColor = System.Drawing.Color.White;
            this.textCodProducto.ForeColor = System.Drawing.Color.Black;
            this.textCodProducto.Location = new System.Drawing.Point(28, 46);
            this.textCodProducto.Mask = "99999999";
            this.textCodProducto.Name = "textCodProducto";
            this.textCodProducto.Size = new System.Drawing.Size(84, 23);
            this.textCodProducto.TabIndex = 8;
            this.textCodProducto.ValidatingType = typeof(int);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(307, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 47;
            this.label16.Text = "$";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(118, 45);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 24);
            this.btnBuscarProducto.TabIndex = 9;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(321, 48);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(63, 15);
            this.labelPrecio.TabIndex = 44;
            this.labelPrecio.Text = "$$$$$$$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 17);
            this.label14.TabIndex = 45;
            this.label14.Text = "Nombre producto";
            // 
            // labelNombreProducto
            // 
            this.labelNombreProducto.AutoSize = true;
            this.labelNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProducto.ForeColor = System.Drawing.Color.White;
            this.labelNombreProducto.Location = new System.Drawing.Point(25, 92);
            this.labelNombreProducto.Name = "labelNombreProducto";
            this.labelNombreProducto.Size = new System.Drawing.Size(134, 17);
            this.labelNombreProducto.TabIndex = 46;
            this.labelNombreProducto.Text = "##############";
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.BackColor = System.Drawing.Color.Transparent;
            this.labelCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCod.ForeColor = System.Drawing.Color.White;
            this.labelCod.Location = new System.Drawing.Point(46, 49);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(32, 15);
            this.labelCod.TabIndex = 54;
            this.labelCod.Text = "Cod";
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.buttonTarjeta);
            this.grbCliente.Controls.Add(this.label13);
            this.grbCliente.Controls.Add(this.comboTarjetaCliente);
            this.grbCliente.Controls.Add(this.label12);
            this.grbCliente.Controls.Add(this.label3);
            this.grbCliente.Controls.Add(this.label7);
            this.grbCliente.Controls.Add(this.label8);
            this.grbCliente.Controls.Add(this.buttonCliente);
            this.grbCliente.Controls.Add(this.comboBoxDocType);
            this.grbCliente.Controls.Add(this.labelCliente);
            this.grbCliente.Controls.Add(this.textNumeroDocumento);
            this.grbCliente.Controls.Add(this.labelTarjeta);
            this.grbCliente.Controls.Add(this.labelNroDoc);
            this.grbCliente.Controls.Add(this.labelTipoDoc);
            this.grbCliente.Location = new System.Drawing.Point(19, 133);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(549, 116);
            this.grbCliente.TabIndex = 57;
            this.grbCliente.TabStop = false;
            // 
            // buttonTarjeta
            // 
            this.buttonTarjeta.BackColor = System.Drawing.Color.Silver;
            this.buttonTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTarjeta.ForeColor = System.Drawing.Color.Black;
            this.buttonTarjeta.Location = new System.Drawing.Point(468, 78);
            this.buttonTarjeta.Name = "buttonTarjeta";
            this.buttonTarjeta.Size = new System.Drawing.Size(75, 24);
            this.buttonTarjeta.TabIndex = 7;
            this.buttonTarjeta.Text = "Aceptar";
            this.buttonTarjeta.UseVisualStyleBackColor = false;
            this.buttonTarjeta.Click += new System.EventHandler(this.buttonTarjeta_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, -5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 25);
            this.label13.TabIndex = 48;
            this.label13.Text = "Cliente";
            // 
            // comboTarjetaCliente
            // 
            this.comboTarjetaCliente.BackColor = System.Drawing.Color.White;
            this.comboTarjetaCliente.ForeColor = System.Drawing.Color.Black;
            this.comboTarjetaCliente.FormattingEnabled = true;
            this.comboTarjetaCliente.Location = new System.Drawing.Point(80, 79);
            this.comboTarjetaCliente.Name = "comboTarjetaCliente";
            this.comboTarjetaCliente.Size = new System.Drawing.Size(291, 24);
            this.comboTarjetaCliente.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(403, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Nombre y Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo documento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nro documento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tarjeta:";
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.Silver;
            this.buttonCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.ForeColor = System.Drawing.Color.Black;
            this.buttonCliente.Location = new System.Drawing.Point(215, 45);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(75, 24);
            this.buttonCliente.TabIndex = 5;
            this.buttonCliente.Text = "Buscar";
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.BackColor = System.Drawing.Color.White;
            this.comboBoxDocType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(140, 17);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(67, 24);
            this.comboBoxDocType.TabIndex = 3;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.White;
            this.labelCliente.Location = new System.Drawing.Point(416, 45);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(107, 15);
            this.labelCliente.TabIndex = 50;
            this.labelCliente.Text = "##### #######";
            // 
            // textNumeroDocumento
            // 
            this.textNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.textNumeroDocumento.ForeColor = System.Drawing.Color.Black;
            this.textNumeroDocumento.Location = new System.Drawing.Point(140, 47);
            this.textNumeroDocumento.Mask = "99999999";
            this.textNumeroDocumento.Name = "textNumeroDocumento";
            this.textNumeroDocumento.Size = new System.Drawing.Size(67, 23);
            this.textNumeroDocumento.TabIndex = 4;
            this.textNumeroDocumento.ValidatingType = typeof(int);
            // 
            // labelTarjeta
            // 
            this.labelTarjeta.AutoSize = true;
            this.labelTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.labelTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarjeta.ForeColor = System.Drawing.Color.White;
            this.labelTarjeta.Location = new System.Drawing.Point(89, 83);
            this.labelTarjeta.Name = "labelTarjeta";
            this.labelTarjeta.Size = new System.Drawing.Size(52, 15);
            this.labelTarjeta.TabIndex = 53;
            this.labelTarjeta.Text = "Tarjeta";
            // 
            // labelNroDoc
            // 
            this.labelNroDoc.AutoSize = true;
            this.labelNroDoc.BackColor = System.Drawing.Color.Transparent;
            this.labelNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroDoc.ForeColor = System.Drawing.Color.White;
            this.labelNroDoc.Location = new System.Drawing.Point(137, 49);
            this.labelNroDoc.Name = "labelNroDoc";
            this.labelNroDoc.Size = new System.Drawing.Size(55, 15);
            this.labelNroDoc.TabIndex = 52;
            this.labelNroDoc.Text = "NroDoc";
            // 
            // labelTipoDoc
            // 
            this.labelTipoDoc.AutoSize = true;
            this.labelTipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDoc.ForeColor = System.Drawing.Color.White;
            this.labelTipoDoc.Location = new System.Drawing.Point(142, 22);
            this.labelTipoDoc.Name = "labelTipoDoc";
            this.labelTipoDoc.Size = new System.Drawing.Size(60, 15);
            this.labelTipoDoc.TabIndex = 51;
            this.labelTipoDoc.Text = "TipoDoc";
            // 
            // grbLocal
            // 
            this.grbLocal.Controls.Add(this.cmbLocal);
            this.grbLocal.Controls.Add(this.label15);
            this.grbLocal.Controls.Add(this.labelLocal);
            this.grbLocal.Controls.Add(this.label17);
            this.grbLocal.Controls.Add(this.label4);
            this.grbLocal.Controls.Add(this.buttonLocal);
            this.grbLocal.Location = new System.Drawing.Point(19, 76);
            this.grbLocal.Name = "grbLocal";
            this.grbLocal.Size = new System.Drawing.Size(549, 47);
            this.grbLocal.TabIndex = 58;
            this.grbLocal.TabStop = false;
            // 
            // cmbLocal
            // 
            this.cmbLocal.BackColor = System.Drawing.Color.White;
            this.cmbLocal.ForeColor = System.Drawing.Color.Black;
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(120, 15);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(119, 24);
            this.cmbLocal.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, -6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 25);
            this.label15.TabIndex = 51;
            this.label15.Text = "Local";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.BackColor = System.Drawing.Color.Transparent;
            this.labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocal.ForeColor = System.Drawing.Color.White;
            this.labelLocal.Location = new System.Drawing.Point(380, 22);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(71, 17);
            this.labelLocal.TabIndex = 54;
            this.labelLocal.Text = "#######";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(327, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 17);
            this.label17.TabIndex = 53;
            this.label17.Text = "Local:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Local";
            // 
            // buttonLocal
            // 
            this.buttonLocal.BackColor = System.Drawing.Color.Silver;
            this.buttonLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocal.ForeColor = System.Drawing.Color.Black;
            this.buttonLocal.Location = new System.Drawing.Point(242, 15);
            this.buttonLocal.Name = "buttonLocal";
            this.buttonLocal.Size = new System.Drawing.Size(75, 24);
            this.buttonLocal.TabIndex = 2;
            this.buttonLocal.Text = "Aceptar";
            this.buttonLocal.UseVisualStyleBackColor = false;
            this.buttonLocal.Click += new System.EventHandler(this.buttonLocal_Click);
            // 
            // Facturacion_Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 694);
            this.Controls.Add(this.fechaCompra);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Facturacion_Ventana";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Factura";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.fechaCompra.ResumeLayout(false);
            this.fechaCompra.PerformLayout();
            this.grbDetalle.ResumeLayout(false);
            this.grbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).EndInit();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbLocal.ResumeLayout(false);
            this.grbLocal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Panel fechaCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.MaskedTextBox textNumeroDocumento;
        private System.Windows.Forms.Label labelFechaCompra;
        private System.Windows.Forms.Label nroFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox textCodProducto;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.MaskedTextBox textCantidad;
        private System.Windows.Forms.DataGridView tablaProducto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelNombreProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonLocal;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ComboBox comboTarjetaCliente;
        private System.Windows.Forms.GroupBox grbDetalle;
        private System.Windows.Forms.Button buttonTarjeta;
        private System.Windows.Forms.Button buttonCargarProducto;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grbLocal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label labelTarjeta;
        private System.Windows.Forms.Label labelNroDoc;
        private System.Windows.Forms.Label labelTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}