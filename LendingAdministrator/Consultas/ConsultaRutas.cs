using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace LendingAdministrator.Consultas
{
    public partial class ConsultaRutas : Form
    {
        public ConsultaRutas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Rutas ruta = new Rutas();
            string filtro = "";
            if (FiltroTextBox.Text.Length > 0)
            {
                filtro = FiltroComboBox.Text + " like '%" + FiltroTextBox.Text + "%'";
            }
            ConsultaDataGridView.DataSource = ruta.Listado("RutaId,NombreRuta ", filtro, "");
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.LendingReportViewer viewer = new Reportes.LendingReportViewer();
            DataTable dt = new DataTable();

            dt = (DataTable)ConsultaDataGridView.DataSource;
            dt.TableName = "Rutas";
            viewer.reporte = "RutasReport.rdlc";
            viewer.data = dt;
            viewer.ShowDialog();
        }
    }
}
