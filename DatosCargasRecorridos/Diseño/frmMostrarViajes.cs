﻿using System;
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
    public partial class frmMostrarViajes : Form
    {
        public frmMostrarViajes()
        {
            InitializeComponent();
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            frmViaje frm = new frmViaje();
            frm.ShowDialog();
        }
    }
}
