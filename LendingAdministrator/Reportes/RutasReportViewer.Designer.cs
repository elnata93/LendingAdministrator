namespace LendingAdministrator.Reportes
{
    partial class RutasReportViewer
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
            this.RutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RutasDataSet = new LendingAdministrator.Reportes.RutasDataSet();
            this.RutasTableAdapter = new LendingAdministrator.Reportes.RutasDataSetTableAdapters.RutasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RutasDataSet";
            reportDataSource1.Value = this.RutasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LendingAdministrator.Reportes.RutasReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(694, 524);
            this.reportViewer1.TabIndex = 0;
            // 
            // RutasBindingSource
            // 
            this.RutasBindingSource.DataMember = "Rutas";
            this.RutasBindingSource.DataSource = this.RutasDataSet;
            // 
            // RutasDataSet
            // 
            this.RutasDataSet.DataSetName = "RutasDataSet";
            this.RutasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RutasTableAdapter
            // 
            this.RutasTableAdapter.ClearBeforeFill = true;
            // 
            // RutasReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 524);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RutasReportViewer";
            this.Text = "RutasReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RutasReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RutasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RutasBindingSource;
        private RutasDataSet RutasDataSet;
        private RutasDataSetTableAdapters.RutasTableAdapter RutasTableAdapter;
    }
}