using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LendingAdministrator.Reportes
{
    public partial class PrestamosReportViewer : Form
    {
        public PrestamosReportViewer()
        {
            InitializeComponent();
        }

        private void PrestamosReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PrestamosDataSet.Prestamos' table. You can move, or remove it, as needed.
            this.PrestamosTableAdapter.Fill(this.PrestamosDataSet.Prestamos);

            this.reportViewer1.RefreshReport();
        }
    }
}
