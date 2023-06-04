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
    public partial class frmAgregarChofer : Form
    {
        private ChoferDAO ochofDAO = new ChoferDAO();
        private PaisDAO Opais = new PaisDAO();
        private bool NuevoRegistro = true;
        public frmAgregarChofer()
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
                ochof.PaisId = (int)comboBox1.SelectedValue;
                if (ochofDAO.Agregar(ochof) == false)
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
        }
        //Listar los datos de pais en el combobox1
        private void frmAgregarChofer_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Seleccione");
            comboBox1.SelectedIndex = 0;
            comboBox1.DataSource = Opais.Listar(); //Me lista todos los paises en el combobox
            comboBox1.DisplayMember = "CodigoPais"; //El campo que queremos mostrar
            comboBox1.ValueMember = "Id"; //El dato que tomara para ser almacenado
            //comboBox1.SelectedIndex = -1; //Campo vacio
        }
        //private void frmAgregarChofer_Load(object sender, EventArgs e)
        //{
        //    //Cargar ComboBox
        //    comboBox1.Items.Add("Selecccione el pais");
        //    comboBox1.Items.Add("Belice");
        //    comboBox1.Items.Add("Costa Rica");
        //    comboBox1.Items.Add("El Salvador");
        //    comboBox1.Items.Add("Guatemala");
        //    comboBox1.Items.Add("Honduras");
        //    comboBox1.Items.Add("Nicaragua");
        //    comboBox1.Items.Add("Panama");
        //    comboBox1.SelectedIndex = 0;
        //}
    }
}
