using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaDatos.Modelo;
using CapaLogica;

namespace Diseño
{
    public partial class frmTipoDeVehiculo : Form
    {
        private TipoDeVehiculoDAO oTipVehiculoDAO = new TipoDeVehiculoDAO();
        private bool NuevoRegistro = false;
        public frmTipoDeVehiculo()
        {
            InitializeComponent();
        }

        private void iconBtnGuardar_Click(object sender, EventArgs e)
        {
            if (NuevoRegistro == true)
            {
                TipoDeVehiculo oTipVehiculo = new TipoDeVehiculo();
                oTipVehiculo.CodigoTipoVehiculo = txtCodigo.Text.Trim();
                oTipVehiculo.DescripcionTipoVehiculo = txtDescripcion.Text.Trim();
                if (oTipVehiculoDAO.Agregar(oTipVehiculo) == false)
                {
                    MessageBox.Show("El nuevo registro no pudo ser guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    MessageBox.Show("El nuevo registro fue guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
            }
            else
            {
                TipoDeVehiculo oTipVehiculo = oTipVehiculoDAO.Buscar(txtCodigo.Text.Trim());
                oTipVehiculo.DescripcionTipoVehiculo = txtDescripcion.Text.Trim();
                if(oTipVehiculoDAO.Modificar(oTipVehiculo) == false)
                {
                    MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    MessageBox.Show("Registro modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //return;
                }
                iconBtnGuardar.Text = "Guardar";
            }
            Limpiar();
            uspTipoVehiculoBindingSource.DataSource = oTipVehiculoDAO.proTipoVehiculo(txtCodigo.Text.Trim());
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            TipoDeVehiculo otipoVehiculo;
            otipoVehiculo = oTipVehiculoDAO.Buscar(txtCodigo.Text.Trim());
            if (otipoVehiculo != null)
            {
                MessageBox.Show("Este registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconBtnGuardar.Text = "Modificar";
                NuevoRegistro = false;
                txtDescripcion.Text = otipoVehiculo.DescripcionTipoVehiculo.Trim();
            }
            else
                NuevoRegistro = true;
        }

        private void frmTipoDeVehiculo_Load(object sender, EventArgs e)
        {
            uspTipoVehiculoBindingSource.DataSource = oTipVehiculoDAO.proTipoVehiculo(txtCodigo.Text.Trim());
        }
    }
}
