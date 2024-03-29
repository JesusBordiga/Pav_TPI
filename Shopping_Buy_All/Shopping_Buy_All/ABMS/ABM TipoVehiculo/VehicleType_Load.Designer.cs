﻿namespace Shopping_Buy_All.ABMS.ABM_TipoVehiculo
{
    partial class VehicleType_Load
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
            this.TablaTipoAuto = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargarTipoVehiculo = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textNameVehicle = new System.Windows.Forms.TextBox();
            this.butVehicleLoad = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.listavehiculos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTipoAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaTipoAuto
            // 
            this.TablaTipoAuto.AllowUserToAddRows = false;
            this.TablaTipoAuto.AllowUserToDeleteRows = false;
            this.TablaTipoAuto.AllowUserToOrderColumns = true;
            this.TablaTipoAuto.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.TablaTipoAuto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaTipoAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaTipoAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nombre,
            this.Borrado});
            this.TablaTipoAuto.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TablaTipoAuto.Location = new System.Drawing.Point(267, 45);
            this.TablaTipoAuto.Name = "TablaTipoAuto";
            this.TablaTipoAuto.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaTipoAuto.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaTipoAuto.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.TablaTipoAuto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaTipoAuto.RowTemplate.Height = 24;
            this.TablaTipoAuto.Size = new System.Drawing.Size(316, 310);
            this.TablaTipoAuto.TabIndex = 87;
            this.TablaTipoAuto.TabStop = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cod_tipo";
            this.codigo.HeaderText = "codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
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
            // CargarTipoVehiculo
            // 
            this.CargarTipoVehiculo.AutoSize = true;
            this.CargarTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.CargarTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarTipoVehiculo.ForeColor = System.Drawing.Color.White;
            this.CargarTipoVehiculo.Location = new System.Drawing.Point(17, 67);
            this.CargarTipoVehiculo.Name = "CargarTipoVehiculo";
            this.CargarTipoVehiculo.Size = new System.Drawing.Size(247, 29);
            this.CargarTipoVehiculo.TabIndex = 32;
            this.CargarTipoVehiculo.Text = "Cargar tipo vehiculo";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(107, 125);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(64, 17);
            this.name.TabIndex = 34;
            this.name.Text = "Nombre";
            // 
            // textNameVehicle
            // 
            this.textNameVehicle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameVehicle.ForeColor = System.Drawing.SystemColors.Window;
            this.textNameVehicle.Location = new System.Drawing.Point(70, 162);
            this.textNameVehicle.Name = "textNameVehicle";
            this.textNameVehicle.Size = new System.Drawing.Size(133, 20);
            this.textNameVehicle.TabIndex = 38;
            // 
            // butVehicleLoad
            // 
            this.butVehicleLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butVehicleLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butVehicleLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVehicleLoad.ForeColor = System.Drawing.Color.White;
            this.butVehicleLoad.Location = new System.Drawing.Point(47, 267);
            this.butVehicleLoad.Name = "butVehicleLoad";
            this.butVehicleLoad.Size = new System.Drawing.Size(75, 23);
            this.butVehicleLoad.TabIndex = 52;
            this.butVehicleLoad.Text = "Cargar";
            this.butVehicleLoad.UseVisualStyleBackColor = false;
            this.butVehicleLoad.Click += new System.EventHandler(this.butVehicleLoad_Click);
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClear.ForeColor = System.Drawing.Color.White;
            this.butClear.Location = new System.Drawing.Point(148, 267);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 53;
            this.butClear.Text = "Limpiar";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // listavehiculos
            // 
            this.listavehiculos.AutoSize = true;
            this.listavehiculos.BackColor = System.Drawing.Color.Transparent;
            this.listavehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listavehiculos.ForeColor = System.Drawing.Color.White;
            this.listavehiculos.Location = new System.Drawing.Point(328, 7);
            this.listavehiculos.Name = "listavehiculos";
            this.listavehiculos.Size = new System.Drawing.Size(222, 29);
            this.listavehiculos.TabIndex = 59;
            this.listavehiculos.Text = "Lista de vehiculos";
            // 
            // VehicleType_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listavehiculos);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butVehicleLoad);
            this.Controls.Add(this.textNameVehicle);
            this.Controls.Add(this.name);
            this.Controls.Add(this.CargarTipoVehiculo);
            this.Controls.Add(this.TablaTipoAuto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VehicleType_Load";
            this.Text = "VehicleType_Load";
            ((System.ComponentModel.ISupportInitialize)(this.TablaTipoAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaTipoAuto;
        private System.Windows.Forms.Label CargarTipoVehiculo;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textNameVehicle;
        private System.Windows.Forms.Button butVehicleLoad;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Label listavehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}