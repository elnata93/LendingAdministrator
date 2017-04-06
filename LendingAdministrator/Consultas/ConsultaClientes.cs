using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace LendingAdministrator.Consultas
{
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            string filtro = "1=1";

            if (CamposcomboBox.SelectedIndex < 0 || FiltrotextBox.Text == "")
            {
                MessageBox.Show("Llene los campos requeridos");
            }
            else
            {
                if (FiltrotextBox.Text.Length > 0)
                {
                    filtro = CamposcomboBox.Text + " like '%" + FiltrotextBox.Text + "%'";
                }
                ConsultadataGridView.DataSource = cliente.Listado("ClienteId,Nombres,Apellidos,Direccion,Cedula", filtro, "");
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.LendingReportViewer viewer = new Reportes.LendingReportViewer();
            DataTable dt = new DataTable();

            dt = (DataTable)ConsultadataGridView.DataSource;
            dt.TableName = "Clientes";

            viewer.reporte = "ClientesReport.rdlc";
            viewer.data = dt;

            viewer.ShowDialog();
        }

        private void FiltrotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CamposcomboBox.SelectedIndex == 0)
            {
                Validacion.Numeros(e);
            }
            else
            {
                Validacion.Letras(e);
            }
        }
    }
}
