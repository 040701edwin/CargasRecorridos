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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnReporteViaje_Click(object sender, EventArgs e)
        {
            var oFrm = new Reporte.frmVijaeInforme();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void iconBtnReporteVehiculo_Click(object sender, EventArgs e)
        {
            var frm = new Reporte.frmVehiculoInforme();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void iconBtnReporteProveedor_Click(object sender, EventArgs e)
        {
            var frm = new Reporte.frmProveedoresInforme();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void iconBtnReporteChoferes_Click(object sender, EventArgs e)
        {
            var frm = new Reporte.frmChoferInforme();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void iconBtnReporteViajesProveedor_Click(object sender, EventArgs e)
        {
            var frm = new Reporte.frmDetalleProveedorInforme();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}