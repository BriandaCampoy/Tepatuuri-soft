namespace tepatuuri_soft.reports
{
    partial class frmReportPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPedido));
            this.VisPedidoCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new tepatuuri_soft.reports.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VisPedidoCompletoTableAdapter = new tepatuuri_soft.reports.DataSet1TableAdapters.VisPedidoCompletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VisPedidoCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // VisPedidoCompletoBindingSource
            // 
            this.VisPedidoCompletoBindingSource.DataMember = "VisPedidoCompleto";
            this.VisPedidoCompletoBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VisPedidoCompletoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tepatuuri_soft.reports.ReportPedidosdlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(690, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // VisPedidoCompletoTableAdapter
            // 
            this.VisPedidoCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 369);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportPedido";
            this.Text = "Reporte pedidos mensuales";
            this.Load += new System.EventHandler(this.frmReportPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisPedidoCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VisPedidoCompletoBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.VisPedidoCompletoTableAdapter VisPedidoCompletoTableAdapter;
    }
}