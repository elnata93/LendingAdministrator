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
    public partial class ConsultaCobradores : Form
    {
        public ConsultaCobradores()
        {
            InitializeComponent();
        }

        private void buscaCobradorbutton_Click(object sender, EventArgs e)
        {
            Cobradores cobrador = new Cobradores();
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
                ConsultaDataGridView.DataSource = cobrador.Listado("CobradorId,Nombres,Apellidos,Direccion,Telefono,Celular,Cedula ", filtro, "");
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.LendingReportViewer viewer = new Reportes.LendingReportViewer();
            DataTable dt = new DataTable();

            dt = (DataTable)ConsultaDataGridView.DataSource;
            dt.TableName = "Cocbradores";
            viewer.reporte = "CobradoresReport.rdlc";
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
                Validacion.Letras(e);
            }
            else
            if (FiltroComboBox.SelectedIndex == 2)
            {
                Validacion.Letras(e);
            }
            else
            if (FiltroComboBox.SelectedIndex == 3)
            {
                Validacion.Letras(e);
            }
            else
            {
                Validacion.Numeros(e);
            }

        }
    }
}
