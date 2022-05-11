namespace Shopping_Buy_All
{
    partial class Profesiones_Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesiones_Ventana));
            this.btnAltaProfesiones = new System.Windows.Forms.Button();
            this.btnModificarProfesiones = new System.Windows.Forms.Button();
            this.btnEliminarProfesiones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaProfesiones
            // 
            this.btnAltaProfesiones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAltaProfesiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltaProfesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProfesiones.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAltaProfesiones.Location = new System.Drawing.Point(68, 24);
            this.btnAltaProfesiones.Name = "btnAltaProfesiones";
            this.btnAltaProfesiones.Size = new System.Drawing.Size(146, 26);
            this.btnAltaProfesiones.TabIndex = 0;
            this.btnAltaProfesiones.Text = "Alta Profesiones";
            this.btnAltaProfesiones.UseVisualStyleBackColor = false;
            this.btnAltaProfesiones.Click += new System.EventHandler(this.btnAltaProfesiones_Click);
            // 
            // btnModificarProfesiones
            // 
            this.btnModificarProfesiones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModificarProfesiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarProfesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProfesiones.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificarProfesiones.Location = new System.Drawing.Point(68, 70);
            this.btnModificarProfesiones.Name = "btnModificarProfesiones";
            this.btnModificarProfesiones.Size = new System.Drawing.Size(146, 26);
            this.btnModificarProfesiones.TabIndex = 1;
            this.btnModificarProfesiones.Text = "Modificar Profesiones";
            this.btnModificarProfesiones.UseVisualStyleBackColor = false;
            this.btnModificarProfesiones.Click += new System.EventHandler(this.btnModificarProfesiones_Click);
            // 
            // btnEliminarProfesiones
            // 
            this.btnEliminarProfesiones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEliminarProfesiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProfesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProfesiones.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarProfesiones.Location = new System.Drawing.Point(68, 116);
            this.btnEliminarProfesiones.Name = "btnEliminarProfesiones";
            this.btnEliminarProfesiones.Size = new System.Drawing.Size(146, 26);
            this.btnEliminarProfesiones.TabIndex = 2;
            this.btnEliminarProfesiones.Text = "Eliminar Profesiones";
            this.btnEliminarProfesiones.UseVisualStyleBackColor = false;
            this.btnEliminarProfesiones.Click += new System.EventHandler(this.btnEliminarProfesiones_Click);
            // 
            // Profesiones_Ventana
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.btnEliminarProfesiones);
            this.Controls.Add(this.btnModificarProfesiones);
            this.Controls.Add(this.btnAltaProfesiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profesiones_Ventana";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesiones";
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Button btnAltaProfesiones;
        private System.Windows.Forms.Button btnModificarProfesiones;
        private System.Windows.Forms.Button btnEliminarProfesiones;
    }
}