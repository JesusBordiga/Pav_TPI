namespace Shopping_Buy_All
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.fechaCompra = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.nroFactura = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textNumeroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.textNumberLocal = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textCodProducto = new System.Windows.Forms.MaskedTextBox();
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.textCantidad = new System.Windows.Forms.MaskedTextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelNombrePorducto = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CodigoPorducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClean = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonLocal = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboTarjetaCliente = new System.Windows.Forms.ComboBox();
            this.fechaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
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
            this.fechaCompra.Controls.Add(this.comboTarjetaCliente);
            this.fechaCompra.Controls.Add(this.label15);
            this.fechaCompra.Controls.Add(this.label17);
            this.fechaCompra.Controls.Add(this.buttonLocal);
            this.fechaCompra.Controls.Add(this.buttonCliente);
            this.fechaCompra.Controls.Add(this.labelCliente);
            this.fechaCompra.Controls.Add(this.label12);
            this.fechaCompra.Controls.Add(this.btnClean);
            this.fechaCompra.Controls.Add(this.label16);
            this.fechaCompra.Controls.Add(this.labelNombrePorducto);
            this.fechaCompra.Controls.Add(this.label14);
            this.fechaCompra.Controls.Add(this.labelPrecio);
            this.fechaCompra.Controls.Add(this.textCantidad);
            this.fechaCompra.Controls.Add(this.tablaClientes);
            this.fechaCompra.Controls.Add(this.textCodProducto);
            this.fechaCompra.Controls.Add(this.label13);
            this.fechaCompra.Controls.Add(this.nroFactura);
            this.fechaCompra.Controls.Add(this.label11);
            this.fechaCompra.Controls.Add(this.textNumeroDocumento);
            this.fechaCompra.Controls.Add(this.comboBoxDocType);
            this.fechaCompra.Controls.Add(this.textNumberLocal);
            this.fechaCompra.Controls.Add(this.label10);
            this.fechaCompra.Controls.Add(this.label5);
            this.fechaCompra.Controls.Add(this.label9);
            this.fechaCompra.Controls.Add(this.label8);
            this.fechaCompra.Controls.Add(this.label7);
            this.fechaCompra.Controls.Add(this.label6);
            this.fechaCompra.Controls.Add(this.label4);
            this.fechaCompra.Controls.Add(this.label3);
            this.fechaCompra.Controls.Add(this.label2);
            this.fechaCompra.Controls.Add(this.label1);
            this.fechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCompra.Location = new System.Drawing.Point(31, 34);
            this.fechaCompra.Name = "fechaCompra";
            this.fechaCompra.Size = new System.Drawing.Size(588, 827);
            this.fechaCompra.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(450, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "dd/mm/aaaa";
            // 
            // nroFactura
            // 
            this.nroFactura.AutoSize = true;
            this.nroFactura.BackColor = System.Drawing.Color.Transparent;
            this.nroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroFactura.ForeColor = System.Drawing.Color.White;
            this.nroFactura.Location = new System.Drawing.Point(119, 60);
            this.nroFactura.Name = "nroFactura";
            this.nroFactura.Size = new System.Drawing.Size(32, 17);
            this.nroFactura.TabIndex = 39;
            this.nroFactura.Text = "nro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Factura nro:";
            // 
            // textNumeroDocumento
            // 
            this.textNumeroDocumento.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNumeroDocumento.ForeColor = System.Drawing.Color.White;
            this.textNumeroDocumento.Location = new System.Drawing.Point(152, 136);
            this.textNumeroDocumento.Mask = "99999999";
            this.textNumeroDocumento.Name = "textNumeroDocumento";
            this.textNumeroDocumento.Size = new System.Drawing.Size(55, 23);
            this.textNumeroDocumento.TabIndex = 36;
            this.textNumeroDocumento.ValidatingType = typeof(int);
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxDocType.ForeColor = System.Drawing.Color.White;
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(158, 110);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(119, 24);
            this.comboBoxDocType.TabIndex = 35;
            // 
            // textNumberLocal
            // 
            this.textNumberLocal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNumberLocal.ForeColor = System.Drawing.Color.White;
            this.textNumberLocal.Location = new System.Drawing.Point(107, 82);
            this.textNumberLocal.Mask = "99999999";
            this.textNumberLocal.Name = "textNumberLocal";
            this.textNumberLocal.Size = new System.Drawing.Size(55, 23);
            this.textNumberLocal.TabIndex = 34;
            this.textNumberLocal.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(441, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(244, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cod producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nro tarjeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nro documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Detalle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cod Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo documento";
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
            // textCodProducto
            // 
            this.textCodProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textCodProducto.ForeColor = System.Drawing.Color.White;
            this.textCodProducto.Location = new System.Drawing.Point(46, 304);
            this.textCodProducto.Mask = "99999999";
            this.textCodProducto.Name = "textCodProducto";
            this.textCodProducto.Size = new System.Drawing.Size(55, 23);
            this.textCodProducto.TabIndex = 41;
            this.textCodProducto.ValidatingType = typeof(int);
            // 
            // tablaClientes
            // 
            this.tablaClientes.AllowUserToAddRows = false;
            this.tablaClientes.AllowUserToDeleteRows = false;
            this.tablaClientes.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPorducto,
            this.NombreProducto,
            this.Cantidad,
            this.Precio});
            this.tablaClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaClientes.Location = new System.Drawing.Point(82, 383);
            this.tablaClientes.MultiSelect = false;
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.ReadOnly = true;
            this.tablaClientes.RowHeadersWidth = 10;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaClientes.Size = new System.Drawing.Size(425, 350);
            this.tablaClientes.TabIndex = 42;
            this.tablaClientes.TabStop = false;
            // 
            // textCantidad
            // 
            this.textCantidad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textCantidad.ForeColor = System.Drawing.Color.White;
            this.textCantidad.Location = new System.Drawing.Point(247, 304);
            this.textCantidad.Mask = "99999999";
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(55, 23);
            this.textCantidad.TabIndex = 43;
            this.textCantidad.ValidatingType = typeof(int);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(450, 307);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(71, 17);
            this.labelPrecio.TabIndex = 44;
            this.labelPrecio.Text = "$$$$$$$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(29, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 17);
            this.label14.TabIndex = 45;
            this.label14.Text = "Nombre producto";
            // 
            // labelNombrePorducto
            // 
            this.labelNombrePorducto.AutoSize = true;
            this.labelNombrePorducto.BackColor = System.Drawing.Color.Transparent;
            this.labelNombrePorducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombrePorducto.ForeColor = System.Drawing.Color.White;
            this.labelNombrePorducto.Location = new System.Drawing.Point(32, 349);
            this.labelNombrePorducto.Name = "labelNombrePorducto";
            this.labelNombrePorducto.Size = new System.Drawing.Size(215, 17);
            this.labelNombrePorducto.TabIndex = 46;
            this.labelNombrePorducto.Text = "#######################";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(435, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 47;
            this.label16.Text = "$";
            // 
            // CodigoPorducto
            // 
            this.CodigoPorducto.DataPropertyName = "Codigo_Producto";
            this.CodigoPorducto.HeaderText = "Codigo Porducto";
            this.CodigoPorducto.Name = "CodigoPorducto";
            this.CodigoPorducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkGray;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(122, 304);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 24);
            this.btnClean.TabIndex = 48;
            this.btnClean.Text = "Buscar";
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(300, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Nombre y Apellido Cliente";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.White;
            this.labelCliente.Location = new System.Drawing.Point(300, 139);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(152, 17);
            this.labelCliente.TabIndex = 50;
            this.labelCliente.Text = "################";
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.ForeColor = System.Drawing.Color.White;
            this.buttonCliente.Location = new System.Drawing.Point(217, 136);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(75, 24);
            this.buttonCliente.TabIndex = 51;
            this.buttonCliente.Text = "Buscar";
            this.buttonCliente.UseVisualStyleBackColor = false;
            // 
            // buttonLocal
            // 
            this.buttonLocal.BackColor = System.Drawing.Color.DarkGray;
            this.buttonLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocal.ForeColor = System.Drawing.Color.White;
            this.buttonLocal.Location = new System.Drawing.Point(171, 81);
            this.buttonLocal.Name = "buttonLocal";
            this.buttonLocal.Size = new System.Drawing.Size(75, 24);
            this.buttonLocal.TabIndex = 52;
            this.buttonLocal.Text = "Buscar";
            this.buttonLocal.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(310, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 54;
            this.label15.Text = "#######";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(257, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 53;
            this.label17.Text = "Local";
            // 
            // comboTarjetaCliente
            // 
            this.comboTarjetaCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboTarjetaCliente.ForeColor = System.Drawing.Color.White;
            this.comboTarjetaCliente.FormattingEnabled = true;
            this.comboTarjetaCliente.Location = new System.Drawing.Point(120, 172);
            this.comboTarjetaCliente.Name = "comboTarjetaCliente";
            this.comboTarjetaCliente.Size = new System.Drawing.Size(119, 24);
            this.comboTarjetaCliente.TabIndex = 55;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 873);
            this.Controls.Add(this.fechaCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Facturacion";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Factura";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.fechaCompra.ResumeLayout(false);
            this.fechaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox textNumberLocal;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.MaskedTextBox textNumeroDocumento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label nroFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox textCodProducto;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.MaskedTextBox textCantidad;
        private System.Windows.Forms.DataGridView tablaClientes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelNombrePorducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPorducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonLocal;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ComboBox comboTarjetaCliente;
    }
}