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
    public partial class frmAgregarVehiculo : Form
    {
        private VehiculoDAO oVehiculoDAO = new VehiculoDAO();
        private MarcaDeVehiculoDAO oMarcaDAO = new MarcaDeVehiculoDAO();
        private ModeloDAO oModeloDAO = new ModeloDAO();
        private TipoDeVehiculoDAO oTipoDAO = new TipoDeVehiculoDAO();
        private bool NuevoRegistro = false;
        public frmAgregarVehiculo()
        {
            InitializeComponent();
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpiar()
        {
            txtPlaca.Text = string.Empty; txtPlaca.Focus();
            cmbModelo.Text = string.Empty;
            cmbMarca.Text = string.Empty;
            cmbTipo.Text = string.Empty;
            txtPasajeros.Text = string.Empty;
            txtTonelaje.Text = string.Empty;
            txtTonelaje.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbMarca.SelectedIndex = 1;
            cmbModelo.SelectedIndex = 1;
            cmbTipo.SelectedIndex = 2;
            cmbEstado.SelectedIndex = 0;
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            if(NuevoRegistro == true)
            {
                Vehiculo oVehiculo = new Vehiculo();
                oVehiculo.PlacaVehiculo = txtPlaca.Text.Trim();
                oVehiculo.MarcaVehiculoId = (int)cmbMarca.SelectedValue;
                oVehiculo.ModeloDelVehiculoId = (int)cmbModelo.SelectedValue;
                oVehiculo.TipoDeVehiculoId = (int)cmbTipo.SelectedValue;
                oVehiculo.CantidadPasajeros = int.Parse(txtPasajeros.Text.Trim());
                oVehiculo.Tonelage = decimal.Parse(txtTonelaje.Text.Trim());
                oVehiculo.EstadoVehiculo = cmbEstado.Text.Trim();
                oVehiculo.DescripcionVehiculo = txtDescripcion.Text.Trim();
                if(oVehiculoDAO.Agregar(oVehiculo) == false)
                    MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Vehiculo oVehiculo = oVehiculoDAO.Buscar(txtPlaca.Text.Trim());
                oVehiculo.MarcaVehiculoId = (int)cmbMarca.SelectedValue;
                oVehiculo.ModeloDelVehiculoId = (int)cmbModelo.SelectedValue;
                oVehiculo.TipoDeVehiculoId = (int)cmbTipo.SelectedValue;
                oVehiculo.CantidadPasajeros = int.Parse(txtPasajeros.Text.Trim());
                oVehiculo.Tonelage = decimal.Parse(txtTonelaje.Text.Trim());
                oVehiculo.EstadoVehiculo = cmbEstado.Text.Trim();
                oVehiculo.DescripcionVehiculo = txtDescripcion.Text.Trim();
                if(oVehiculoDAO.Modificar(oVehiculo) == false)
                    MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
        }

        private void frmAgregarVehiculo_Load(object sender, EventArgs e)
        {
            cmbMarca.DataSource = oMarcaDAO.Listar();
            cmbMarca.DisplayMember = "Marca";
            cmbMarca.ValueMember = "Id";
            cmbMarca.SelectedIndex = 1;

            cmbModelo.DataSource = oModeloDAO.Listar();
            cmbModelo.DisplayMember = "Modelo";
            cmbModelo.ValueMember = "Id";
            cmbModelo.SelectedIndex = 1;

            cmbTipo.DataSource = oTipoDAO.Listar();
            cmbTipo.DisplayMember = "CodigoTipoVehiculo";
            cmbTipo.ValueMember = "Id";
            cmbTipo.SelectedIndex = 2;

            cmbEstado.Items.Add("Select");
            cmbEstado.Items.Add("Mal Estado");
            cmbEstado.Items.Add("BuenEstado");
            cmbEstado.SelectedIndex = 0;
        }

        private void txtPlaca_Validating(object sender, CancelEventArgs e)
        {
            Vehiculo oVehiculo;
            oVehiculo = oVehiculoDAO.Buscar(txtPlaca.Text.Trim());
            if (oVehiculo != null)
            {
                MessageBox.Show("Registro encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconBtnAgregar.Text = "Modificar";
                NuevoRegistro = false;
                cmbMarca.SelectedValue = oVehiculo.MarcaVehiculoId;
                cmbModelo.SelectedValue = oVehiculo.ModeloDelVehiculoId;
                cmbTipo.SelectedValue = oVehiculo.TipoDeVehiculoId;
                txtPasajeros.Text = oVehiculo.CantidadPasajeros.ToString();
                txtTonelaje.Text = oVehiculo.Tonelage.ToString();
                cmbEstado.Text = oVehiculo.EstadoVehiculo.Trim();
                txtDescripcion.Text = oVehiculo.DescripcionVehiculo.Trim();
            }
            else
            {
                NuevoRegistro = true;
                iconBtnAgregar.Text = "Guardar";
            }
        }
    }
}
