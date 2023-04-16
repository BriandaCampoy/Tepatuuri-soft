namespace tepatuuri_soft.reports
{
    partial class frmInvInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvInsumo));
            this.VisInvInsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new tepatuuri_soft.reports.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VisInvInsumoTableAdapter = new tepatuuri_soft.reports.DataSet1TableAdapters.VisInvInsumoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VisInvInsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VisInvInsumoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tepatuuri_soft.reports.ReportInvInsumo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(501, 333);
            this.reportViewer1.TabIndex = 0;
            // 
            // VisInvInsumoTableAdapter
            // 
            this.VisInvInsumoTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 333);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvInsumo";
            this.Text = "Reporte inventario insumos";
            this.Load += new System.EventHandler(this.frmInvInsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisInvInsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VisInvInsumoBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.VisInvInsumoTableAdapter VisInvInsumoTableAdapter;
    }
}