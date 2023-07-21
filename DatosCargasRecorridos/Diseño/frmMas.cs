using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    public partial class frmMas : Form
    {
        public frmMas()
        {
            InitializeComponent();
        }

        private void iconBtnMarcasVehiculos_Click(object sender, EventArgs e)
        {
            frmMarcaDelVehiculo frm = new frmMarcaDelVehiculo();
            frm.ShowDialog();
        }

        private void iconBtnModelosVehiculo_Click(object sender, EventArgs e)
        {
            frmModelo frm = new frmModelo();
            frm.ShowDialog();
        }

        private void iconBtnPais_Click(object sender, EventArgs e)
        {
            frmPais frm = new frmPais();
            frm.ShowDialog();
        }

        private void iconBtnTipoVehiculo_Click(object sender, EventArgs e)
        {
            frmTipoDeVehiculo frm = new frmTipoDeVehiculo();
            frm.ShowDialog();
        }

        private void iconBtnTipoViaje_Click(object sender, EventArgs e)
        {
            frmTipoDeViaje frm = new frmTipoDeViaje();
            frm.ShowDialog();
        }
    }
}
