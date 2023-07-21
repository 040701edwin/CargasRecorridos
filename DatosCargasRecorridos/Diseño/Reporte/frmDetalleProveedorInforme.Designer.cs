
namespace Diseño.Reporte
{
    partial class frmDetalleProveedorInforme
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSeleccione = new System.Windows.Forms.ComboBox();
            this.iconBtnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 360);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione";
            // 
            // cmbSeleccione
            // 
            this.cmbSeleccione.FormattingEnabled = true;
            this.cmbSeleccione.Location = new System.Drawing.Point(108, 34);
            this.cmbSeleccione.Name = "cmbSeleccione";
            this.cmbSeleccione.Size = new System.Drawing.Size(121, 21);
            this.cmbSeleccione.TabIndex = 2;
            // 
            // iconBtnBuscar
            // 
            this.iconBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnBuscar.Location = new System.Drawing.Point(249, 32);
            this.iconBtnBuscar.Name = "iconBtnBuscar";
            this.iconBtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnBuscar.TabIndex = 3;
            this.iconBtnBuscar.Text = "Buscar";
            this.iconBtnBuscar.UseVisualStyleBackColor = true;
            this.iconBtnBuscar.Click += new System.EventHandler(this.iconBtnBuscar_Click);
            // 
            // frmDetalleProveedorInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconBtnBuscar);
            this.Controls.Add(this.cmbSeleccione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDetalleProveedorInforme";
            this.Text = "frmDetalleProveedorInforme";
            this.Load += new System.EventHandler(this.frmDetalleProveedorInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSeleccione;
        private FontAwesome.Sharp.IconButton iconBtnBuscar;
    }
}