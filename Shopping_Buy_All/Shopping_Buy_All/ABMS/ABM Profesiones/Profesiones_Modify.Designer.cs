namespace Shopping_Buy_All
{
    partial class Profesiones_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesiones_Modify));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProfesionLoad = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaProfesiones = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchPanel = new System.Windows.Forms.PictureBox();
            this.btnSearchProfesion = new System.Windows.Forms.Button();
            this.btnSearchClient2 = new System.Windows.Forms.Button();
            this.textNombreProfesion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNuevoNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(115, 419);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProfesionLoad
            // 
            this.btnProfesionLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesionLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesionLoad.ForeColor = System.Drawing.Color.White;
            this.btnProfesionLoad.Location = new System.Drawing.Point(115, 215);
            this.btnProfesionLoad.Name = "btnProfesionLoad";
            this.btnProfesionLoad.Size = new System.Drawing.Size(75, 23);
            this.btnProfesionLoad.TabIndex = 52;
            this.btnProfesionLoad.Text = "Modificar";
            this.btnProfesionLoad.UseVisualStyleBackColor = true;
            this.btnProfesionLoad.Click += new System.EventHandler(this.btnClientLoad_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(586, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(280, 31);
            this.label15.TabIndex = 59;
            this.label15.Text = "Lista de Profesiones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Buscar Profesion";
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
            this.tablaProfesiones.Location = new System.Drawing.Point(431, 40);
            this.tablaProfesiones.Name = "tablaProfesiones";
            this.tablaProfesiones.ReadOnly = true;
            this.tablaProfesiones.Size = new System.Drawing.Size(549, 397);
            this.tablaProfesiones.TabIndex = 30;
            this.tablaProfesiones.TabStop = false;
            this.tablaProfesiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaClientes_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_profesion";
            this.Codigo.HeaderText = "Codigo ";
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
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.Location = new System.Drawing.Point(29, 114);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(245, 269);
            this.SearchPanel.TabIndex = 61;
            this.SearchPanel.TabStop = false;
            // 
            // btnSearchProfesion
            // 
            this.btnSearchProfesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProfesion.ForeColor = System.Drawing.Color.White;
            this.btnSearchProfesion.Location = new System.Drawing.Point(199, 419);
            this.btnSearchProfesion.Name = "btnSearchProfesion";
            this.btnSearchProfesion.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProfesion.TabIndex = 62;
            this.btnSearchProfesion.Text = "Buscar";
            this.btnSearchProfesion.UseVisualStyleBackColor = true;
            this.btnSearchProfesion.Click += new System.EventHandler(this.btnBuscarCliente_click);
            // 
            // btnSearchClient2
            // 
            this.btnSearchClient2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClient2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient2.ForeColor = System.Drawing.Color.White;
            this.btnSearchClient2.Location = new System.Drawing.Point(199, 419);
            this.btnSearchClient2.Name = "btnSearchClient2";
            this.btnSearchClient2.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient2.TabIndex = 63;
            this.btnSearchClient2.Text = "Buscar";
            this.btnSearchClient2.UseVisualStyleBackColor = true;
            this.btnSearchClient2.Click += new System.EventHandler(this.btnSearchClient2_Click);
            // 
            // textNombreProfesion
            // 
            this.textNombreProfesion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNombreProfesion.ForeColor = System.Drawing.Color.White;
            this.textNombreProfesion.Location = new System.Drawing.Point(151, 88);
            this.textNombreProfesion.Name = "textNombreProfesion";
            this.textNombreProfesion.Size = new System.Drawing.Size(100, 20);
            this.textNombreProfesion.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Nuevo Nombre:";
            this.label2.Visible = false;
            // 
            // textNuevoNombre
            // 
            this.textNuevoNombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNuevoNombre.ForeColor = System.Drawing.Color.White;
            this.textNuevoNombre.Location = new System.Drawing.Point(151, 158);
            this.textNuevoNombre.Name = "textNuevoNombre";
            this.textNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.textNuevoNombre.TabIndex = 72;
            this.textNuevoNombre.Visible = false;
            // 
            // Profesiones_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 449);
            this.Controls.Add(this.textNuevoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombreProfesion);
            this.Controls.Add(this.btnSearchProfesion);
            this.Controls.Add(this.btnSearchClient2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.btnProfesionLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaProfesiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(1043, 488);
            this.Name = "Profesiones_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Profesiones";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProfesionLoad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaProfesiones;
        private System.Windows.Forms.PictureBox SearchPanel;
        private System.Windows.Forms.Button btnSearchProfesion;
        private System.Windows.Forms.Button btnSearchClient2;
        private System.Windows.Forms.TextBox textNombreProfesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNuevoNombre;
    }
}