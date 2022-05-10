namespace Shopping_Buy_All.ABM_Cliente
{
    partial class Grilla_Profesiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grilla_Profesiones));
            this.tablaProfesiones = new System.Windows.Forms.DataGridView();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProfesiones
            // 
            this.tablaProfesiones.AllowUserToAddRows = false;
            this.tablaProfesiones.AllowUserToDeleteRows = false;
            this.tablaProfesiones.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaProfesiones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaProfesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProfesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Borrado});
            this.tablaProfesiones.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaProfesiones.Location = new System.Drawing.Point(13, 12);
            this.tablaProfesiones.Name = "tablaProfesiones";
            this.tablaProfesiones.ReadOnly = true;
            this.tablaProfesiones.Size = new System.Drawing.Size(545, 277);
            this.tablaProfesiones.TabIndex = 70;
            this.tablaProfesiones.TabStop = false;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.menu_editor;
            this.btnDeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Location = new System.Drawing.Point(13, 305);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteClient.TabIndex = 71;
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_profesion";
            this.Codigo.HeaderText = "Codigo Profesion";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            // 
            // Grilla_Profesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 347);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.tablaProfesiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(714, 386);
            this.MinimumSize = new System.Drawing.Size(300, 386);
            this.Name = "Grilla_Profesiones";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tabla de profesiones";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProfesiones;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}