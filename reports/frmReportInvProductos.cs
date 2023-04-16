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
    public partial class frmReportInvProductos : Form
    {
        public frmReportInvProductos()
        {
            InitializeComponent();
        }

        private void frmReportInvProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.VisInvProducto' Puede moverla o quitarla según sea necesario.
            this.VisInvProductoTableAdapter.Fill(this.DataSet1.VisInvProducto);

            this.reportViewer1.RefreshReport();
        }
    }
}
