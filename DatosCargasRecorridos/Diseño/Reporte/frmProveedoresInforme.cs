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
    public partial class frmProveedoresInforme : Form
    {
        ProveedorDAO oProveedorDAO = new ProveedorDAO();
        public frmProveedoresInforme()
        {
            InitializeComponent();
        }

        private void frmProveedoresInforme_Load(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Diseño.Informes.rptProveedores.rdlc";
            bindingSource1.DataSource = oProveedorDAO.proBuscarProveedor(""); //parametros vacio para que me muestre toda la lista
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
