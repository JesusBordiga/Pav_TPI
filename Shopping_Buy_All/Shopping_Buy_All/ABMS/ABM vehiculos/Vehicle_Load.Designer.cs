﻿namespace Shopping_Buy_All.ABMS.ABM_Vehiculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNumberDoc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPatente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNameModelo = new System.Windows.Forms.TextBox();
            this.tablaVehiculo = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVehicleLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cargar Vehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Documento";
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxDocType.ForeColor = System.Drawing.Color.White;
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(128, 133);
            this.comboBoxDocType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(157, 24);
            this.comboBoxDocType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(119, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nro de Documento";
            // 
            // textNumberDoc
            // 
            this.textNumberDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNumberDoc.ForeColor = System.Drawing.Color.White;
            this.textNumberDoc.Location = new System.Drawing.Point(167, 209);
            this.textNumberDoc.Margin = new System.Windows.Forms.Padding(4);
            this.textNumberDoc.Mask = "99999999";
            this.textNumberDoc.Name = "textNumberDoc";
            this.textNumberDoc.Size = new System.Drawing.Size(72, 22);
            this.textNumberDoc.TabIndex = 8;
            this.textNumberDoc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(166, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patente";
            // 
            // textPatente
            // 
            this.textPatente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textPatente.ForeColor = System.Drawing.Color.White;
            this.textPatente.Location = new System.Drawing.Point(139, 274);
            this.textPatente.Margin = new System.Windows.Forms.Padding(4);
            this.textPatente.Name = "textPatente";
            this.textPatente.Size = new System.Drawing.Size(132, 22);
            this.textPatente.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo";
            // 
            // textNameModelo
            // 
            this.textNameModelo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameModelo.ForeColor = System.Drawing.Color.White;
            this.textNameModelo.Location = new System.Drawing.Point(139, 361);
            this.textNameModelo.Margin = new System.Windows.Forms.Padding(4);
            this.textNameModelo.Name = "textNameModelo";
            this.textNameModelo.Size = new System.Drawing.Size(132, 22);
            this.textNameModelo.TabIndex = 12;
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
            this.tablaVehiculo.Location = new System.Drawing.Point(562, 98);
            this.tablaVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.tablaVehiculo.Name = "tablaVehiculo";
            this.tablaVehiculo.ReadOnly = true;
            this.tablaVehiculo.RowHeadersWidth = 51;
            this.tablaVehiculo.Size = new System.Drawing.Size(500, 300);
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
            this.btnVehicleLoad.Location = new System.Drawing.Point(107, 453);
            this.btnVehicleLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehicleLoad.Name = "btnVehicleLoad";
            this.btnVehicleLoad.Size = new System.Drawing.Size(100, 28);
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
            this.btnClear.Location = new System.Drawing.Point(252, 453);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(666, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(312, 39);
            this.label15.TabIndex = 29;
            this.label15.Text = "Lista de Vehiculos";
            // 
            // Vehicle_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 543);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVehicleLoad);
            this.Controls.Add(this.tablaVehiculo);
            this.Controls.Add(this.textNameModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPatente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNumberDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textNameModelo;
        private System.Windows.Forms.DataGridView tablaVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.Button btnVehicleLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label15;
    }
}