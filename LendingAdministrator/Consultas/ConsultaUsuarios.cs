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
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
            FiltroTextBox.ReadOnly = true;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            string filtro = "1=1";
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
                ConsultaGridView.DataSource = user.Listado("UsuarioId,Nombres,Apellidos,NombresUsuarios,Contrasena,TiposUsuarios ", filtro, "");
            }
            //if (FiltroComboBox.SelectedText != "")
            //{
            //    //filtro = FiltroComboBox.Text + " like '%" + FiltroTextBox.Text + "%'";
            //    ConsultaGridView.DataSource = user.Listado(" * ", filtro, "");
            //}
            //else
            //if (FiltroComboBox.SelectedText == "")
            //{
            //    if (FiltroTextBox.Text == "")
            //    {
            //        MessageBox.Show("Llene los campos requeridos");
            //    }
            //    else
            //    {
            //        if (FiltroTextBox.Text.Length > 0)
            //        {
            //            filtro = FiltroComboBox.Text + " like '%" + FiltroTextBox.Text + "%'";
            //        }
            //        ConsultaGridView.DataSource = user.Listado("UsuarioId,Nombres,Apellidos,NombresUsuarios,Contrasena,TiposUsuarios ", filtro, "");
            //    }
            //}

        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.LendingReportViewer viewer = new Reportes.LendingReportViewer();
            DataTable dt = new DataTable();

            dt = (DataTable)ConsultaGridView.DataSource;
            dt.TableName = "Usuarios";

            viewer.reporte = "UsuariosReport.rdlc";
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
            {
                Validacion.Letras(e);
            }
        }

        private void FiltroComboBox_TextChanged(object sender, EventArgs e)
        {
            //if (FiltroTextBox.SelectedText != "")
            //{
            //    FiltroTextBox.ReadOnly = false;
            //}

        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroTextBox.ReadOnly)
            {
                FiltroTextBox.ReadOnly = false;
            }
        }
    }
}
