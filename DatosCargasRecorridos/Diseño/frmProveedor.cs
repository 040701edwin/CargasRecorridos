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
using CapaLogica;
using CapaDatos.Modelo;

namespace Diseño
{
    public partial class frmProveedor : Form
    {
        private ProveedorDAO oProveedorDAO = new ProveedorDAO();
        private bool NuevoRegistro = false;
        public frmProveedor()
        {
            InitializeComponent();
        }

        ErrorProvider error = new ErrorProvider();
        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty || txtNomEmpresa.Text == string.Empty || txtCelular.Text == string.Empty || txtDireccion.Text == string.Empty || txtNombre1.Text == string.Empty || txtApellido1.Text == string.Empty || txtCargo.Text == string.Empty || txtCargo.Text == string.Empty)
                error.SetError(iconBtnAgregar, "Datos Incompletos");
            else
            {
                error.Clear();
                if (NuevoRegistro == true)
                {
                    Proveedor oProveedor = new Proveedor();
                    oProveedor.CodigoProveedor = txtCodigo.Text.Trim();
                    oProveedor.NombreEmpresaProveedor = txtNomEmpresa.Text.Trim();
                    oProveedor.CelularProveedor = txtCelular.Text.Trim();
                    oProveedor.DireccionEmpresa = txtDireccion.Text.Trim();
                    oProveedor.Nombre1Encargado = txtNombre1.Text.Trim();
                    oProveedor.Nombre2Encargado = txtNombre2.Text.Trim();
                    oProveedor.Apellido1Encargado = txtApellido1.Text.Trim();
                    oProveedor.Apellido2Encargado = txtApellido2.Text.Trim();
                    oProveedor.Cargo = txtCargo.Text.Trim();
                    oProveedor.Comentario = txtComentario.Text.Trim();
                    if (oProveedorDAO.Agregar(oProveedor) == false)
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
                    Proveedor oProveedor = oProveedorDAO.Buscar(txtCodigo.Text.Trim());
                    oProveedor.CodigoProveedor = txtCodigo.Text.Trim();
                    oProveedor.NombreEmpresaProveedor = txtNomEmpresa.Text.Trim();
                    oProveedor.CelularProveedor = txtCelular.Text.Trim();
                    oProveedor.DireccionEmpresa = txtDireccion.Text.Trim();
                    oProveedor.Nombre1Encargado = txtNombre1.Text.Trim();
                    oProveedor.Nombre2Encargado = txtNombre2.Text.Trim();
                    oProveedor.Apellido1Encargado = txtApellido1.Text.Trim();
                    oProveedor.Apellido2Encargado = txtApellido2.Text.Trim();
                    oProveedor.Cargo = txtCargo.Text.Trim();
                    oProveedor.Comentario = txtComentario.Text.Trim();
                    if (oProveedorDAO.Modificar(oProveedor) == false)
                    {
                        MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    else
                    {
                        MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //return;
                    }
                    iconBtnAgregar.Text = "Guardar";
                }
                Limpiar();
            }
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            iconBtnAgregar.Text = "Guardar";
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty; txtCodigo.Focus();
            txtNombre1.Text = string.Empty;
            txtNombre2.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNomEmpresa.Text = string.Empty;
            txtComentario.Text = string.Empty;
        }
        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            Proveedor oProveedor;
            oProveedor = oProveedorDAO.Buscar(txtCodigo.Text.Trim());
            if(oProveedor != null)
            {
                NuevoRegistro = false;
                MessageBox.Show("Registro existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconBtnAgregar.Text = "Modificar";
                txtCelular.Text = oProveedor.CelularProveedor.Trim();
                txtNomEmpresa.Text = oProveedor.NombreEmpresaProveedor.Trim();
                txtDireccion.Text = oProveedor.DireccionEmpresa.Trim();
                txtNombre1.Text = oProveedor.Nombre1Encargado.Trim();
                txtNombre2.Text = oProveedor.Nombre2Encargado.Trim();
                txtApellido1.Text = oProveedor.Apellido1Encargado.Trim();
                txtApellido2.Text = oProveedor.Apellido2Encargado.Trim();
                txtCargo.Text = oProveedor.Cargo.Trim();
                txtComentario.Text = oProveedor.Comentario.Trim();
            }
            else
                NuevoRegistro = true;
        }

        private void iconBtnBuscar_Click(object sender, EventArgs e)
        {
            uspProveedorBindingSource.DataSource = oProveedorDAO.proBuscarProveedor(txtBuscar.Text.Trim());
        }

        //Validaciones---------------------------------------------------------------------------
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(txtCodigo, "Solo letras");
            else
                error.Clear();
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloNumeros(e);
            if (!valida)
                error.SetError(txtCelular, "Solo Numeros");
            else
                error.Clear();
        }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(txtNombre1, "Solo Letras");
            else
                error.Clear();
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(txtNombre2, "Solo Letras");
            else
                error.Clear();
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(txtApellido1, "Solo Letras");
            else
                error.Clear();
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(txtApellido2, "Solo Letras");
            else
                error.Clear();
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(txtCargo, "Solo Letras");
            else
                error.Clear();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validaciones.Validar.SoloLetras(e);
            if (!valida)
                error.SetError(txtBuscar, "Solo Letras");
            else
                error.Clear();
        }
        //Fin Validacion-----------------------------------------------------------------------------------
    }
}
