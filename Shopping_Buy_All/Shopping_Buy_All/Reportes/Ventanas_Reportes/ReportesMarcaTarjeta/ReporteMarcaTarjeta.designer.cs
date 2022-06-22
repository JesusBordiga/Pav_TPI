namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesProductos
{
    partial class ReporteMarcaTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMarcaTarjeta));
            this.rb_x_id = new System.Windows.Forms.RadioButton();
            this.rb_x_letra = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.text_restriccion = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rb_x_id
            // 
            this.rb_x_id.AutoSize = true;
            this.rb_x_id.BackColor = System.Drawing.Color.Transparent;
            this.rb_x_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_x_id.ForeColor = System.Drawing.Color.White;
            this.rb_x_id.Location = new System.Drawing.Point(11, 87);
            this.rb_x_id.Name = "rb_x_id";
            this.rb_x_id.Size = new System.Drawing.Size(156, 21);
            this.rb_x_id.TabIndex = 4;
            this.rb_x_id.Text = "Restringido por Id";
            this.rb_x_id.UseVisualStyleBackColor = false;
            this.rb_x_id.CheckedChanged += new System.EventHandler(this.rbIdCheckedChanged);
            // 
            // rb_x_letra
            // 
            this.rb_x_letra.AutoSize = true;
            this.rb_x_letra.BackColor = System.Drawing.Color.Transparent;
            this.rb_x_letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_x_letra.ForeColor = System.Drawing.Color.White;
            this.rb_x_letra.Location = new System.Drawing.Point(11, 60);
            this.rb_x_letra.Name = "rb_x_letra";
            this.rb_x_letra.Size = new System.Drawing.Size(176, 21);
            this.rb_x_letra.TabIndex = 5;
            this.rb_x_letra.Text = "Restringido por letra";
            this.rb_x_letra.UseVisualStyleBackColor = false;
            this.rb_x_letra.CheckedChanged += new System.EventHandler(this.rb_x_letraCheckedChanged);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.BackColor = System.Drawing.Color.Transparent;
            this.rb_todos.Checked = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_todos.ForeColor = System.Drawing.Color.White;
            this.rb_todos.Location = new System.Drawing.Point(11, 37);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(170, 21);
            this.rb_todos.TabIndex = 6;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos los vehiculos";
            this.rb_todos.UseVisualStyleBackColor = false;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rbTodosCheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(6, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Reportes de Vehiculos";
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.BackColor = System.Drawing.Color.Transparent;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestriccion.Location = new System.Drawing.Point(397, 42);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(89, 17);
            this.lblRestriccion.TabIndex = 29;
            this.lblRestriccion.Text = "Restriccion";
            // 
            // text_restriccion
            // 
            this.text_restriccion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.text_restriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.text_restriccion.Location = new System.Drawing.Point(372, 60);
            this.text_restriccion.Mask = "LLLLLLLL";
            this.text_restriccion.Name = "text_restriccion";
            this.text_restriccion.PromptChar = '⠀';
            this.text_restriccion.Size = new System.Drawing.Size(142, 20);
            this.text_restriccion.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(461, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rv01
            // 
            this.rv01.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rv01.Cursor = System.Windows.Forms.Cursors.Default;
            this.rv01.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoDetalle.rdlc";
            this.rv01.Location = new System.Drawing.Point(26, 114);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(488, 328);
            this.rv01.TabIndex = 30;
            // 
            // ReporteMarcaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 449);
            this.Controls.Add(this.rv01);
            this.Controls.Add(this.lblRestriccion);
            this.Controls.Add(this.text_restriccion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rb_x_id);
            this.Controls.Add(this.rb_x_letra);
            this.Controls.Add(this.rb_todos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReporteMarcaTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Vehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_x_id;
        private System.Windows.Forms.RadioButton rb_x_letra;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRestriccion;
        private System.Windows.Forms.MaskedTextBox text_restriccion;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
    }
}