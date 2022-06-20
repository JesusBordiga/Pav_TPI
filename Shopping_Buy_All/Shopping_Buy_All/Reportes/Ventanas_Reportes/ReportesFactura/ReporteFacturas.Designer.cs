namespace Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura
{
    partial class ReporteFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFacturas));
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbRangoId = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.repFac = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.grbRestLocal = new System.Windows.Forms.Panel();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbRestFecha = new System.Windows.Forms.Panel();
            this.lblRestriccion = new System.Windows.Forms.Label();
            this.txtFecHasta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecDesde = new System.Windows.Forms.MaskedTextBox();
            this.grbRestLocal.SuspendLayout();
            this.grbRestFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(2, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 25);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Reportes de Facturas";
            // 
            // rbRangoId
            // 
            this.rbRangoId.AutoSize = true;
            this.rbRangoId.BackColor = System.Drawing.Color.Transparent;
            this.rbRangoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRangoId.ForeColor = System.Drawing.SystemColors.Control;
            this.rbRangoId.Location = new System.Drawing.Point(172, 35);
            this.rbRangoId.Name = "rbRangoId";
            this.rbRangoId.Size = new System.Drawing.Size(235, 19);
            this.rbRangoId.TabIndex = 20;
            this.rbRangoId.Text = "Restringido por fecha de compra";
            this.rbRangoId.UseVisualStyleBackColor = false;
            this.rbRangoId.CheckedChanged += new System.EventHandler(this.rbRangoCheckedChanged);
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.BackColor = System.Drawing.Color.Transparent;
            this.rbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLocal.ForeColor = System.Drawing.SystemColors.Control;
            this.rbLocal.Location = new System.Drawing.Point(7, 58);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(159, 19);
            this.rbLocal.TabIndex = 21;
            this.rbLocal.Text = "Restringido por local";
            this.rbLocal.UseVisualStyleBackColor = false;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.rbPorLocalCheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.rbTodos.Location = new System.Drawing.Point(7, 35);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(146, 19);
            this.rbTodos.TabIndex = 22;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todas las Facturas";
            this.rbTodos.UseVisualStyleBackColor = false;
            // 
            // repFac
            // 
            this.repFac.BackColor = System.Drawing.Color.DimGray;
            this.repFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.repFac.Cursor = System.Windows.Forms.Cursors.Default;
            this.repFac.LocalReport.ReportEmbeddedResource = "Shopping_Buy_All.Reportes.Ventanas_Reportes.ReportesFactura.ListadoDetalle.rdlc";
            this.repFac.Location = new System.Drawing.Point(7, 86);
            this.repFac.Name = "repFac";
            this.repFac.ServerReport.BearerToken = null;
            this.repFac.Size = new System.Drawing.Size(821, 352);
            this.repFac.TabIndex = 19;
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.Location = new System.Drawing.Point(0, 0);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocal.TabIndex = 0;
            // 
            // grbRestLocal
            // 
            this.grbRestLocal.BackColor = System.Drawing.Color.Transparent;
            this.grbRestLocal.Controls.Add(this.cmbLocal);
            this.grbRestLocal.Controls.Add(this.label2);
            this.grbRestLocal.Location = new System.Drawing.Point(528, 24);
            this.grbRestLocal.Name = "grbRestLocal";
            this.grbRestLocal.Size = new System.Drawing.Size(300, 30);
            this.grbRestLocal.TabIndex = 33;
            // 
            // cmbLocal
            // 
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(91, 3);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(204, 21);
            this.cmbLocal.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Resticcion:";
            // 
            // grbRestFecha
            // 
            this.grbRestFecha.BackColor = System.Drawing.Color.Transparent;
            this.grbRestFecha.Controls.Add(this.lblRestriccion);
            this.grbRestFecha.Controls.Add(this.txtFecHasta);
            this.grbRestFecha.Controls.Add(this.label1);
            this.grbRestFecha.Controls.Add(this.txtFecDesde);
            this.grbRestFecha.Location = new System.Drawing.Point(528, 24);
            this.grbRestFecha.Name = "grbRestFecha";
            this.grbRestFecha.Size = new System.Drawing.Size(300, 30);
            this.grbRestFecha.TabIndex = 34;
            // 
            // lblRestriccion
            // 
            this.lblRestriccion.AutoSize = true;
            this.lblRestriccion.BackColor = System.Drawing.Color.Transparent;
            this.lblRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRestriccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestriccion.Location = new System.Drawing.Point(7, 9);
            this.lblRestriccion.Name = "lblRestriccion";
            this.lblRestriccion.Size = new System.Drawing.Size(78, 15);
            this.lblRestriccion.TabIndex = 34;
            this.lblRestriccion.Text = "Resticcion:";
            // 
            // txtFecHasta
            // 
            this.txtFecHasta.Location = new System.Drawing.Point(220, 6);
            this.txtFecHasta.Mask = "99/99/9999";
            this.txtFecHasta.Name = "txtFecHasta";
            this.txtFecHasta.PromptChar = '⠀';
            this.txtFecHasta.Size = new System.Drawing.Size(75, 20);
            this.txtFecHasta.TabIndex = 32;
            this.txtFecHasta.Enter += new System.EventHandler(this.txtFecHasta_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "hasta";
            // 
            // txtFecDesde
            // 
            this.txtFecDesde.Location = new System.Drawing.Point(91, 6);
            this.txtFecDesde.Mask = "99/99/9999";
            this.txtFecDesde.Name = "txtFecDesde";
            this.txtFecDesde.PromptChar = '⠀';
            this.txtFecDesde.Size = new System.Drawing.Size(75, 20);
            this.txtFecDesde.TabIndex = 31;
            this.txtFecDesde.Enter += new System.EventHandler(this.txtFecDesde_Enter);
            // 
            // ReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.ClientSize = new System.Drawing.Size(833, 441);
            this.Controls.Add(this.grbRestFecha);
            this.Controls.Add(this.grbRestLocal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbRangoId);
            this.Controls.Add(this.rbLocal);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.repFac);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Facturas";
            this.grbRestLocal.ResumeLayout(false);
            this.grbRestLocal.PerformLayout();
            this.grbRestFecha.ResumeLayout(false);
            this.grbRestFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbRangoId;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbTodos;
        private Microsoft.Reporting.WinForms.ReportViewer repFac;
        private System.Windows.Forms.ComboBox comboBoxLocal;
        private System.Windows.Forms.Panel grbRestLocal;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel grbRestFecha;
        private System.Windows.Forms.Label lblRestriccion;
        private System.Windows.Forms.MaskedTextBox txtFecHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFecDesde;
    }
}