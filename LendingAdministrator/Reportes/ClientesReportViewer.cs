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
    public partial class ClientesReportViewer : Form
    {
        public ClientesReportViewer()
        {
            InitializeComponent();
        }

        private void ClientesReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientesDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.clientesDataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
