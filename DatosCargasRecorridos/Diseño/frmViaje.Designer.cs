
namespace Diseño
{
    partial class frmViaje
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
            this.cmbPaisOrigen = new System.Windows.Forms.ComboBox();
            this.iconBtnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            this.iconBtnAgregar = new FontAwesome.Sharp.IconButton();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtTonelaje = new System.Windows.Forms.TextBox();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPaisDestino = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbChofer = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbPaisOrigen
            // 
            this.cmbPaisOrigen.FormattingEnabled = true;
            this.cmbPaisOrigen.Location = new System.Drawing.Point(124, 209);
            this.cmbPaisOrigen.Name = "cmbPaisOrigen";
            this.cmbPaisOrigen.Size = new System.Drawing.Size(100, 21);
            this.cmbPaisOrigen.TabIndex = 44;
            // 
            // iconBtnCerrar
            // 
            this.iconBtnCerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnCerrar.IconColor = System.Drawing.Color.Black;
            this.iconBtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCerrar.Location = new System.Drawing.Point(205, 392);
            this.iconBtnCerrar.Name = "iconBtnCerrar";
            this.iconBtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnCerrar.TabIndex = 43;
            this.iconBtnCerrar.Text = "Cerrar";
            this.iconBtnCerrar.UseVisualStyleBackColor = true;
            this.iconBtnCerrar.Click += new System.EventHandler(this.iconBtnCerrar_Click);
            // 
            // iconBtnCancelar
            // 
            this.iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnCancelar.IconColor = System.Drawing.Color.Black;
            this.iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCancelar.Location = new System.Drawing.Point(124, 392);
            this.iconBtnCancelar.Name = "iconBtnCancelar";
            this.iconBtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnCancelar.TabIndex = 42;
            this.iconBtnCancelar.Text = "Cancelar";
            this.iconBtnCancelar.UseVisualStyleBackColor = true;
            // 
            // iconBtnAgregar
            // 
            this.iconBtnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnAgregar.IconColor = System.Drawing.Color.Black;
            this.iconBtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAgregar.Location = new System.Drawing.Point(43, 392);
            this.iconBtnAgregar.Name = "iconBtnAgregar";
            this.iconBtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnAgregar.TabIndex = 41;
            this.iconBtnAgregar.Text = "Guardar";
            this.iconBtnAgregar.UseVisualStyleBackColor = true;
            this.iconBtnAgregar.Click += new System.EventHandler(this.iconBtnAgregar_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(124, 261);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 40;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(124, 342);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 39;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(124, 287);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 38;
            // 
            // txtTonelaje
            // 
            this.txtTonelaje.Location = new System.Drawing.Point(124, 183);
            this.txtTonelaje.Name = "txtTonelaje";
            this.txtTonelaje.Size = new System.Drawing.Size(100, 20);
            this.txtTonelaje.TabIndex = 37;
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Location = new System.Drawing.Point(124, 157);
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(100, 20);
            this.txtPasajeros.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Costo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Pais Destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Pais Origen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tonelage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Pasajeros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Chofer";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(124, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 25;
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Agregar Viaje";
            // 
            // cmbPaisDestino
            // 
            this.cmbPaisDestino.FormattingEnabled = true;
            this.cmbPaisDestino.Location = new System.Drawing.Point(124, 235);
            this.cmbPaisDestino.Name = "cmbPaisDestino";
            this.cmbPaisDestino.Size = new System.Drawing.Size(100, 21);
            this.cmbPaisDestino.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Descripcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Proveedor";
            // 
            // cmbChofer
            // 
            this.cmbChofer.FormattingEnabled = true;
            this.cmbChofer.Location = new System.Drawing.Point(124, 105);
            this.cmbChofer.Name = "cmbChofer";
            this.cmbChofer.Size = new System.Drawing.Size(100, 21);
            this.cmbChofer.TabIndex = 49;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(124, 131);
            this.cmbTipo.MaxLength = 5;
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(100, 21);
            this.cmbTipo.TabIndex = 50;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(124, 313);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(100, 21);
            this.cmbProveedor.TabIndex = 51;
            // 
            // frmViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 462);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbChofer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbPaisDestino);
            this.Controls.Add(this.cmbPaisOrigen);
            this.Controls.Add(this.iconBtnCerrar);
            this.Controls.Add(this.iconBtnCancelar);
            this.Controls.Add(this.iconBtnAgregar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtTonelaje);
            this.Controls.Add(this.txtPasajeros);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmViaje";
            this.Text = "Viaje";
            this.Load += new System.EventHandler(this.frmViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaisOrigen;
        private FontAwesome.Sharp.IconButton iconBtnCerrar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconBtnAgregar;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtTonelaje;
        private System.Windows.Forms.TextBox txtPasajeros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPaisDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbChofer;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbProveedor;
    }
}