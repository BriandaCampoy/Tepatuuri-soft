using System;
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
    public partial class frmReportListProveedores : Form
    {
        public frmReportListProveedores()
        {
            InitializeComponent();
        }

        private void frmReportListProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.VisProveedor' Puede moverla o quitarla según sea necesario.
            this.VisProveedorTableAdapter.Fill(this.DataSet1.VisProveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
