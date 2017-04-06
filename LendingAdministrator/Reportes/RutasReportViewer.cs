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
    public partial class RutasReportViewer : Form
    {
        public RutasReportViewer()
        {
            InitializeComponent();
        }

        private void RutasReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RutasDataSet.Rutas' table. You can move, or remove it, as needed.
            this.RutasTableAdapter.Fill(this.RutasDataSet.Rutas);

            this.reportViewer1.RefreshReport();
        }
    }
}
