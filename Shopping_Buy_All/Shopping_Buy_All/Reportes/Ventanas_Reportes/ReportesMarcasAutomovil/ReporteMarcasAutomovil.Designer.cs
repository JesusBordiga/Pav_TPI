namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesMarcasTarjetas
{
    partial class ReporteMarcasAutomovil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMarcasAutomovil));
            this.rbRangoId = new System.Windows.Forms.RadioButton();
            this.rbPorLetra = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.repMarc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.txt_restriccion = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbRangoId
            // 
            this.rbRangoId.AutoSize = true;
            this.rbRangoId.BackColor = System.Drawing.Color.Transparent;
            this.rbRangoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRangoId.ForeColor = System.Drawing.SystemColors.Control;
            this.rbRangoId.Location = new System.Drawing.Point(187, 39);
            this.rbRangoId.Name = "rbRangoId";
            this.rbRangoId.Size = new System.Drawing.Size(228, 21);
            this.rbRangoId.TabIndex = 4;
            this.rbRangoId.Text = "Restringido por rango de ID";
            this.rbRangoId.UseVisualStyleBackColor = false;
            this.rbRangoId.CheckedChanged += new System.EventHandler(this.rbRangoCheckedChanged);
            // 
            // rbPorLetra
            // 
            this.rbPorLetra.AutoSize = true;
            this.rbPorLetra.BackColor = System.Drawing.Color.Transparent;
            this.rbPorLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorLetra.ForeColor = System.Drawing.SystemColors.Control;
            this.rbPorLetra.Location = new System.Drawing.Point(11, 60);
            this.rbPorLetra.Name = "rbPorLetra";
            this.rbPorLetra.Size = new System.Drawing.Size(247, 21);
            this.rbPorLetra.TabIndex = 5;
            this.rbPorLetra.Text = "Restringido por letra (nombre)";
            this.rbPorLetra.UseVisualStyleBackColor = false;
            this.rbPorLetra.CheckedChanged += new System.EventHandler(this.rbPorLetraCheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.rbTodos.Location = new System.Drawing.Point(11, 37);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(174, 21);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los productos";
            this.rbTodos.UseVisualStyleBackColor = false;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodosCheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(6, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Reportes de Marcas";
            // 
            // repMarc
            // 
            this.repMarc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repMarc.Cursor = System.Windows.Forms.Cursors.Default;
            this.repMarc.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoDetalle.rdlc";
            this.repMarc.Location = new System.Drawing.Point(9, 93);
            this.repMarc.Name = "repMarc";
            this.repMarc.ServerReport.BearerToken = null;
            this.repMarc.Size = new System.Drawing.Size(626, 352);
            this.repMarc.TabIndex = 12;
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.BackColor = System.Drawing.Color.Transparent;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestriccion.Location = new System.Drawing.Point(496, 25);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(89, 17);
            this.lblRestriccion.TabIndex = 31;
            this.lblRestriccion.Text = "Restriccion";
            // 
            // txt_restriccion
            // 
            this.txt_restriccion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_restriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_restriccion.Location = new System.Drawing.Point(493, 43);
            this.txt_restriccion.Mask = "LLLLLLLL";
            this.txt_restriccion.Name = "txt_restriccion";
            this.txt_restriccion.PromptChar = '⠀';
            this.txt_restriccion.Size = new System.Drawing.Size(142, 20);
            this.txt_restriccion.TabIndex = 30;
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_buscar01.ForeColor = System.Drawing.Color.White;
            this.btn_buscar01.Location = new System.Drawing.Point(560, 69);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar01.TabIndex = 32;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = false;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click_1);
            // 
            // ReporteMarcasAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 449);
            this.Controls.Add(this.btn_buscar01);
            this.Controls.Add(this.lblRestriccion);
            this.Controls.Add(this.txt_restriccion);
            this.Controls.Add(this.repMarc);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbRangoId);
            this.Controls.Add(this.rbPorLetra);
            this.Controls.Add(this.rbTodos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReporteMarcasAutomovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Marcas";
            this.Load += new System.EventHandler(this.ReporteMarcasAutomovil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbRangoId;
        private System.Windows.Forms.RadioButton rbPorLetra;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.Reporting.WinForms.ReportViewer repMarc;
        private System.Windows.Forms.Label lblRestriccion;
        private System.Windows.Forms.MaskedTextBox txt_restriccion;
        private System.Windows.Forms.Button btn_buscar01;
    }
}