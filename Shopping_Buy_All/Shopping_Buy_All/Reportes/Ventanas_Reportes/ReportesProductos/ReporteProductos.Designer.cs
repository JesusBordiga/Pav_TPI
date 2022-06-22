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
            this.rbRangoId = new System.Windows.Forms.RadioButton();
            this.rbPorLetra = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.repProd = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.grbRangoPrecio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecHasta = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLetra = new System.Windows.Forms.Panel();
            this.lblLetra = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.MaskedTextBox();
            this.grbRangoPrecio.SuspendLayout();
            this.grbLetra.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbRangoId
            // 
            this.rbRangoId.AutoSize = true;
            this.rbRangoId.BackColor = System.Drawing.Color.Transparent;
            this.rbRangoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbRangoId.ForeColor = System.Drawing.SystemColors.Control;
            this.rbRangoId.Location = new System.Drawing.Point(171, 37);
            this.rbRangoId.Name = "rbRangoId";
            this.rbRangoId.Size = new System.Drawing.Size(229, 19);
            this.rbRangoId.TabIndex = 4;
            this.rbRangoId.Text = "Restringido por rango de precio";
            this.rbRangoId.UseVisualStyleBackColor = false;
            this.rbRangoId.CheckedChanged += new System.EventHandler(this.rbRangoCheckedChanged);
            // 
            // rbPorLetra
            // 
            this.rbPorLetra.AutoSize = true;
            this.rbPorLetra.BackColor = System.Drawing.Color.Transparent;
            this.rbPorLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbPorLetra.ForeColor = System.Drawing.SystemColors.Control;
            this.rbPorLetra.Location = new System.Drawing.Point(11, 60);
            this.rbPorLetra.Name = "rbPorLetra";
            this.rbPorLetra.Size = new System.Drawing.Size(220, 19);
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
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.rbTodos.Location = new System.Drawing.Point(11, 37);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(154, 19);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los productos";
            this.rbTodos.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(6, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Reportes de Productos";
            // 
            // repProd
            // 
            this.repProd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repProd.Cursor = System.Windows.Forms.Cursors.Default;
            this.repProd.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoDetalle.rdlc";
            this.repProd.Location = new System.Drawing.Point(9, 93);
            this.repProd.Name = "repProd";
            this.repProd.ServerReport.BearerToken = null;
            this.repProd.Size = new System.Drawing.Size(694, 371);
            this.repProd.TabIndex = 12;
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_buscar01.ForeColor = System.Drawing.Color.White;
            this.btn_buscar01.Location = new System.Drawing.Point(628, 64);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar01.TabIndex = 32;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = false;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click_1);
            // 
            // grbRangoPrecio
            // 
            this.grbRangoPrecio.BackColor = System.Drawing.Color.Transparent;
            this.grbRangoPrecio.Controls.Add(this.label2);
            this.grbRangoPrecio.Controls.Add(this.txtPrecHasta);
            this.grbRangoPrecio.Controls.Add(this.txtPrecDesde);
            this.grbRangoPrecio.Controls.Add(this.label1);
            this.grbRangoPrecio.Location = new System.Drawing.Point(454, 34);
            this.grbRangoPrecio.Name = "grbRangoPrecio";
            this.grbRangoPrecio.Size = new System.Drawing.Size(249, 28);
            this.grbRangoPrecio.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(134, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "hasta";
            // 
            // txtPrecHasta
            // 
            this.txtPrecHasta.Location = new System.Drawing.Point(179, 5);
            this.txtPrecHasta.Mask = "999999999";
            this.txtPrecHasta.Name = "txtPrecHasta";
            this.txtPrecHasta.PromptChar = '⠀';
            this.txtPrecHasta.Size = new System.Drawing.Size(67, 20);
            this.txtPrecHasta.TabIndex = 2;
            this.txtPrecHasta.Enter += new System.EventHandler(this.TxtPrecHasta_Enter);
            // 
            // txtPrecDesde
            // 
            this.txtPrecDesde.Location = new System.Drawing.Point(61, 5);
            this.txtPrecDesde.Mask = "999999999";
            this.txtPrecDesde.Name = "txtPrecDesde";
            this.txtPrecDesde.PromptChar = '⠀';
            this.txtPrecDesde.Size = new System.Drawing.Size(67, 20);
            this.txtPrecDesde.TabIndex = 1;
            this.txtPrecDesde.Enter += new System.EventHandler(this.TxtPrecDesde_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio:";
            // 
            // grbLetra
            // 
            this.grbLetra.BackColor = System.Drawing.Color.Transparent;
            this.grbLetra.Controls.Add(this.lblLetra);
            this.grbLetra.Controls.Add(this.txtLetra);
            this.grbLetra.Location = new System.Drawing.Point(608, 34);
            this.grbLetra.Name = "grbLetra";
            this.grbLetra.Size = new System.Drawing.Size(95, 28);
            this.grbLetra.TabIndex = 34;
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.BackColor = System.Drawing.Color.Transparent;
            this.lblLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblLetra.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLetra.Location = new System.Drawing.Point(13, 6);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(44, 15);
            this.lblLetra.TabIndex = 1;
            this.lblLetra.Text = "Letra:";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(63, 7);
            this.txtLetra.Mask = "L";
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.PromptChar = '⠀';
            this.txtLetra.Size = new System.Drawing.Size(32, 20);
            this.txtLetra.TabIndex = 0;
            this.txtLetra.Enter += new System.EventHandler(this.MaskedTextBox1_Enter);
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 476);
            this.Controls.Add(this.grbLetra);
            this.Controls.Add(this.grbRangoPrecio);
            this.Controls.Add(this.btn_buscar01);
            this.Controls.Add(this.repProd);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbRangoId);
            this.Controls.Add(this.rbPorLetra);
            this.Controls.Add(this.rbTodos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Productos";
            this.grbRangoPrecio.ResumeLayout(false);
            this.grbRangoPrecio.PerformLayout();
            this.grbLetra.ResumeLayout(false);
            this.grbLetra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbRangoId;
        private System.Windows.Forms.RadioButton rbPorLetra;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.Reporting.WinForms.ReportViewer repProd;
        private System.Windows.Forms.Button btn_buscar01;
        private System.Windows.Forms.Panel grbRangoPrecio;
        private System.Windows.Forms.Panel grbLetra;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.MaskedTextBox txtLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPrecHasta;
        private System.Windows.Forms.MaskedTextBox txtPrecDesde;
    }
}