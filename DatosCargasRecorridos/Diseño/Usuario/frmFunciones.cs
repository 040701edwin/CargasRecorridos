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
using CapaDatos.GestionUsuario;

namespace Diseño.Usuario
{
    public partial class frmFunciones : Form
    {
        private FuncionesDAO ope = new FuncionesDAO();
        public frmFunciones()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnGuardar_Click(object sender, EventArgs e)
        {
            if(ope.Buscar(txtCodigo.Text) == null)
            {
                if(ope.Agregar(txtCodigo.Text, txtDescripcion.Text) == false)
                {
                    MessageBox.Show("Operación Invalida");
                }
            }
            else
            {
                if(ope.Modificar(txtCodigo.Text, txtDescripcion.Text) == false)
                {
                    MessageBox.Show("Operación Invalida");
                }
            }Limpiar();
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty; txtCodigo.Focus();
            txtDescripcion.Text = string.Empty;
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            FuncionDeAcceso oFuncion = ope.Buscar(txtCodigo.Text);
            if (oFuncion == null)
                txtDescripcion.Text = "";
            else
                txtDescripcion.Text = oFuncion.Descripcion.Trim();
        }
    }
}
