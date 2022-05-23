namespace Shopping_Buy_All.ABMS.ABM_Profesiones
{
    partial class Profesion_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesion_Modify));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProfModify = new System.Windows.Forms.Button();
            this.txtNombreProf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tablaProfesiones = new System.Windows.Forms.DataGridView();
            this.Cod_profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProf = new System.Windows.Forms.Button();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(99, 261);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 161;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnProfModify
            // 
            this.btnProfModify.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnProfModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfModify.ForeColor = System.Drawing.Color.White;
            this.btnProfModify.Location = new System.Drawing.Point(18, 261);
            this.btnProfModify.Name = "btnProfModify";
            this.btnProfModify.Size = new System.Drawing.Size(75, 23);
            this.btnProfModify.TabIndex = 160;
            this.btnProfModify.Text = "Modificar";
            this.btnProfModify.UseVisualStyleBackColor = false;
            this.btnProfModify.Click += new System.EventHandler(this.btnProfModify_Click);
            // 
            // txtNombreProf
            // 
            this.txtNombreProf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreProf.ForeColor = System.Drawing.Color.White;
            this.txtNombreProf.Location = new System.Drawing.Point(80, 90);
            this.txtNombreProf.Name = "txtNombreProf";
            this.txtNombreProf.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProf.TabIndex = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 50);
            this.label1.TabIndex = 157;
            this.label1.Text = "Buscar \r\nProfesion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(206, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 22);
            this.label15.TabIndex = 156;
            this.label15.Text = "Lista de Profesiones";
            // 
            // tablaProfesiones
            // 
            this.tablaProfesiones.AllowUserToAddRows = false;
            this.tablaProfesiones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaProfesiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProfesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProfesiones.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaProfesiones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaProfesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProfesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_profesion,
            this.Nombre});
            this.tablaProfesiones.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaProfesiones.Location = new System.Drawing.Point(186, 31);
            this.tablaProfesiones.Name = "tablaProfesiones";
            this.tablaProfesiones.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProfesiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProfesiones.RowHeadersWidth = 10;
            this.tablaProfesiones.Size = new System.Drawing.Size(234, 253);
            this.tablaProfesiones.TabIndex = 155;
            this.tablaProfesiones.TabStop = false;
            this.tablaProfesiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProfesiones_CellContentClick);
            // 
            // Cod_profesion
            // 
            this.Cod_profesion.DataPropertyName = "Cod_profesion";
            this.Cod_profesion.HeaderText = "Id";
            this.Cod_profesion.Name = "Cod_profesion";
            this.Cod_profesion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // btnBuscarProf
            // 
            this.btnBuscarProf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBuscarProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProf.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProf.Location = new System.Drawing.Point(18, 261);
            this.btnBuscarProf.Name = "btnBuscarProf";
            this.btnBuscarProf.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProf.TabIndex = 162;
            this.btnBuscarProf.Text = "Buscar";
            this.btnBuscarProf.UseVisualStyleBackColor = false;
            this.btnBuscarProf.Click += new System.EventHandler(this.btnBuscarProf_Click);
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreNuevo.ForeColor = System.Drawing.Color.White;
            this.txtNombreNuevo.Location = new System.Drawing.Point(80, 90);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreNuevo.TabIndex = 163;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 34);
            this.label3.TabIndex = 164;
            this.label3.Text = "Nombre\r\nNuevo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 165;
            this.label4.Text = "Nombre:";
            // 
            // Profesion_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.btnBuscarProf);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProfModify);
            this.Controls.Add(this.txtNombreProf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tablaProfesiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profesion_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Profesion";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProfModify;
        private System.Windows.Forms.TextBox txtNombreProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tablaProfesiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnBuscarProf;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}