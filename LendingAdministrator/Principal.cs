using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LendingAdministrator
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroUsuarios user = new Registros.RegistroUsuarios();
            user.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.RegistroClientes cliente = new Registros.RegistroClientes();
            cliente.ShowDialog();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroRutas ruta = new Registros.RegistroRutas();
            ruta.ShowDialog();
        }

        private void cobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroCobradores cobra = new Registros.RegistroCobradores();
            cobra.ShowDialog();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.RegistroPrestamos presta = new Registros.RegistroPrestamos();
            presta.ShowDialog();
        }

        private void atrasosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroAtrasos atraso = new Registros.RegistroAtrasos();
            atraso.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaClientes ccliente = new Consultas.ConsultaClientes();
            ccliente.ShowDialog();
        }

        private void cobradoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaCobradores cobrador = new Consultas.ConsultaCobradores();
            cobrador.ShowDialog();
        }


        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuarios user = new Consultas.ConsultaUsuarios();
            user.ShowDialog();
        }

        private void rutasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaRutas ruta = new Consultas.ConsultaRutas();
            ruta.ShowDialog();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaPrestamos consulta = new Consultas.ConsultaPrestamos();
            consulta.ShowDialog();
        }

        private void atrasosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaAtrasos atraso = new Consultas.ConsultaAtrasos();
            atraso.ShowDialog();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ClientesReportViewer report = new Reportes.ClientesReportViewer();
            report.Show();
        }

        private void reporteDeCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.CobradoresReportViewer cobrador = new Reportes.CobradoresReportViewer();
            cobrador.Show();
        }

        private void reporteDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.PrestamosReportViewer prestamo = new Reportes.PrestamosReportViewer();
            prestamo.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.RutasReportViewer ruta = new Reportes.RutasReportViewer();
            ruta.Show();
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stars Developers surge al darnos cuenta de las diferentes situaciones e inconvenientes que se le está presentando a muchas empresas que se dedican prestar dinero a diferentes personas y no tienen un control  de información  eficiente también carecen de  un sistema automatizado para mejor manejo y control de datos de los clientes, el objetivo del sistema consiste en automatizar el proceso de préstamos a diferentes empresas del país para que tengan un manejo optimo y confiable a la hora de prestar sus servicios.");
        }
    }
}
