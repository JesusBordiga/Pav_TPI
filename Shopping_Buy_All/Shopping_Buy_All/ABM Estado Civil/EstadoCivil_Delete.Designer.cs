namespace Shopping_Buy_All.ABM_Estado_Civil
{
    partial class EstadoCivil_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoCivil_Delete));
            this.label3 = new System.Windows.Forms.Label();
            this.btnECDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarEC = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tablaEC = new System.Windows.Forms.DataGridView();
            this.TipoEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEC)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 31);
            this.label3.TabIndex = 153;
            this.label3.Text = "Estados Civiles";
            // 
            // btnECDelete
            // 
            this.btnECDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnECDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnECDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnECDelete.ForeColor = System.Drawing.Color.White;
            this.btnECDelete.Location = new System.Drawing.Point(79, 318);
            this.btnECDelete.Name = "btnECDelete";
            this.btnECDelete.Size = new System.Drawing.Size(75, 23);
            this.btnECDelete.TabIndex = 152;
            this.btnECDelete.Text = "Dar de Baja";
            this.btnECDelete.UseVisualStyleBackColor = false;
            this.btnECDelete.Click += new System.EventHandler(this.btnECDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 151;
            this.label2.Text = "Nombre";
            // 
            // btnBuscarEC
            // 
            this.btnBuscarEC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBuscarEC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEC.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEC.Location = new System.Drawing.Point(79, 318);
            this.btnBuscarEC.Name = "btnBuscarEC";
            this.btnBuscarEC.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEC.TabIndex = 150;
            this.btnBuscarEC.Text = "Buscar";
            this.btnBuscarEC.UseVisualStyleBackColor = false;
            this.btnBuscarEC.Click += new System.EventHandler(this.btnBuscarEC_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(70, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 148;
            this.label1.Text = "Buscar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(222, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(327, 31);
            this.label15.TabIndex = 147;
            this.label15.Text = "Lista de Estados Civiles";
            // 
            // tablaEC
            // 
            this.tablaEC.AllowUserToAddRows = false;
            this.tablaEC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaEC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaEC.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaEC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaEC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoEstadoCivil,
            this.NombreEstadoCivil,
            this.Borrado});
            this.tablaEC.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaEC.Location = new System.Drawing.Point(267, 43);
            this.tablaEC.Name = "tablaEC";
            this.tablaEC.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEC.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaEC.Size = new System.Drawing.Size(246, 298);
            this.tablaEC.TabIndex = 146;
            this.tablaEC.TabStop = false;
            this.tablaEC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEC_CellContentClick);
            // 
            // TipoEstadoCivil
            // 
            this.TipoEstadoCivil.DataPropertyName = "TipoEstadoCivil";
            this.TipoEstadoCivil.HeaderText = "Id";
            this.TipoEstadoCivil.Name = "TipoEstadoCivil";
            this.TipoEstadoCivil.ReadOnly = true;
            // 
            // NombreEstadoCivil
            // 
            this.NombreEstadoCivil.DataPropertyName = "NombreEstadoCivil";
            this.NombreEstadoCivil.HeaderText = "Nombre";
            this.NombreEstadoCivil.Name = "NombreEstadoCivil";
            this.NombreEstadoCivil.ReadOnly = true;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // EstadoCivil_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnECDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarEC);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tablaEC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstadoCivil_Delete";
            this.Text = "Borrar Estado Civil";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnECDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarEC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tablaEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}