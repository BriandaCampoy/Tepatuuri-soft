﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tepatuuri_soft.reports
{
    public partial class frmReportListClientes : Form
    {
        public frmReportListClientes()
        {
            InitializeComponent();
        }

        private void frmReportListClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.VisClientes' Puede moverla o quitarla según sea necesario.
            this.VisClientesTableAdapter.Fill(this.DataSet1.VisClientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
