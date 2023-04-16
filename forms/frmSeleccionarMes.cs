using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tepatuuri_soft.forms
{
    public partial class frmSeleccionarMes : origen
    {
        public frmSeleccionarMes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports.frmReportPedido frm = new reports.frmReportPedido(dateTimePicker1.Value);
            frm.Show();
            this.Close();
        }
    }
}
