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
    public partial class ConsultaPrestamos : Form
    {
        public ConsultaPrestamos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Prestamos prestamo = new Prestamos();
            string filtro = "";
            if (FiltroComboBox.SelectedIndex < 0 || FiltroTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos requeridos");
            }
            else
            {
                if (FiltroTextBox.Text.Length > 0)
                {
                    filtro = FiltroComboBox.Text + " like '%" + FiltroTextBox.Text + "%'";
                }
                ConsultaDataGridView.DataSource = prestamo.Listado("PrestamoId,ClienteId,FechaInicial,FechaVencimiento,Monto,NuSemana,CantidadCuota,Interes,Cuota,PagoTotal ", filtro, "");
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.LendingReportViewer viewer = new Reportes.LendingReportViewer();
            DataTable dt = new DataTable();

            dt = (DataTable)ConsultaDataGridView.DataSource;
            dt.TableName = "Prestamos";
            viewer.reporte = "PrestamosReport.rdlc";
            viewer.data = dt;
            viewer.ShowDialog();
        }

        private void FiltroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 0)
            {
                Validacion.Numeros(e);
            }
            else
            if (FiltroComboBox.SelectedIndex == 1)
            {
                Validacion.Numeros(e);
            }
        }
    }
}
