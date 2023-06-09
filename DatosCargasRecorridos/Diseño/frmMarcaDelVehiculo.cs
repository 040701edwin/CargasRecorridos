﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Modelo;
using CapaDatos;
using CapaLogica;

namespace Diseño
{
    public partial class frmMarcaDelVehiculo : Form
    {
        private MarcaDeVehiculoDAO oMarcaDAO = new MarcaDeVehiculoDAO();
        private bool NuevoRegistro = false;

        public frmMarcaDelVehiculo()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtMarca.Text = string.Empty; txtMarca.Focus();
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            if(NuevoRegistro == true)
            {
                MarcaVehiculo oMarca = new MarcaVehiculo();
                oMarca.Marca = txtMarca.Text.Trim();
                if(oMarcaDAO.Agregar(oMarca) == false)
                    MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MarcaVehiculo oMarca = oMarcaDAO.Buscar(txtMarca.Text.Trim());
                oMarca.Marca = txtMarca.Text.Trim();
                if(oMarcaDAO.Modificar(oMarca) == false)
                    MessageBox.Show("El registro no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
