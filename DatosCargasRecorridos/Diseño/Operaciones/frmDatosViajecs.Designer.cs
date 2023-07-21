
namespace Diseño.Operaciones
{
    partial class frmDatosViajecs
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
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.iconBtnAceptar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbChofer = new System.Windows.Forms.ComboBox();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpLlegada = new System.Windows.Forms.DateTimePicker();
            this.iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(107, 98);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(100, 21);
            this.cmbProveedor.TabIndex = 27;
            // 
            // iconBtnAceptar
            // 
            this.iconBtnAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnAceptar.IconColor = System.Drawing.Color.Black;
            this.iconBtnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAceptar.Location = new System.Drawing.Point(290, 158);
            this.iconBtnAceptar.Name = "iconBtnAceptar";
            this.iconBtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnAceptar.TabIndex = 26;
            this.iconBtnAceptar.Text = "Aceptar";
            this.iconBtnAceptar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Detalles de Viaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Chofer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha de LLegada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Fecha de Salida";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(107, 70);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 33;
            // 
            // cmbChofer
            // 
            this.cmbChofer.FormattingEnabled = true;
            this.cmbChofer.Location = new System.Drawing.Point(107, 131);
            this.cmbChofer.Name = "cmbChofer";
            this.cmbChofer.Size = new System.Drawing.Size(100, 21);
            this.cmbChofer.TabIndex = 34;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(256, 87);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpSalida.TabIndex = 35;
            // 
            // dtpLlegada
            // 
            this.dtpLlegada.Location = new System.Drawing.Point(256, 132);
            this.dtpLlegada.Name = "dtpLlegada";
            this.dtpLlegada.Size = new System.Drawing.Size(200, 20);
            this.dtpLlegada.TabIndex = 36;
            // 
            // iconBtnCancelar
            // 
            this.iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnCancelar.IconColor = System.Drawing.Color.Black;
            this.iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCancelar.Location = new System.Drawing.Point(381, 158);
            this.iconBtnCancelar.Name = "iconBtnCancelar";
            this.iconBtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnCancelar.TabIndex = 37;
            this.iconBtnCancelar.Text = "Cancelar";
            this.iconBtnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmDatosViajecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 213);
            this.Controls.Add(this.iconBtnCancelar);
            this.Controls.Add(this.dtpLlegada);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.cmbChofer);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.iconBtnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDatosViajecs";
            this.Text = "frmDatosViajecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedor;
        private FontAwesome.Sharp.IconButton iconBtnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbChofer;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpLlegada;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
    }
}