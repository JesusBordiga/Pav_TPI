namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesMarcasTarjetas
{
    partial class ReporteProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteProductos));
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rb_rango_id = new System.Windows.Forms.RadioButton();
            this.rb_x_letra = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txt_restriccion = new System.Windows.Forms.MaskedTextBox();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rv01
            // 
            this.rv01.Cursor = System.Windows.Forms.Cursors.Default;
            this.rv01.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoDetalle.rdlc";
            this.rv01.Location = new System.Drawing.Point(0, 96);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(788, 352);
            this.rv01.TabIndex = 0;
            // 
            // rb_rango_id
            // 
            this.rb_rango_id.AutoSize = true;
            this.rb_rango_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_rango_id.Location = new System.Drawing.Point(172, 37);
            this.rb_rango_id.Name = "rb_rango_id";
            this.rb_rango_id.Size = new System.Drawing.Size(227, 21);
            this.rb_rango_id.TabIndex = 4;
            this.rb_rango_id.Text = "Restringido por rango de precio";
            this.rb_rango_id.UseVisualStyleBackColor = true;
            this.rb_rango_id.CheckedChanged += new System.EventHandler(this.rbRangoCheckedChanged);
            // 
            // rb_x_letra
            // 
            this.rb_x_letra.AutoSize = true;
            this.rb_x_letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_x_letra.Location = new System.Drawing.Point(11, 60);
            this.rb_x_letra.Name = "rb_x_letra";
            this.rb_x_letra.Size = new System.Drawing.Size(217, 21);
            this.rb_x_letra.TabIndex = 5;
            this.rb_x_letra.Text = "Restringido por letra (nombre)";
            this.rb_x_letra.UseVisualStyleBackColor = true;
            this.rb_x_letra.CheckedChanged += new System.EventHandler(this.rbPorLetraCheckedChanged);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Checked = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_todos.Location = new System.Drawing.Point(11, 37);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(155, 21);
            this.rb_todos.TabIndex = 6;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos los productos";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rbTodosCheckedChanged);
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar01.Location = new System.Drawing.Point(713, 96);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(75, 26);
            this.btn_buscar01.TabIndex = 7;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = true;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Reportes de Productos";
            // 
            // txt_restriccion
            // 
            this.txt_restriccion.Location = new System.Drawing.Point(575, 51);
            this.txt_restriccion.Mask = "LLLLLLLL";
            this.txt_restriccion.Name = "txt_restriccion";
            this.txt_restriccion.PromptChar = '⠀';
            this.txt_restriccion.Size = new System.Drawing.Size(142, 20);
            this.txt_restriccion.TabIndex = 9;
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.Location = new System.Drawing.Point(479, 54);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(63, 13);
            this.lblRestriccion.TabIndex = 10;
            this.lblRestriccion.Text = "Restriccion:";
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 449);
            this.Controls.Add(this.lblRestriccion);
            this.Controls.Add(this.txt_restriccion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rb_rango_id);
            this.Controls.Add(this.rb_x_letra);
            this.Controls.Add(this.rb_todos);
            this.Controls.Add(this.btn_buscar01);
            this.Controls.Add(this.rv01);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(803, 488);
            this.MinimumSize = new System.Drawing.Size(803, 488);
            this.Name = "ReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Productos";
            this.Load += new System.EventHandler(this.ReporteProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private System.Windows.Forms.RadioButton rb_rango_id;
        private System.Windows.Forms.RadioButton rb_x_letra;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.Button btn_buscar01;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox txt_restriccion;
        private System.Windows.Forms.Label lblRestriccion;
    }
}