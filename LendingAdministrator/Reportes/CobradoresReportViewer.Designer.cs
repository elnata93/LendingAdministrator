namespace LendingAdministrator.Reportes
{
    partial class CobradoresReportViewer
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
            this.CobradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CobradoresDataSet = new LendingAdministrator.Reportes.CobradoresDataSet();
            this.CobradoresTableAdapter = new LendingAdministrator.Reportes.CobradoresDataSetTableAdapters.CobradoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CobradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobradoresDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CobradoresDataSet";
            reportDataSource1.Value = this.CobradoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LendingAdministrator.Reportes.CobradoresReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(739, 550);
            this.reportViewer1.TabIndex = 0;
            // 
            // CobradoresBindingSource
            // 
            this.CobradoresBindingSource.DataMember = "Cobradores";
            this.CobradoresBindingSource.DataSource = this.CobradoresDataSet;
            // 
            // CobradoresDataSet
            // 
            this.CobradoresDataSet.DataSetName = "CobradoresDataSet";
            this.CobradoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CobradoresTableAdapter
            // 
            this.CobradoresTableAdapter.ClearBeforeFill = true;
            // 
            // CobradoresReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 550);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "CobradoresReportViewer";
            this.Text = "CobradoresReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CobradoresReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CobradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobradoresDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CobradoresBindingSource;
        private CobradoresDataSet CobradoresDataSet;
        private CobradoresDataSetTableAdapters.CobradoresTableAdapter CobradoresTableAdapter;
    }
}