using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDatos;
using CapaDatos.Modelo;

namespace Diseño
{
    public partial class frmPais : Form
    {
        private PaisDAO oPaisDAO = new PaisDAO();
        private bool NuevoRegistro = false;
        public frmPais()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty; txtCodigo.Focus();
            txtPais.Text = string.Empty;
        }
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            iconBtnAgregar.Text = "Guardar";
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            if(NuevoRegistro == false)
            {
                Pais oPais = new Pais();
                oPais.CodigoPais = txtCodigo.Text.Trim();
                oPais.Descripcion = txtPais.Text.Trim();
                if(oPaisDAO.Agregar(oPais) == false)
                    MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Pais oPais = oPaisDAO.Buscar(txtCodigo.Text.Trim());
                oPais.CodigoPais = txtCodigo.Text.Trim();
                oPais.Descripcion = txtPais.Text.Trim();
                if(oPaisDAO.Modificar(oPais) == false)
                    MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconBtnAgregar.Text = "Guardar";
            }
            Limpiar();
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            Pais oPais;
            oPais = oPaisDAO.Buscar(txtCodigo.Text.Trim());
            if (oPais != null)
            {
                MessageBox.Show("Este pais ya existe en la DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconBtnAgregar.Text = "Modificar";
                NuevoRegistro = false;
                txtCodigo.Text = oPais.CodigoPais.Trim();
                txtPais.Text = oPais.Descripcion.Trim();
            }
            else
                NuevoRegistro = true;
        }
    }
}
