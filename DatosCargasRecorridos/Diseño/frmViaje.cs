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
    public partial class frmViaje : Form
    {
        private ViajeDAO oViajeDAO = new ViajeDAO();
        private PaisDAO oPaisDAO = new PaisDAO();
        private ChoferDAO oChoferDAO = new ChoferDAO();
        private TipoDeViajeDAO oTipoDeViajeDAO = new TipoDeViajeDAO();
        private ProveedorDAO oProveedorDAO = new ProveedorDAO();
        private bool NuevoRegistro = false;
        public frmViaje()
        {
            InitializeComponent();
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        ErrorProvider error = new ErrorProvider();
        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == string.Empty || cmbChofer.Text == string.Empty || cmbTipo.Text == string.Empty || txtPasajeros.Text == string.Empty || txtTonelaje.Text == string.Empty || cmbPaisDestino.Text == string.Empty || txtCosto.Text == string.Empty || txtPago.Text == string.Empty || cmbProveedor.Text == string.Empty || txtDescripcion.Text == string.Empty || cmbTipo.Text == "Select" || cmbPaisOrigen.Text == "Select" || cmbPaisDestino.Text == "Select")
                error.SetError(iconBtnAgregar, "Datos Incompletos");
            else
            {
                error.Clear();
                if (NuevoRegistro != false)
                {
                    Viaje oViaje = new Viaje();
                    oViaje.CodigoViaje = txtCodigo.Text.Trim();
                    oViaje.ChoferId = (int)cmbChofer.SelectedValue;
                    oViaje.TipoDeViajeId = (int)cmbTipo.SelectedValue;
                    oViaje.CantidadPasajeros = int.Parse(txtPasajeros.Text.Trim());
                    oViaje.Tonelage = decimal.Parse(txtTonelaje.Text.Trim());
                    oViaje.PaisId = (int)cmbPaisOrigen.SelectedValue;
                    oViaje.PaisId1 = (int)cmbPaisDestino.SelectedValue;
                    oViaje.CostoViaje = int.Parse(txtCosto.Text.Trim());
                    oViaje.PagoChoferViaje = int.Parse(txtPago.Text.Trim());
                    oViaje.ProveedorId = (int)cmbProveedor.SelectedValue;
                    oViaje.DescripcionViaje = txtDescripcion.Text.Trim();
                    if (oViajeDAO.Agregar(oViaje) == false)
                    {
                        MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //return;
                    }
                }
                else
                {
                    Viaje oViaje = oViajeDAO.Buscar(txtCodigo.Text.Trim());
                    oViaje.ChoferId = (int)cmbChofer.SelectedValue;
                    oViaje.TipoDeViajeId = (int)cmbTipo.SelectedValue;
                    oViaje.CantidadPasajeros = int.Parse(txtPasajeros.Text.Trim());
                    oViaje.Tonelage = decimal.Parse(txtTonelaje.Text.Trim());
                    oViaje.PaisId = (int)cmbPaisOrigen.SelectedValue;
                    oViaje.PaisId1 = (int)cmbPaisDestino.SelectedValue;
                    oViaje.CostoViaje = int.Parse(txtCosto.Text.Trim());
                    oViaje.PagoChoferViaje = int.Parse(txtPago.Text.Trim());
                    oViaje.ProveedorId = (int)cmbProveedor.SelectedValue;
                    oViaje.DescripcionViaje = txtDescripcion.Text.Trim();
                    if (oViajeDAO.Modificar(oViaje) == false)
                        MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
        }

        private void frmViaje_Load(object sender, EventArgs e)
        {
            //cmbChofer.Items.Add("Seleccionar");
            //cmbChofer.SelectedIndex = 0;
            cmbChofer.DataSource = oChoferDAO.Listar(); //Me lista todos los paises en el combobox
            cmbChofer.DisplayMember = "Nombre1Chofer"; //El campo que queremos mostrar
            cmbChofer.ValueMember = "Id"; //El dato que tomara para ser almacenado

            cmbTipo.DataSource = oTipoDeViajeDAO.Listar();
            cmbTipo.DisplayMember = "CodigoTipoViaje";
            cmbTipo.ValueMember = "Id";
            cmbTipo.SelectedIndex = 2;

            cmbPaisOrigen.DataSource = oPaisDAO.Listar();
            cmbPaisOrigen.DisplayMember = "CodigoPais";
            cmbPaisOrigen.ValueMember = "Id";

            cmbPaisDestino.DataSource = oPaisDAO.Listar();
            cmbPaisDestino.DisplayMember = "CodigoPais";
            cmbPaisDestino.ValueMember = "Id";

            cmbProveedor.DataSource = oProveedorDAO.Listar();
            cmbProveedor.DisplayMember = "CodigoProveedor";
            cmbProveedor.ValueMember = "Id";
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            Viaje oViaje;
            oViaje = oViajeDAO.Buscar(txtCodigo.Text.Trim());
            if(oViaje != null)
            {
                MessageBox.Show("Codigo existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                iconBtnAgregar.Text = "Modificar";
                NuevoRegistro = false;
                cmbChofer.SelectedValue = oViaje.ChoferId;
                cmbTipo.SelectedValue = oViaje.TipoDeViajeId;
                txtPasajeros.Text = oViaje.CantidadPasajeros.ToString();
                txtTonelaje.Text = oViaje.Tonelage.ToString();
                cmbPaisOrigen.SelectedValue = oViaje.PaisId;
                cmbPaisDestino.SelectedValue = oViaje.PaisId1;
                txtCosto.Text = oViaje.CostoViaje.ToString();
                txtPago.Text = oViaje.PagoChoferViaje.ToString();
                cmbProveedor.SelectedValue = oViaje.ProveedorId;
                txtDescripcion.Text = oViaje.DescripcionViaje.Trim();
            }
            else
                NuevoRegistro = true;
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty; txtCodigo.Focus();
            cmbChofer.SelectedIndex = -1;
            cmbTipo.SelectedItem = -1;
            txtPasajeros.Text = string.Empty;
            txtTonelaje.Text = string.Empty;
            cmbPaisOrigen.SelectedValue = -1;
            cmbPaisDestino.SelectedValue = -1;
            txtCosto.Text = string.Empty;
            txtPago.Text = string.Empty;
            cmbProveedor.SelectedIndex = -1;
            txtDescripcion.Text = string.Empty;
        }

        //Validaciones------------------------------------------------------------------------
        private void cmbChofer_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(cmbChofer, "Solo Letras");
            else
                error.Clear();
        }

        private void cmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(cmbTipo, "Solo letras");
            else
                error.Clear();
        }

        private void txtPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloNumeros(e);
            if (!valida)
                error.SetError(txtPasajeros, "Solo Numeros");
            else
                error.Clear();
        }

        private void txtTonelaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloNumeros(e);
            if (!valida)
                error.SetError(txtTonelaje, "Solo Numeros");
            else
                error.Clear();
        }

        private void cmbPaisOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(cmbPaisOrigen, "Solo letras");
            else
                error.Clear();
        }

        private void cmbPaisDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(cmbPaisDestino, "Solo letras");
            else
                error.Clear();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloNumeros(e);
            if (!valida)
                error.SetError(txtCosto, "Solo Numeros");
            else
                error.Clear();
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloNumeros(e);
            if (!valida)
                error.SetError(txtPago, "Solo Numeros");
            else
                error.Clear();
        }

        private void cmbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(txtPago, "Solo letras");
            else
                error.Clear();
        }
        //Fin de la validacion
    }
}
