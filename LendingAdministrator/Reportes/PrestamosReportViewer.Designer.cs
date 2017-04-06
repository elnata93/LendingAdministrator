namespace LendingAdministrator.Reportes
{
    partial class PrestamosReportViewer
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrestamosDataSet = new LendingAdministrator.Reportes.PrestamosDataSet();
            this.PrestamosTableAdapter = new LendingAdministrator.Reportes.PrestamosDataSetTableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PrestamosDataSet";
            reportDataSource1.Value = this.PrestamosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LendingAdministrator.Reportes.PrestamosReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(846, 607);
            this.reportViewer1.TabIndex = 0;
            // 
            // PrestamosBindingSource
            // 
            this.PrestamosBindingSource.DataMember = "Prestamos";
            this.PrestamosBindingSource.DataSource = this.PrestamosDataSet;
            // 
            // PrestamosDataSet
            // 
            this.PrestamosDataSet.DataSetName = "PrestamosDataSet";
            this.PrestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PrestamosTableAdapter
            // 
            this.PrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // PrestamosReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 607);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "PrestamosReportViewer";
            this.Text = "PrestamosReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrestamosReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PrestamosBindingSource;
        private PrestamosDataSet PrestamosDataSet;
        private PrestamosDataSetTableAdapters.PrestamosTableAdapter PrestamosTableAdapter;
    }
}