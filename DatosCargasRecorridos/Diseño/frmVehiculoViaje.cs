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
    public partial class frmVehiculoViaje : Form
    {
        private VehiculoViajeDAO oVehiculoViajeDAO = new VehiculoViajeDAO();
        private ViajeDAO oViajeDAO = new ViajeDAO();
        private VehiculoDAO oVehiculoDAO = new VehiculoDAO();
        private bool NuevoRegistro = false;
        public frmVehiculoViaje()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            cmbViaje.Text = string.Empty;
            cmbVehiculo.Text = string.Empty;
            txtSalida.Text = string.Empty;
            txtLlegada.Text = string.Empty;
            txtRetorno.Text = string.Empty;
            iconBtnAgregar.Text = "Guardar";
        }
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbViaje.Text == string.Empty && cmbVehiculo.Text == string.Empty)
            {
                MessageBox.Show("Campos Viaje y Vehiculo Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            VehiculoViaje oVehiculoViaje = new VehiculoViaje();
            oVehiculoViaje.ViajeId = (int)cmbViaje.SelectedValue;
            oVehiculoViaje.VehiculoId = (int)cmbVehiculo.SelectedValue;
            oVehiculoViaje.FechaHoraSalida = DateTime.Parse(txtSalida.Text.Trim());
            oVehiculoViaje.FechaHoraLlegada = DateTime.Parse(txtLlegada.Text.Trim());
            oVehiculoViaje.FechaHoraRetorno = DateTime.Parse(txtRetorno.Text.Trim());
            if(oVehiculoViajeDAO.Agregar(oVehiculoViaje) == false)
                MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        private void iconBtnModificar_Click(object sender, EventArgs e)
        {
            if (cmbViaje.Text == string.Empty && cmbVehiculo.Text == string.Empty)
            {
                MessageBox.Show("Campos Viaje y Vehiculo Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            VehiculoViaje oVehiculoViaje = new VehiculoViaje();
            oVehiculoViaje.ViajeId = (int)cmbViaje.SelectedValue;
            oVehiculoViaje.VehiculoId = (int)cmbVehiculo.SelectedValue;
            oVehiculoViaje.FechaHoraSalida = DateTime.Parse(txtSalida.Text.Trim());
            oVehiculoViaje.FechaHoraLlegada = DateTime.Parse(txtLlegada.Text.Trim());
            oVehiculoViaje.FechaHoraRetorno = DateTime.Parse(txtRetorno.Text.Trim());
            if (oVehiculoViajeDAO.Modificar(oVehiculoViaje) == false)
                MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        private void frmVehiculoViaje_Load(object sender, EventArgs e)
        {
            cmbViaje.DataSource = oViajeDAO.Listar();
            cmbViaje.DisplayMember = "CodigoViaje";
            cmbViaje.ValueMember = "Id";
            cmbViaje.SelectedIndex = -1;

            cmbVehiculo.DataSource = oVehiculoDAO.Listar();
            cmbVehiculo.DisplayMember = "PlacaVehiculo";
            cmbVehiculo.ValueMember = "Id";
            cmbVehiculo.SelectedIndex = -1;
        }
    }
}
