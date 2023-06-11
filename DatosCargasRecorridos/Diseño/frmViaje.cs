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

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            if(NuevoRegistro != false)
            {
                Viaje oViaje = new Viaje();
                oViaje.CodigoViaje = txtCodigo.Text.Trim();
                oViaje.ChoferId = (int)cmbChofer.SelectedValue;
                oViaje.TipoDeViajeId = (int)cmbTipo.SelectedValue;
                oViaje.Tonelage = decimal.Parse(txtTonelaje.Text.Trim());
                oViaje.PaisId = (int)cmbPaisOrigen.SelectedValue;
                oViaje.PaisId = (int)cmbPaisDestino.SelectedValue;
                oViaje.CostoViaje = int.Parse(txtCosto.Text.Trim());
                oViaje.PagoChoferViaje = int.Parse(txtPago.Text.Trim());
                oViaje.ProveedorId = (int)cmbProveedor.SelectedValue;
                oViaje.DescripcionViaje = txtDescripcion.Text.Trim();
                if(oViajeDAO.Agregar(oViaje) == false)
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
                NuevoRegistro = false;
                txtPasajeros.Text = oViaje.CantidadPasajeros.ToString();
                txtDescripcion.Text = oViaje.DescripcionViaje.Trim();
                
                
            }
            else
            {
                NuevoRegistro = true;

            }

        }
    }
}
