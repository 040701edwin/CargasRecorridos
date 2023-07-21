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
    public partial class frmTipoDeViaje : Form
    {
        private TipoDeViajeDAO oTipoViajeDAO = new TipoDeViajeDAO();
        private bool NuevoRegistro = false;
        public frmTipoDeViaje()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty; txtCodigo.Focus();
            txtDescripcion.Text = string.Empty;
            iconBtnGuardar.Text = "Guardar";
        }
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void iconBtnGuardar_Click(object sender, EventArgs e)
        {
            if(NuevoRegistro == true)
            {
                TipoDeViaje oTipoViaje = new TipoDeViaje();
                oTipoViaje.CodigoTipoViaje = txtCodigo.Text.Trim();
                oTipoViaje.DescripcionTipoViaje = txtDescripcion.Text.Trim();
                if(oTipoViajeDAO.Agregar(oTipoViaje) == false)
                    MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TipoDeViaje oTipoViaje = oTipoViajeDAO.Buscar(txtCodigo.Text.Trim());
                oTipoViaje.DescripcionTipoViaje = txtDescripcion.Text.Trim();
                if(oTipoViajeDAO.Modificar(oTipoViaje) == false)
                    MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconBtnGuardar.Text = "Guardar";
            }
            Limpiar();
            uspTipoViajeBindingSource.DataSource = oTipoViajeDAO.proTipoViaje(txtCodigo.Text.Trim());
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            TipoDeViaje oTipoViaje;
            oTipoViaje = oTipoViajeDAO.Buscar(txtCodigo.Text.Trim());
            if (oTipoViaje != null)
            {
                MessageBox.Show("Este registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconBtnGuardar.Text = "Modificar";
                NuevoRegistro = false;
                txtCodigo.Text = oTipoViaje.CodigoTipoViaje.Trim();
                txtDescripcion.Text = oTipoViaje.DescripcionTipoViaje.Trim();
            }
            else
                NuevoRegistro = true;
        }

        private void frmTipoDeViaje_Load(object sender, EventArgs e)
        {
            uspTipoViajeBindingSource.DataSource = oTipoViajeDAO.proTipoViaje(txtCodigo.Text.Trim());
        }
    }
}
