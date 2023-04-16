using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace tepatuuri_soft.reports
{
    public partial class frmReportPedido : Form
    {
        public frmReportPedido(DateTime mes)
        {
            InitializeComponent();
            ReportParameter p1 = new ReportParameter("Mes", mes.Month.ToString() + " " + mes.Year);
            this.reportViewer1.LocalReport.SetParameters(p1);
            ReportParameter p2 = new ReportParameter("Inicio",  "01/" + mes.Month.ToString() + "/"+mes.Year.ToString());
            this.reportViewer1.LocalReport.SetParameters(p2);
            int mmes = mes.Month;
            while (mes.Month==mmes)
	        {
	         mes = mes.AddDays(1);
	        }
            mes = mes.AddDays(-1);
            string final = mes.Date.ToString();
            ReportParameter p3 = new ReportParameter("Fin", mes.Day.ToString()+"/"+mes.Month+"/"+mes.Year);
            this.reportViewer1.LocalReport.SetParameters(p3);
            this.reportViewer1.RefreshReport();
        }

        private void frmReportPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.VisPedidoCompleto' Puede moverla o quitarla según sea necesario.
            this.VisPedidoCompletoTableAdapter.Fill(this.DataSet1.VisPedidoCompleto);

            this.reportViewer1.RefreshReport();
        }
    }
}
