﻿namespace Shopping_Buy_All
{
    partial class Usuarios_Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios_Ventana));
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAltaUsuario.Location = new System.Drawing.Point(78, 70);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(126, 26);
            this.btnAltaUsuario.TabIndex = 0;
            this.btnAltaUsuario.Text = "Alta Usuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = false;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // Usuarios_Ventana
            // 
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.btnAltaUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios_Ventana";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Button btnAltaUsuario;
    }
}