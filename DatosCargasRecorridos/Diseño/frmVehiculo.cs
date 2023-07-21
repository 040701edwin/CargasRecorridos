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

namespace Diseño
{
    public partial class frmVehiculo : Form
    {
        VehiculoDAO oVehiculoDAO = new VehiculoDAO();
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarVehiculo frm = new frmAgregarVehiculo();
            frm.ShowDialog();
        }

        private void iconBtnBuscar_Click(object sender, EventArgs e)
        {
            uspVehiculoBindingSource.DataSource = oVehiculoDAO.proBuscarVehiculo(txtBuscar.Text.Trim());
        }
    }
}
