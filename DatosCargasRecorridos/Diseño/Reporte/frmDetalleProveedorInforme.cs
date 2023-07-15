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
using Microsoft.Reporting.WinForms;

namespace Diseño.Reporte
{
    public partial class frmDetalleProveedorInforme : Form
    {
        ViajeDAO oViajeDAO = new ViajeDAO();
        ProveedorDAO oProveedorDAO = new ProveedorDAO();
        public frmDetalleProveedorInforme()
        {
            InitializeComponent();
        }

        private void iconBtnBuscar_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Diseño.Informes.rptDetalleProveedor.rdlc";
            bindingSource1.DataSource = oViajeDAO.proDetalleProveedor(cmbSeleccione.SelectedValue.ToString()); //parametros vacio para que me muestre toda la lista
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
            this.reportViewer1.RefreshReport();
        }

        private void frmDetalleProveedorInforme_Load(object sender, EventArgs e)
        {
            cmbSeleccione.DataSource = oProveedorDAO.Listar();
            cmbSeleccione.DisplayMember = "NombreEmpresaProveedor";
            cmbSeleccione.ValueMember = "CodigoProveedor";
            cmbSeleccione.SelectedIndex = -1;
        }
    }
}
