namespace tepatuuri_soft.reports
{
    partial class frmReportInvProductos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportInvProductos));
            this.VisInvProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new tepatuuri_soft.reports.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VisInvProductoTableAdapter = new tepatuuri_soft.reports.DataSet1TableAdapters.VisInvProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VisInvProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // VisInvProductoBindingSource
            // 
            this.VisInvProductoBindingSource.DataMember = "VisInvProducto";
            this.VisInvProductoBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VisInvProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tepatuuri_soft.reports.ReporInvProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(523, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // VisInvProductoTableAdapter
            // 
            this.VisInvProductoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportInvProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 324);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportInvProductos";
            this.Text = "Reporte inventario de productos";
            this.Load += new System.EventHandler(this.frmReportInvProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisInvProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VisInvProductoBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.VisInvProductoTableAdapter VisInvProductoTableAdapter;
    }
}