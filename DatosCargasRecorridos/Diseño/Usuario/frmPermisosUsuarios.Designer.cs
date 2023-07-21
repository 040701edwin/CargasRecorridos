
namespace Diseño.Usuario
{
    partial class frmPermisosUsuarios
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
            this.iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconBtnGuardar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // iconBtnCancelar
            // 
            this.iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnCancelar.IconColor = System.Drawing.Color.Black;
            this.iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCancelar.Location = new System.Drawing.Point(279, 250);
            this.iconBtnCancelar.Name = "iconBtnCancelar";
            this.iconBtnCancelar.Size = new System.Drawing.Size(89, 33);
            this.iconBtnCancelar.TabIndex = 13;
            this.iconBtnCancelar.Text = "Cancelar";
            this.iconBtnCancelar.UseVisualStyleBackColor = true;
            this.iconBtnCancelar.Click += new System.EventHandler(this.iconBtnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Permiso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario";
            // 
            // iconBtnGuardar
            // 
            this.iconBtnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnGuardar.IconColor = System.Drawing.Color.Black;
            this.iconBtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnGuardar.Location = new System.Drawing.Point(164, 250);
            this.iconBtnGuardar.Name = "iconBtnGuardar";
            this.iconBtnGuardar.Size = new System.Drawing.Size(89, 33);
            this.iconBtnGuardar.TabIndex = 9;
            this.iconBtnGuardar.Text = "Aceptar";
            this.iconBtnGuardar.UseVisualStyleBackColor = true;
            this.iconBtnGuardar.Click += new System.EventHandler(this.iconBtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Permisos De Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vencimiento";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(168, 184);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpVencimiento.TabIndex = 15;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(168, 113);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(200, 21);
            this.cmbUsuario.TabIndex = 16;
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Location = new System.Drawing.Point(168, 148);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(200, 21);
            this.cmbPermisos.TabIndex = 17;
            // 
            // frmPermisosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 363);
            this.Controls.Add(this.cmbPermisos);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconBtnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconBtnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "frmPermisosUsuarios";
            this.Text = "frmPermisosUsuarios";
            this.Load += new System.EventHandler(this.frmPermisosUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconBtnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbPermisos;
    }
}