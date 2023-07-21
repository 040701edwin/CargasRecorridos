using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.GestionUsuario;

namespace Diseño.Usuario
{
    public partial class frmUsuarios : Form
    {
        public bool AccesoValido = false;
        private UsuarioDAO opeUsuario = new UsuarioDAO();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void iconBtnGuardar_Click(object sender, EventArgs e)
        {
            if(opeUsuario.Agregar(txtUsuario.Text, txtClave.Text) == false)
            {
                MessageBox.Show("Operación Invalida");
            }Limpiar();
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpiar()
        {
            txtUsuario.Text = string.Empty; txtUsuario.Focus();
            txtClave.Text = string.Empty;
        }
    }
}
