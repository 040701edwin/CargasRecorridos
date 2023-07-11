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
    public partial class Choferes : Form
    {
        ChoferDAO oChoferDAO = new ChoferDAO();
        public Choferes()
        {
            InitializeComponent();
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarChofer aChof = new frmAgregarChofer();
            aChof.ShowDialog();
        }

        private void iconBtnBuscar_Click(object sender, EventArgs e)
        {
            uspMostrarChoferBindingSource.DataSource = oChoferDAO.proChofer(txtBuscar.Text.Trim());
        }
    }
}
