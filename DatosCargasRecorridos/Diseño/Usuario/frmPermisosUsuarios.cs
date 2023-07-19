using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.GestionUsuario;
using CapaDatos.GestionUsuario;

namespace Diseño.Usuario
{
    public partial class frmPermisosUsuarios : Form
    {
        private AsignarPermisosDAO oFuncionAsignadaDAO = new AsignarPermisosDAO();
        public frmPermisosUsuarios()
        {
            InitializeComponent();
        }

        private void iconBtnGuardar_Click(object sender, EventArgs e)
        {
            FuncionAsignada oFuncionAsignada = new FuncionAsignada();
            oFuncionAsignada.UsuarioId = (int)cmbUsuario.SelectedValue;
            oFuncionAsignada.FuncionDeAccesoId = (int)cmbPermisos.SelectedValue;
            oFuncionAsignada.FechaDeVencimiento = (DateTime)dtpVencimiento.Value;
            if (oFuncionAsignadaDAO.Agregar(oFuncionAsignada) == false)
                MessageBox.Show("El nuevo Registro no pudo ser guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Registro guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPermisosUsuarios_Load(object sender, EventArgs e)
        {
            cmbUsuario.DataSource = oFuncionAsignadaDAO.ListarUsuario();
            cmbUsuario.DisplayMember = "NombreDeUsuario";
            cmbUsuario.ValueMember = "Id";
            cmbUsuario.SelectedIndex = - 1;

            cmbPermisos.DataSource = oFuncionAsignadaDAO.ListarPermisos();
            cmbPermisos.DisplayMember = "Descripcion";
            cmbPermisos.ValueMember = "Id";
            cmbPermisos.SelectedIndex = -1;
        }
    }
}
