namespace Shopping_Buy_All
{
    partial class Profesiones_Load
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesiones_Load));
            this.tablaProfesiones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProfesionLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textNombreProfesion = new System.Windows.Forms.TextBox();
            this.bD3K7G01_2022DataSet = new Shopping_Buy_All.BD3K7G01_2022DataSet();
            this.profesionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionesTableAdapter = new Shopping_Buy_All.BD3K7G01_2022DataSetTableAdapters.ProfesionesTableAdapter();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G01_2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionesBindingSource)).BeginInit();
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
            this.tablaProfesiones.Location = new System.Drawing.Point(554, 54);
            this.tablaProfesiones.Name = "tablaProfesiones";
            this.tablaProfesiones.ReadOnly = true;
            this.tablaProfesiones.Size = new System.Drawing.Size(346, 274);
            this.tablaProfesiones.TabIndex = 0;
            this.tablaProfesiones.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Profesion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(590, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Lista de Profesiones";
            // 
            // btnProfesionLoad
            // 
            this.btnProfesionLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesionLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesionLoad.ForeColor = System.Drawing.Color.White;
            this.btnProfesionLoad.Location = new System.Drawing.Point(70, 187);
            this.btnProfesionLoad.Name = "btnProfesionLoad";
            this.btnProfesionLoad.Size = new System.Drawing.Size(75, 23);
            this.btnProfesionLoad.TabIndex = 13;
            this.btnProfesionLoad.Text = "Cargar";
            this.btnProfesionLoad.UseVisualStyleBackColor = true;
            this.btnProfesionLoad.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(187, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textNombreProfesion
            // 
            this.textNombreProfesion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNombreProfesion.ForeColor = System.Drawing.Color.White;
            this.textNombreProfesion.Location = new System.Drawing.Point(142, 92);
            this.textNombreProfesion.Name = "textNombreProfesion";
            this.textNombreProfesion.Size = new System.Drawing.Size(100, 20);
            this.textNombreProfesion.TabIndex = 3;
            // 
            // bD3K7G01_2022DataSet
            // 
            this.bD3K7G01_2022DataSet.DataSetName = "BD3K7G01_2022DataSet";
            this.bD3K7G01_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesionesBindingSource
            // 
            this.profesionesBindingSource.DataMember = "Profesiones";
            this.profesionesBindingSource.DataSource = this.bD3K7G01_2022DataSet;
            // 
            // profesionesTableAdapter
            // 
            this.profesionesTableAdapter.ClearBeforeFill = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_profesion";
            this.Codigo.HeaderText = "Codigo De Profesion";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
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
            // 
            // Profesiones_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 449);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProfesionLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombreProfesion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaProfesiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(1043, 488);
            this.Name = "Profesiones_Load";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Profesion";
            this.Load += new System.EventHandler(this.Profesiones_Load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G01_2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProfesiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProfesionLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textNombreProfesion;
        private BD3K7G01_2022DataSet bD3K7G01_2022DataSet;
        private System.Windows.Forms.BindingSource profesionesBindingSource;
        private BD3K7G01_2022DataSetTableAdapters.ProfesionesTableAdapter profesionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}