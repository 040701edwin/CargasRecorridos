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
    public partial class frmMostrarViajes : Form
    {
        private ViajeDAO oViajeDAO = new ViajeDAO();
        public frmMostrarViajes()
        {
            InitializeComponent();
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            frmViaje frm = new frmViaje();
            frm.ShowDialog();
        }

        private void iconBtnBuscar_Click(object sender, EventArgs e)
        {
            uspBucarViajeBindingSource.DataSource = oViajeDAO.proBuscarViaje(txtBuscar.Text.Trim());
        }
    }
}
