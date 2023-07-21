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
    public partial class frmChoferInforme : Form
    {
        ChoferDAO oChoferDAO = new ChoferDAO();
        public frmChoferInforme()
        {
            InitializeComponent();
        }

        private void frmChoferInforme_Load(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Diseño.Informes.rptChoferes.rdlc";
            bindingSource1.DataSource = oChoferDAO.proChofer(""); //parametros vacio para que me muestre toda la lista
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
