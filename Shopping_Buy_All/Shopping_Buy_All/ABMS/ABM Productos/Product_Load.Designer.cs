﻿namespace Shopping_Buy_All.Productos
{
    partial class Product_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Load));
            this.label15 = new System.Windows.Forms.Label();
            this.textNameProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.MaskedTextBox();
            this.btnPorductLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(301, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(257, 31);
            this.label15.TabIndex = 59;
            this.label15.Text = "Lista de Productos";
            // 
            // textNameProduct
            // 
            this.textNameProduct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameProduct.ForeColor = System.Drawing.Color.White;
            this.textNameProduct.Location = new System.Drawing.Point(96, 143);
            this.textNameProduct.Name = "textNameProduct";
            this.textNameProduct.Size = new System.Drawing.Size(100, 20);
            this.textNameProduct.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cargar producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(115, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Precio";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textPrice.ForeColor = System.Drawing.Color.White;
            this.textPrice.Location = new System.Drawing.Point(114, 195);
            this.textPrice.Mask = "9999999";
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(46, 20);
            this.textPrice.TabIndex = 51;
            this.textPrice.ValidatingType = typeof(int);
            // 
            // btnPorductLoad
            // 
            this.btnPorductLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorductLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorductLoad.ForeColor = System.Drawing.Color.White;
            this.btnPorductLoad.Location = new System.Drawing.Point(58, 315);
            this.btnPorductLoad.Name = "btnPorductLoad";
            this.btnPorductLoad.Size = new System.Drawing.Size(75, 23);
            this.btnPorductLoad.TabIndex = 52;
            this.btnPorductLoad.Text = "Cargar";
            this.btnPorductLoad.UseVisualStyleBackColor = true;
            this.btnPorductLoad.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(162, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProductos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Borrado});
            this.tablaProductos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaProductos.Location = new System.Drawing.Point(271, 40);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProductos.Size = new System.Drawing.Size(316, 298);
            this.tablaProductos.TabIndex = 60;
            this.tablaProductos.TabStop = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo_Producto";
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreProducto";
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.Frozen = true;
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // Product_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 350);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPorductLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textNameProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Product_Load";
            this.Opacity = 0.98D;
            this.Text = "Cargar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textNameProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox textPrice;
        private System.Windows.Forms.Button btnPorductLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}