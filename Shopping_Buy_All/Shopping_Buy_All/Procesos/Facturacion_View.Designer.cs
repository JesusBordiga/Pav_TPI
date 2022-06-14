namespace Shopping_Buy_All
{
    partial class Facturacion_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion_View));
            this.tablaFacturas = new System.Windows.Forms.DataGridView();
            this.textNroFactura = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTarjeta = new System.Windows.Forms.Button();
            this.Numero_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaFacturas
            // 
            this.tablaFacturas.AllowUserToAddRows = false;
            this.tablaFacturas.AllowUserToDeleteRows = false;
            this.tablaFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaFacturas.BackgroundColor = System.Drawing.Color.DimGray;
            this.tablaFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Factura,
            this.Local,
            this.Tipo_Documento,
            this.Numero_Documento,
            this.NroTarjeta,
            this.FechaCompra,
            this.CodigoProducto,
            this.NombreProducto,
            this.Cantidad,
            this.Precio});
            this.tablaFacturas.Cursor = System.Windows.Forms.Cursors.Default;
            this.tablaFacturas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaFacturas.Location = new System.Drawing.Point(178, 13);
            this.tablaFacturas.MultiSelect = false;
            this.tablaFacturas.Name = "tablaFacturas";
            this.tablaFacturas.ReadOnly = true;
            this.tablaFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaFacturas.RowHeadersVisible = false;
            this.tablaFacturas.RowHeadersWidth = 10;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tablaFacturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaFacturas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaFacturas.Size = new System.Drawing.Size(937, 426);
            this.tablaFacturas.TabIndex = 43;
            this.tablaFacturas.TabStop = false;
            // 
            // textNroFactura
            // 
            this.textNroFactura.BackColor = System.Drawing.Color.White;
            this.textNroFactura.ForeColor = System.Drawing.Color.Black;
            this.textNroFactura.Location = new System.Drawing.Point(100, 77);
            this.textNroFactura.Mask = "99999999";
            this.textNroFactura.Name = "textNroFactura";
            this.textNroFactura.Size = new System.Drawing.Size(58, 20);
            this.textNroFactura.TabIndex = 44;
            this.textNroFactura.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Factura nro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Buscar factura";
            // 
            // buttonTarjeta
            // 
            this.buttonTarjeta.BackColor = System.Drawing.Color.Silver;
            this.buttonTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTarjeta.ForeColor = System.Drawing.Color.Black;
            this.buttonTarjeta.Location = new System.Drawing.Point(43, 128);
            this.buttonTarjeta.Name = "buttonTarjeta";
            this.buttonTarjeta.Size = new System.Drawing.Size(75, 24);
            this.buttonTarjeta.TabIndex = 47;
            this.buttonTarjeta.Text = "Buscar";
            this.buttonTarjeta.UseVisualStyleBackColor = false;
            this.buttonTarjeta.Click += new System.EventHandler(this.buttonTarjeta_Click);
            // 
            // Numero_Factura
            // 
            this.Numero_Factura.DataPropertyName = "Numero_Factura";
            this.Numero_Factura.FillWeight = 70F;
            this.Numero_Factura.HeaderText = "Nro Factura";
            this.Numero_Factura.Name = "Numero_Factura";
            this.Numero_Factura.ReadOnly = true;
            // 
            // Local
            // 
            this.Local.DataPropertyName = "Nombre";
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            // 
            // Tipo_Documento
            // 
            this.Tipo_Documento.DataPropertyName = "Tipo_Documento";
            this.Tipo_Documento.FillWeight = 89.80129F;
            this.Tipo_Documento.HeaderText = "Tipo Documento";
            this.Tipo_Documento.Name = "Tipo_Documento";
            this.Tipo_Documento.ReadOnly = true;
            // 
            // Numero_Documento
            // 
            this.Numero_Documento.DataPropertyName = "NumeroDocumento";
            this.Numero_Documento.FillWeight = 89.80129F;
            this.Numero_Documento.HeaderText = "Numero Documento";
            this.Numero_Documento.Name = "Numero_Documento";
            this.Numero_Documento.ReadOnly = true;
            // 
            // NroTarjeta
            // 
            this.NroTarjeta.DataPropertyName = "Numero_Tarjeta";
            this.NroTarjeta.FillWeight = 60F;
            this.NroTarjeta.HeaderText = "Numero Tarjeta";
            this.NroTarjeta.Name = "NroTarjeta";
            this.NroTarjeta.ReadOnly = true;
            // 
            // FechaCompra
            // 
            this.FechaCompra.DataPropertyName = "FechaCompra";
            this.FechaCompra.FillWeight = 89.80129F;
            this.FechaCompra.HeaderText = "Fecha de Compra";
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.DataPropertyName = "NombreProducto";
            this.CodigoProducto.FillWeight = 120F;
            this.CodigoProducto.HeaderText = "Nombre Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Visible = false;
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
            this.Precio.FillWeight = 60F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Facturacion_View
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 451);
            this.Controls.Add(this.buttonTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textNroFactura);
            this.Controls.Add(this.tablaFacturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Facturacion_View";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaFacturas;
        private System.Windows.Forms.MaskedTextBox textNroFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}