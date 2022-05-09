namespace Shopping_Buy_All.ABM_Estado_Civil
{
    partial class EstadoCivil_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoCivil_Modify));
            this.btnBuscarEstadoCivil = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tablaEstadoCivil = new System.Windows.Forms.DataGridView();
            this.TipoEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEstadoCivilModify = new System.Windows.Forms.Button();
            this.txtNombreEC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstadoCivil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarEstadoCivil
            // 
            this.btnBuscarEstadoCivil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBuscarEstadoCivil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEstadoCivil.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEstadoCivil.Location = new System.Drawing.Point(88, 318);
            this.btnBuscarEstadoCivil.Name = "btnBuscarEstadoCivil";
            this.btnBuscarEstadoCivil.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEstadoCivil.TabIndex = 96;
            this.btnBuscarEstadoCivil.Text = "Buscar";
            this.btnBuscarEstadoCivil.UseVisualStyleBackColor = false;
            this.btnBuscarEstadoCivil.Click += new System.EventHandler(this.btnBuscarEstadoCivil_Click);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNuevoNombre.ForeColor = System.Drawing.Color.White;
            this.txtNuevoNombre.Location = new System.Drawing.Point(82, 148);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoNombre.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 94;
            this.label4.Text = "Nuevo Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 62);
            this.label1.TabIndex = 92;
            this.label1.Text = "Buscar Estados\r\nCiviles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(235, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(327, 31);
            this.label15.TabIndex = 91;
            this.label15.Text = "Lista de Estados Civiles";
            // 
            // tablaEstadoCivil
            // 
            this.tablaEstadoCivil.AllowUserToAddRows = false;
            this.tablaEstadoCivil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaEstadoCivil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaEstadoCivil.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaEstadoCivil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEstadoCivil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoEstadoCivil,
            this.NombreEstadoCivil,
            this.Borrado});
            this.tablaEstadoCivil.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaEstadoCivil.Location = new System.Drawing.Point(271, 42);
            this.tablaEstadoCivil.Name = "tablaEstadoCivil";
            this.tablaEstadoCivil.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEstadoCivil.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaEstadoCivil.Size = new System.Drawing.Size(246, 298);
            this.tablaEstadoCivil.TabIndex = 90;
            this.tablaEstadoCivil.TabStop = false;
            this.tablaEstadoCivil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEstadoCivil_CellContentClick);
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
            // btnEstadoCivilModify
            // 
            this.btnEstadoCivilModify.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEstadoCivilModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadoCivilModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoCivilModify.ForeColor = System.Drawing.Color.White;
            this.btnEstadoCivilModify.Location = new System.Drawing.Point(88, 318);
            this.btnEstadoCivilModify.Name = "btnEstadoCivilModify";
            this.btnEstadoCivilModify.Size = new System.Drawing.Size(75, 23);
            this.btnEstadoCivilModify.TabIndex = 99;
            this.btnEstadoCivilModify.Text = "Modificar";
            this.btnEstadoCivilModify.UseVisualStyleBackColor = false;
            this.btnEstadoCivilModify.Click += new System.EventHandler(this.btnEstadoCivilModify_Click);
            // 
            // txtNombreEC
            // 
            this.txtNombreEC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreEC.ForeColor = System.Drawing.Color.White;
            this.txtNombreEC.Location = new System.Drawing.Point(82, 148);
            this.txtNombreEC.Name = "txtNombreEC";
            this.txtNombreEC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEC.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Nombre";
            // 
            // EstadoCivil_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 350);
            this.Controls.Add(this.btnEstadoCivilModify);
            this.Controls.Add(this.txtNombreEC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarEstadoCivil);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tablaEstadoCivil);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EstadoCivil_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Estado Civil";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstadoCivil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarEstadoCivil;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tablaEstadoCivil;
        private System.Windows.Forms.Button btnEstadoCivilModify;
        private System.Windows.Forms.TextBox txtNombreEC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}