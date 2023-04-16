namespace tepatuuri_soft.reports
{
    partial class frmReportReStock
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportReStock));
            this.VisInvInsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new tepatuuri_soft.reports.DataSet1();
            this.VisInvProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VisInvInsumoTableAdapter = new tepatuuri_soft.reports.DataSet1TableAdapters.VisInvInsumoTableAdapter();
            this.VisInvProductoTableAdapter = new tepatuuri_soft.reports.DataSet1TableAdapters.VisInvProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VisInvInsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisInvProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VisInvInsumoBindingSource
            // 
            this.VisInvInsumoBindingSource.DataMember = "VisInvInsumo";
            this.VisInvInsumoBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VisInvProductoBindingSource
            // 
            this.VisInvProductoBindingSource.DataMember = "VisInvProducto";
            this.VisInvProductoBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VisInvInsumoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.VisInvProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tepatuuri_soft.reports.ReportReStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(591, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // VisInvInsumoTableAdapter
            // 
            this.VisInvInsumoTableAdapter.ClearBeforeFill = true;
            // 
            // VisInvProductoTableAdapter
            // 
            this.VisInvProductoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportReStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 350);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportReStock";
            this.Text = "Reporte necesidades de Re-stock";
            this.Load += new System.EventHandler(this.frmReportReStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisInvInsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisInvProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VisInvInsumoBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource VisInvProductoBindingSource;
        private DataSet1TableAdapters.VisInvInsumoTableAdapter VisInvInsumoTableAdapter;
        private DataSet1TableAdapters.VisInvProductoTableAdapter VisInvProductoTableAdapter;
    }
}