using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar
using CapaDatos;
using CapaLogica;
using Microsoft.Reporting.WinForms;

namespace Diseño.Reporte
{
    public partial class frmVijaeInforme : Form
    {
        ViajeDAO oViajeDAO = new ViajeDAO();
        public frmVijaeInforme()
        {
            InitializeComponent();
        }

        private void frmVijaeInforme_Load(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Diseño.Informes.rptViajes.rdlc";
            bindingSource1.DataSource = oViajeDAO.proBuscarViaje(""); //parametros vacio para que me muestre toda la lista
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
            this.reportViewer1.RefreshReport();
        }
    }
}
