﻿namespace Shopping_Buy_All.ABM_Tipo_Tarjeta
{
    partial class TipoTarjeta_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoTarjeta_Load));
            this.btnTipoTarjetaLoad = new System.Windows.Forms.Button();
            this.txtNombreTdT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tablaTipoTarjeta = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.idTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipoTarjetaLoad
            // 
            this.btnTipoTarjetaLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTipoTarjetaLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipoTarjetaLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoTarjetaLoad.ForeColor = System.Drawing.Color.White;
            this.btnTipoTarjetaLoad.Location = new System.Drawing.Point(69, 319);
            this.btnTipoTarjetaLoad.Name = "btnTipoTarjetaLoad";
            this.btnTipoTarjetaLoad.Size = new System.Drawing.Size(75, 23);
            this.btnTipoTarjetaLoad.TabIndex = 78;
            this.btnTipoTarjetaLoad.Text = "Cargar";
            this.btnTipoTarjetaLoad.UseVisualStyleBackColor = false;
            this.btnTipoTarjetaLoad.Click += new System.EventHandler(this.btnTipoTarjetaLoad_Click);
            // 
            // txtNombreTdT
            // 
            this.txtNombreTdT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreTdT.ForeColor = System.Drawing.Color.White;
            this.txtNombreTdT.Location = new System.Drawing.Point(49, 156);
            this.txtNombreTdT.Name = "txtNombreTdT";
            this.txtNombreTdT.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTdT.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 75;
            this.label1.Text = "Cargar Tipos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(210, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(337, 31);
            this.label15.TabIndex = 74;
            this.label15.Text = "Lista de Tipos de Tarjeta";
            // 
            // tablaTipoTarjeta
            // 
            this.tablaTipoTarjeta.AllowUserToAddRows = false;
            this.tablaTipoTarjeta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaTipoTarjeta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaTipoTarjeta.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaTipoTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaTipoTarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipoTarjeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipo,
            this.Nombre,
            this.Borrado});
            this.tablaTipoTarjeta.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaTipoTarjeta.Location = new System.Drawing.Point(249, 44);
            this.tablaTipoTarjeta.Name = "tablaTipoTarjeta";
            this.tablaTipoTarjeta.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTipoTarjeta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaTipoTarjeta.Size = new System.Drawing.Size(246, 298);
            this.tablaTipoTarjeta.TabIndex = 73;
            this.tablaTipoTarjeta.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 79;
            this.label3.Text = "de Tarjeta";
            // 
            // idTipo
            // 
            this.idTipo.DataPropertyName = "idTipo";
            this.idTipo.HeaderText = "Id";
            this.idTipo.Name = "idTipo";
            this.idTipo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // TipoTarjeta_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTipoTarjetaLoad);
            this.Controls.Add(this.txtNombreTdT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tablaTipoTarjeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TipoTarjeta_Load";
            this.Text = "TipoTarjeta_Load";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoTarjeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTipoTarjetaLoad;
        private System.Windows.Forms.TextBox txtNombreTdT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tablaTipoTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}