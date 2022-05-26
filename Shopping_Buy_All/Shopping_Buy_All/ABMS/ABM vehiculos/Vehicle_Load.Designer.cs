namespace Shopping_Buy_All.ABMS.ABM_Vehiculos
{
    partial class Vehicle_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle_Load));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNumberDoc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPatente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaVehiculo = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVehicleLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cargar Vehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-2, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Documento";
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxDocType.ForeColor = System.Drawing.Color.White;
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(151, 153);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(119, 21);
            this.comboBoxDocType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nro de Documento";
            // 
            // textNumberDoc
            // 
            this.textNumberDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNumberDoc.ForeColor = System.Drawing.Color.White;
            this.textNumberDoc.Location = new System.Drawing.Point(184, 188);
            this.textNumberDoc.Mask = "99999999";
            this.textNumberDoc.Name = "textNumberDoc";
            this.textNumberDoc.Size = new System.Drawing.Size(55, 20);
            this.textNumberDoc.TabIndex = 8;
            this.textNumberDoc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patente";
            // 
            // textPatente
            // 
            this.textPatente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textPatente.ForeColor = System.Drawing.Color.White;
            this.textPatente.Location = new System.Drawing.Point(156, 218);
            this.textPatente.Name = "textPatente";
            this.textPatente.Size = new System.Drawing.Size(100, 20);
            this.textPatente.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo";
            // 
            // tablaVehiculo
            // 
            this.tablaVehiculo.AllowUserToAddRows = false;
            this.tablaVehiculo.AllowUserToDeleteRows = false;
            this.tablaVehiculo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.Borrado,
            this.NroDocumento,
            this.Patente,
            this.Modelo});
            this.tablaVehiculo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaVehiculo.Location = new System.Drawing.Point(302, 80);
            this.tablaVehiculo.Name = "tablaVehiculo";
            this.tablaVehiculo.ReadOnly = true;
            this.tablaVehiculo.RowHeadersWidth = 10;
            this.tablaVehiculo.Size = new System.Drawing.Size(410, 313);
            this.tablaVehiculo.TabIndex = 13;
            this.tablaVehiculo.TabStop = false;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDoc";
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 70;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.MinimumWidth = 6;
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            this.Borrado.Width = 125;
            // 
            // NroDocumento
            // 
            this.NroDocumento.DataPropertyName = "NroDoc";
            this.NroDocumento.HeaderText = "Nro Documento";
            this.NroDocumento.MinimumWidth = 6;
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Width = 70;
            // 
            // Patente
            // 
            this.Patente.DataPropertyName = "Patente";
            this.Patente.HeaderText = "Patente";
            this.Patente.MinimumWidth = 6;
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            this.Patente.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // btnVehicleLoad
            // 
            this.btnVehicleLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicleLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleLoad.ForeColor = System.Drawing.Color.White;
            this.btnVehicleLoad.Location = new System.Drawing.Point(55, 320);
            this.btnVehicleLoad.Name = "btnVehicleLoad";
            this.btnVehicleLoad.Size = new System.Drawing.Size(75, 23);
            this.btnVehicleLoad.TabIndex = 14;
            this.btnVehicleLoad.Text = "Cargar";
            this.btnVehicleLoad.UseVisualStyleBackColor = true;
            this.btnVehicleLoad.Click += new System.EventHandler(this.btnVehicleLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(164, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(425, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 22);
            this.label15.TabIndex = 29;
            this.label15.Text = "Lista de Vehiculos";
            // 
            // cmbModelo
            // 
            this.cmbModelo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbModelo.ForeColor = System.Drawing.Color.White;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(151, 250);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(119, 21);
            this.cmbModelo.TabIndex = 30;
            // 
            // Vehicle_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 405);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVehicleLoad);
            this.Controls.Add(this.tablaVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPatente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNumberDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Vehicle_Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox textNumberDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPatente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.Button btnVehicleLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbModelo;
    }
}