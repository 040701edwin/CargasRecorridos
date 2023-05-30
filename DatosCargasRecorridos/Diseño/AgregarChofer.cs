using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Referencias
using CapaLogica;
using CapaDatos;
using CapaDatos.Modelo;

namespace Diseño
{
    public partial class AgregarChofer : Form
    {
        private ChoferDAO ochofDAO = new ChoferDAO();
        private bool NuevoRegistro = true;
        public AgregarChofer()
        {
            InitializeComponent();
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = string.Empty; txtCedula.Focus();
            txtNombre1.Text = string.Empty;
            txtNombre2.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtINSS.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            if(NuevoRegistro == true)
            {
                Chofer ochof = new Chofer();
                ochof.CedulaChofer = txtCedula.Text.Trim();
                ochof.Nombre1Chofer = txtNombre1.Text.Trim();
                ochof.Nombre2Chofer = txtNombre2.Text.Trim();
                ochof.Apellido1Chofer = txtApellido1.Text.Trim();
                ochof.Apellido2Chofer = txtApellido2.Text.Trim();
                ochof.CelularChofer = txtCelular.Text.Trim();
                ochof.INSSChofer = txtINSS.Text.Trim();
                ochof.DireccionChofer = txtDireccion.Text.Trim();
                //ochof.Pais = 2;
                if (ochofDAO.Agregar(ochof) == false)
                {
                    MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private void AgregarChofer_Load(object sender, EventArgs e)
        {
            //Cargar ComboBox
            comboBox1.Items.Add("Selecccione el pais");
            comboBox1.Items.Add("Belice");
            comboBox1.Items.Add("Costa Rica");
            comboBox1.Items.Add("El Salvador");
            comboBox1.Items.Add("Guatemala");
            comboBox1.Items.Add("Honduras");
            comboBox1.Items.Add("Nicaragua");
            comboBox1.Items.Add("Panama");
            comboBox1.SelectedIndex = 0;
        }
    }
}
