namespace Shopping_Buy_All
{
    partial class Tarjeta_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarjeta_Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.textNroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDeleteTarjeta = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tablaTarjetas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tarjeta a eliminar";
            // 
            // textNroTarjeta
            // 
            this.textNroTarjeta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNroTarjeta.ForeColor = System.Drawing.Color.White;
            this.textNroTarjeta.Location = new System.Drawing.Point(65, 117);
            this.textNroTarjeta.Mask = "9999999999999999";
            this.textNroTarjeta.Name = "textNroTarjeta";
            this.textNroTarjeta.Size = new System.Drawing.Size(102, 20);
            this.textNroTarjeta.TabIndex = 2;
            this.textNroTarjeta.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nro de Tarjeta";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(69, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkGray;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(69, 260);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnDeleteTarjeta
            // 
            this.btnDeleteTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTarjeta.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.Trash;
            this.btnDeleteTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTarjeta.Location = new System.Drawing.Point(65, 298);
            this.btnDeleteTarjeta.Name = "btnDeleteTarjeta";
            this.btnDeleteTarjeta.Size = new System.Drawing.Size(76, 73);
            this.btnDeleteTarjeta.TabIndex = 67;
            this.btnDeleteTarjeta.UseVisualStyleBackColor = false;
            this.btnDeleteTarjeta.Click += new System.EventHandler(this.btnDeleteTarjeta_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(480, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 29);
            this.label15.TabIndex = 71;
            this.label15.Text = "Lista de Tarjetas";
            // 
            // tablaTarjetas
            // 
            this.tablaTarjetas.AllowUserToAddRows = false;
            this.tablaTarjetas.AllowUserToDeleteRows = false;
            this.tablaTarjetas.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaTarjetas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTarjetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.NroTarjeta,
            this.Marca,
            this.Tipo,
            this.dataGridViewTextBoxColumn3});
            this.tablaTarjetas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaTarjetas.Location = new System.Drawing.Point(407, 56);
            this.tablaTarjetas.Name = "tablaTarjetas";
            this.tablaTarjetas.ReadOnly = true;
            this.tablaTarjetas.RowHeadersWidth = 20;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaTarjetas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaTarjetas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaTarjetas.Size = new System.Drawing.Size(375, 355);
            this.tablaTarjetas.TabIndex = 72;
            this.tablaTarjetas.TabStop = false;
            this.tablaTarjetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTarjetas_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TipoDocumento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo Documento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NroDocumento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nro Documento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // NroTarjeta
            // 
            this.NroTarjeta.DataPropertyName = "NroTarjeta";
            this.NroTarjeta.HeaderText = "Nro Tarjeta";
            this.NroTarjeta.Name = "NroTarjeta";
            this.NroTarjeta.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "IdMarca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 70;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "IdTipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Borrado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Borrado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // Tarjeta_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.tablaTarjetas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnDeleteTarjeta);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textNroTarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tarjeta_Delete";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Tarjeta";
            this.Load += new System.EventHandler(this.Tarjeta_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textNroTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDeleteTarjeta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tablaTarjetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}