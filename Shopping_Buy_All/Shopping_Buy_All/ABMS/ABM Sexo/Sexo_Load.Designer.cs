﻿namespace Shopping_Buy_All.ABM_Sexo
{
    partial class Sexo_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sexo_Load));
            this.btnSexoLoad = new System.Windows.Forms.Button();
            this.txtNombreSexo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tablaSexo = new System.Windows.Forms.DataGridView();
            this.TipoSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSexoLoad
            // 
            this.btnSexoLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSexoLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSexoLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSexoLoad.ForeColor = System.Drawing.Color.White;
            this.btnSexoLoad.Location = new System.Drawing.Point(32, 257);
            this.btnSexoLoad.Name = "btnSexoLoad";
            this.btnSexoLoad.Size = new System.Drawing.Size(75, 23);
            this.btnSexoLoad.TabIndex = 2;
            this.btnSexoLoad.Text = "Cargar";
            this.btnSexoLoad.UseVisualStyleBackColor = false;
            this.btnSexoLoad.Click += new System.EventHandler(this.btnSexoLoad_Click);
            // 
            // txtNombreSexo
            // 
            this.txtNombreSexo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreSexo.ForeColor = System.Drawing.Color.White;
            this.txtNombreSexo.Location = new System.Drawing.Point(87, 101);
            this.txtNombreSexo.Name = "txtNombreSexo";
            this.txtNombreSexo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSexo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 44);
            this.label1.TabIndex = 69;
            this.label1.Text = "Cargar nombre\r\nde Sexo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(258, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 22);
            this.label15.TabIndex = 68;
            this.label15.Text = "Lista de Sexos";
            // 
            // tablaSexo
            // 
            this.tablaSexo.AllowUserToAddRows = false;
            this.tablaSexo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaSexo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaSexo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaSexo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoSexo,
            this.NombreSexo,
            this.Borrado});
            this.tablaSexo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaSexo.Location = new System.Drawing.Point(216, 44);
            this.tablaSexo.Name = "tablaSexo";
            this.tablaSexo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSexo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaSexo.RowHeadersWidth = 10;
            this.tablaSexo.Size = new System.Drawing.Size(230, 239);
            this.tablaSexo.TabIndex = 101;
            this.tablaSexo.TabStop = false;
            // 
            // TipoSexo
            // 
            this.TipoSexo.DataPropertyName = "TipoSexo";
            this.TipoSexo.HeaderText = "Id";
            this.TipoSexo.Name = "TipoSexo";
            this.TipoSexo.ReadOnly = true;
            // 
            // NombreSexo
            // 
            this.NombreSexo.DataPropertyName = "NombreSexo";
            this.NombreSexo.HeaderText = "Nombre";
            this.NombreSexo.Name = "NombreSexo";
            this.NombreSexo.ReadOnly = true;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(113, 257);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 102;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Sexo_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 292);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tablaSexo);
            this.Controls.Add(this.btnSexoLoad);
            this.Controls.Add(this.txtNombreSexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sexo_Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Sexo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaSexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSexoLoad;
        private System.Windows.Forms.TextBox txtNombreSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tablaSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.Button btnLimpiar;
    }
}