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
    public partial class CobradoresReportViewer : Form
    {
        public CobradoresReportViewer()
        {
            InitializeComponent();
        }

        private void CobradoresReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CobradoresDataSet.Cobradores' table. You can move, or remove it, as needed.
            this.CobradoresTableAdapter.Fill(this.CobradoresDataSet.Cobradores);

            this.reportViewer1.RefreshReport();
        }
    }
}
