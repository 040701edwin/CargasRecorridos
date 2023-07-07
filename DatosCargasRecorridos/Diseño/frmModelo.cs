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
    public partial class frmModelo : Form
    {
        private ModeloDAO oModeloDAO = new ModeloDAO();
        private MarcaDeVehiculoDAO oMarcaDAO = new MarcaDeVehiculoDAO();
        private bool NuevoRegistro = false; 
        public frmModelo()
        {
            InitializeComponent();
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            if(NuevoRegistro == true)
            {
                ModeloDelVehiculo oModelo = new ModeloDelVehiculo();
                oModelo.Modelo = txtModelo.Text.Trim();
                oModelo.MarcaVehiculoId = (int)cmbMarca.SelectedValue;
                if(oModeloDAO.Agregar(oModelo) == false)
                    MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ModeloDelVehiculo oModelo = oModeloDAO.Buscar(txtModelo.Text.Trim());
                oModelo.Modelo = txtModelo.Text.Trim();
                oModelo.MarcaVehiculoId = (int)cmbMarca.SelectedValue;
                if(oModeloDAO.Modificar(oModelo) == false)
                    MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconBtnAgregar.Text = "Guardar";
            }
            Limpiar();
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            iconBtnAgregar.Text = "Guardar";
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpiar()
        {
            txtModelo.Text = string.Empty; txtModelo.Focus();
            cmbMarca.Text = string.Empty;
        }

        private void frmModelo_Load(object sender, EventArgs e)
        {
            cmbMarca.DataSource = oMarcaDAO.Listar();
            cmbMarca.DisplayMember = "Marca";
            cmbMarca.ValueMember = "Id";
            cmbMarca.SelectedIndex = 1;
        }

        private void txtModelo_Validating(object sender, CancelEventArgs e)
        {
            ModeloDelVehiculo oModelo;
            oModelo = oModeloDAO.Buscar(txtModelo.Text.Trim());
            if (oModelo != null)
            {
                MessageBox.Show("Este Modelo ya existe en la DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconBtnAgregar.Text = "Modificar";
                NuevoRegistro = false;
                txtModelo.Text = oModelo.Modelo.Trim();
                cmbMarca.SelectedValue = oModelo.MarcaVehiculoId;
            }
            else
                NuevoRegistro = true;
        }
    }
}
