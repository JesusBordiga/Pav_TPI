namespace Shopping_Buy_All
{
    partial class Local_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Local_Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDeleteLocal = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoComercio = new System.Windows.Forms.ComboBox();
            this.tablaLocales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLocales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Local a eliminar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(65, 209);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkGray;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(65, 253);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnDeleteLocal
            // 
            this.btnDeleteLocal.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteLocal.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.Trash;
            this.btnDeleteLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLocal.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLocal.Location = new System.Drawing.Point(78, 285);
            this.btnDeleteLocal.Name = "btnDeleteLocal";
            this.btnDeleteLocal.Size = new System.Drawing.Size(42, 45);
            this.btnDeleteLocal.TabIndex = 67;
            this.btnDeleteLocal.UseVisualStyleBackColor = false;
            this.btnDeleteLocal.Click += new System.EventHandler(this.btnDeleteLocal_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(351, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 25);
            this.label15.TabIndex = 71;
            this.label15.Text = "Lista de Locales";
            // 
            // txtNombreLocal
            // 
            this.txtNombreLocal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreLocal.ForeColor = System.Drawing.Color.White;
            this.txtNombreLocal.Location = new System.Drawing.Point(54, 114);
            this.txtNombreLocal.Name = "txtNombreLocal";
            this.txtNombreLocal.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLocal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(84, 71);
            this.txtCodigo.Mask = "99999";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(36, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 78;
            this.label4.Text = "Tipo";
            // 
            // cmbTipoComercio
            // 
            this.cmbTipoComercio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbTipoComercio.ForeColor = System.Drawing.Color.White;
            this.cmbTipoComercio.FormattingEnabled = true;
            this.cmbTipoComercio.Location = new System.Drawing.Point(49, 167);
            this.cmbTipoComercio.Name = "cmbTipoComercio";
            this.cmbTipoComercio.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoComercio.TabIndex = 3;
            // 
            // tablaLocales
            // 
            this.tablaLocales.AllowUserToAddRows = false;
            this.tablaLocales.AllowUserToDeleteRows = false;
            this.tablaLocales.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaLocales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLocales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tablaLocales.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaLocales.Location = new System.Drawing.Point(210, 74);
            this.tablaLocales.Name = "tablaLocales";
            this.tablaLocales.ReadOnly = true;
            this.tablaLocales.RowHeadersWidth = 10;
            this.tablaLocales.Size = new System.Drawing.Size(420, 255);
            this.tablaLocales.TabIndex = 92;
            this.tablaLocales.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoLocal";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo_Comercio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id Tipo Comercio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreTipoComercio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo Comercio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Local_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 336);
            this.Controls.Add(this.tablaLocales);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoComercio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnDeleteLocal);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Local_Delete";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Local";
            this.Load += new System.EventHandler(this.Local_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaLocales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDeleteLocal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNombreLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoComercio;
        private System.Windows.Forms.DataGridView tablaLocales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}