namespace Shopping_Buy_All
{
    partial class Profesiones_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesiones_Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaProfesiones = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDeleteProfesion = new System.Windows.Forms.Button();
            this.botonProfesiones = new System.Windows.Forms.Button();
            this.textNombreProfesion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar profesion a eliminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(328, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nombre:";
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
            this.tablaProfesiones.Location = new System.Drawing.Point(157, 181);
            this.tablaProfesiones.Name = "tablaProfesiones";
            this.tablaProfesiones.ReadOnly = true;
            this.tablaProfesiones.Size = new System.Drawing.Size(496, 77);
            this.tablaProfesiones.TabIndex = 64;
            this.tablaProfesiones.TabStop = false;
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
            this.Nombre.Width = 250;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(368, 196);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkGray;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(368, 264);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnDeleteProfesion
            // 
            this.btnDeleteProfesion.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProfesion.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.Trash;
            this.btnDeleteProfesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteProfesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProfesion.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProfesion.Location = new System.Drawing.Point(364, 302);
            this.btnDeleteProfesion.Name = "btnDeleteProfesion";
            this.btnDeleteProfesion.Size = new System.Drawing.Size(76, 73);
            this.btnDeleteProfesion.TabIndex = 67;
            this.btnDeleteProfesion.UseVisualStyleBackColor = false;
            this.btnDeleteProfesion.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // botonProfesiones
            // 
            this.botonProfesiones.BackColor = System.Drawing.Color.DarkGray;
            this.botonProfesiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonProfesiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonProfesiones.ForeColor = System.Drawing.Color.White;
            this.botonProfesiones.Location = new System.Drawing.Point(722, 425);
            this.botonProfesiones.Name = "botonProfesiones";
            this.botonProfesiones.Size = new System.Drawing.Size(75, 23);
            this.botonProfesiones.TabIndex = 68;
            this.botonProfesiones.Text = "Profesiones";
            this.botonProfesiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonProfesiones.UseVisualStyleBackColor = false;
            this.botonProfesiones.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNombreProfesion
            // 
            this.textNombreProfesion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNombreProfesion.ForeColor = System.Drawing.Color.White;
            this.textNombreProfesion.Location = new System.Drawing.Point(424, 100);
            this.textNombreProfesion.Name = "textNombreProfesion";
            this.textNombreProfesion.Size = new System.Drawing.Size(100, 20);
            this.textNombreProfesion.TabIndex = 69;
            // 
            // Profesiones_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNombreProfesion);
            this.Controls.Add(this.botonProfesiones);
            this.Controls.Add(this.btnDeleteProfesion);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaProfesiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Profesiones_Delete";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Profesion";
            this.Load += new System.EventHandler(this.Client_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaProfesiones;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDeleteProfesion;
        private System.Windows.Forms.Button botonProfesiones;
        private System.Windows.Forms.TextBox textNombreProfesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}