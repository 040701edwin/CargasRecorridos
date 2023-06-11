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
        private TipoDeVehiculo oTipoDeVehicullo = new TipoDeVehiculo();
        private bool NuevoRegistro = false;
        public frmTipoDeVehiculo()
        {
            InitializeComponent();
        }

        private void iconBtnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "vehca" && comboBox1.Text != "vehre")
            {
                MessageBox.Show("Seleccione Tipo correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NuevoRegistro == true)
            {
                TipoDeVehiculo oTipVehiculo = new TipoDeVehiculo();
                oTipVehiculo.CodigoTipoVehiculo = comboBox1.Text.Trim();    //combobox1 tipos de vehiculo
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
                TipoDeVehiculo oTipVehiculo = oTipVehiculoDAO.Buscar(comboBox1.Text.Trim());
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
            }
            comboBox1.SelectedIndex = 0;
            txtDescripcion.Text = string.Empty;
        }

        private void frmTipoDeVehiculo_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Seleccione");
            comboBox1.SelectedIndex = 0;
            comboBox1.DataSource = oTipVehiculoDAO.Listar(); //Me lista todos los paises en el combobox
            comboBox1.DisplayMember = "CodigoTipoVehiculo"; //El campo que queremos mostrar
            //comboBox1.ValueMember = "Id"; //El dato que tomara para ser almacenado
            //comboBox1.Items.Add("Seleccione");
            //comboBox1.Items.Add("vehca");
            //comboBox1.Items.Add("vehre");
            //comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            TipoDeVehiculo otipoVehiculo;
            //if (comboBox1.Text != "vehca" && comboBox1.Text != "vehre")
            //{
            //    MessageBox.Show("Seleccione Tipo correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            otipoVehiculo = oTipVehiculoDAO.Buscar(comboBox1.Text.Trim());
            if(otipoVehiculo != null)
            {
                NuevoRegistro = false;
                txtDescripcion.Text = otipoVehiculo.DescripcionTipoVehiculo.Trim();
            }
            else
            {
                NuevoRegistro = true;
                txtDescripcion.Text = "";
            }
        }

        
    }
}
