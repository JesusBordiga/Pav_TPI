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
            this.Numero_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNroFactura = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTarjeta = new System.Windows.Forms.Button();
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
            this.Codigo_Local,
            this.Tipo_Documento,
            this.Numero_Documento,
            this.Numero_Tarjeta,
            this.FechaCompra,
            this.Borrado});
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
            this.tablaFacturas.Size = new System.Drawing.Size(555, 407);
            this.tablaFacturas.TabIndex = 43;
            this.tablaFacturas.TabStop = false;
            // 
            // Numero_Factura
            // 
            this.Numero_Factura.DataPropertyName = "Numero_Factura";
            this.Numero_Factura.FillWeight = 58.05373F;
            this.Numero_Factura.HeaderText = "Nro Factura";
            this.Numero_Factura.Name = "Numero_Factura";
            this.Numero_Factura.ReadOnly = true;
            // 
            // Codigo_Local
            // 
            this.Codigo_Local.DataPropertyName = "Codigo_Local";
            this.Codigo_Local.FillWeight = 182.7411F;
            this.Codigo_Local.HeaderText = "Codigo Local";
            this.Codigo_Local.Name = "Codigo_Local";
            this.Codigo_Local.ReadOnly = true;
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
            this.Numero_Documento.DataPropertyName = "Numero_Documento";
            this.Numero_Documento.FillWeight = 89.80129F;
            this.Numero_Documento.HeaderText = "Numero Documento";
            this.Numero_Documento.Name = "Numero_Documento";
            this.Numero_Documento.ReadOnly = true;
            // 
            // Numero_Tarjeta
            // 
            this.Numero_Tarjeta.DataPropertyName = "Numero_Tarjeta";
            this.Numero_Tarjeta.FillWeight = 89.80129F;
            this.Numero_Tarjeta.HeaderText = "Numero Tarjeta";
            this.Numero_Tarjeta.Name = "Numero_Tarjeta";
            this.Numero_Tarjeta.ReadOnly = true;
            // 
            // FechaCompra
            // 
            this.FechaCompra.DataPropertyName = "FechaCompra";
            this.FechaCompra.FillWeight = 89.80129F;
            this.FechaCompra.HeaderText = "Fecha de Compra";
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.ReadOnly = true;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
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
            // Facturacion_View
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 431);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.MaskedTextBox textNroFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTarjeta;
    }
}