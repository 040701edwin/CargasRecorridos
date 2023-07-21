
namespace Diseño.Usuario
{
    partial class frmFunciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.iconBtnGuardar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funciones de Usuario";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(219, 99);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // iconBtnGuardar
            // 
            this.iconBtnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnGuardar.IconColor = System.Drawing.Color.Black;
            this.iconBtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnGuardar.Location = new System.Drawing.Point(118, 216);
            this.iconBtnGuardar.Name = "iconBtnGuardar";
            this.iconBtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnGuardar.TabIndex = 2;
            this.iconBtnGuardar.Text = "Aceptar";
            this.iconBtnGuardar.UseVisualStyleBackColor = true;
            this.iconBtnGuardar.Click += new System.EventHandler(this.iconBtnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(219, 137);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // iconBtnCancelar
            // 
            this.iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnCancelar.IconColor = System.Drawing.Color.Black;
            this.iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCancelar.Location = new System.Drawing.Point(233, 216);
            this.iconBtnCancelar.Name = "iconBtnCancelar";
            this.iconBtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnCancelar.TabIndex = 6;
            this.iconBtnCancelar.Text = "Cancelar";
            this.iconBtnCancelar.UseVisualStyleBackColor = true;
            this.iconBtnCancelar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // frmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 296);
            this.Controls.Add(this.iconBtnCancelar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconBtnGuardar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "frmFunciones";
            this.Text = "frmFunciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private FontAwesome.Sharp.IconButton iconBtnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
    }
}