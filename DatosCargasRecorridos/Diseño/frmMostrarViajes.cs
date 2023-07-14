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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Viaje oViaje = new Viaje();
                oViaje = oViajeDAO.Buscar(dataGridView1.CurrentRow.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                if(oViajeDAO.Eliminar(oViaje) == false)
                    MessageBox.Show("Registro No Eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Registro Eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
