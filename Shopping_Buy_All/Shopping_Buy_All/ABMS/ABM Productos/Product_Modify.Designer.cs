﻿namespace Shopping_Buy_All
{
    partial class Product_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Modify));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPorductLoad = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.MaskedTextBox();
            this.textNameProduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCodeProduct = new System.Windows.Forms.MaskedTextBox();
            this.btnSerachProduct2 = new System.Windows.Forms.Button();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(189, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPorductLoad
            // 
            this.btnPorductLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorductLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorductLoad.ForeColor = System.Drawing.Color.White;
            this.btnPorductLoad.Location = new System.Drawing.Point(29, 316);
            this.btnPorductLoad.Name = "btnPorductLoad";
            this.btnPorductLoad.Size = new System.Drawing.Size(75, 23);
            this.btnPorductLoad.TabIndex = 6;
            this.btnPorductLoad.Text = "Modificar";
            this.btnPorductLoad.UseVisualStyleBackColor = true;
            this.btnPorductLoad.Click += new System.EventHandler(this.btnPorductLoad_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(318, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(230, 29);
            this.label15.TabIndex = 68;
            this.label15.Text = "Lista de Productos";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textPrice.ForeColor = System.Drawing.Color.White;
            this.textPrice.Location = new System.Drawing.Point(111, 236);
            this.textPrice.Mask = "9999999";
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(53, 20);
            this.textPrice.TabIndex = 5;
            this.textPrice.ValidatingType = typeof(int);
            // 
            // textNameProduct
            // 
            this.textNameProduct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameProduct.ForeColor = System.Drawing.Color.White;
            this.textNameProduct.Location = new System.Drawing.Point(77, 188);
            this.textNameProduct.Name = "textNameProduct";
            this.textNameProduct.Size = new System.Drawing.Size(120, 20);
            this.textNameProduct.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(114, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Modificar producto";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(110, 316);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProduct.TabIndex = 2;
            this.btnSearchProduct.Text = "Buscar";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.Location = new System.Drawing.Point(23, 95);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(242, 249);
            this.SearchPanel.TabIndex = 71;
            this.SearchPanel.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Codigo";
            // 
            // textCodeProduct
            // 
            this.textCodeProduct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textCodeProduct.ForeColor = System.Drawing.Color.White;
            this.textCodeProduct.Location = new System.Drawing.Point(117, 140);
            this.textCodeProduct.Mask = "9999999";
            this.textCodeProduct.Name = "textCodeProduct";
            this.textCodeProduct.Size = new System.Drawing.Size(46, 20);
            this.textCodeProduct.TabIndex = 1;
            this.textCodeProduct.ValidatingType = typeof(int);
            // 
            // btnSerachProduct2
            // 
            this.btnSerachProduct2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerachProduct2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerachProduct2.ForeColor = System.Drawing.Color.White;
            this.btnSerachProduct2.Location = new System.Drawing.Point(110, 316);
            this.btnSerachProduct2.Name = "btnSerachProduct2";
            this.btnSerachProduct2.Size = new System.Drawing.Size(75, 23);
            this.btnSerachProduct2.TabIndex = 74;
            this.btnSerachProduct2.Text = "Buscar";
            this.btnSerachProduct2.UseVisualStyleBackColor = true;
            this.btnSerachProduct2.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            this.tablaProductos.AllowUserToOrderColumns = true;
            this.tablaProductos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Borrado});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductos.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProductos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaProductos.Location = new System.Drawing.Point(270, 33);
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
            this.tablaProductos.Size = new System.Drawing.Size(316, 310);
            this.tablaProductos.TabIndex = 86;
            this.tablaProductos.TabStop = false;
            this.tablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellContentClick);
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
            // Product_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 350);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.btnSerachProduct2);
            this.Controls.Add(this.textCodeProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.btnPorductLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textNameProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(608, 389);
            this.MinimumSize = new System.Drawing.Size(608, 389);
            this.Name = "Product_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPorductLoad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox textPrice;
        private System.Windows.Forms.TextBox textNameProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.PictureBox SearchPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox textCodeProduct;
        private System.Windows.Forms.Button btnSerachProduct2;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}