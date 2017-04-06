using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace LendingAdministrator.Registros
{
    public partial class RegistroRutas : Form
    {
        public RegistroRutas()
        {
            InitializeComponent();
        }

        private void CargarDatos(Rutas ruta)
        {
            ruta.NombreRuta = NombreRutatextBox.Text;
            ruta.CobradorId = Convert.ToInt32(CobradorIdcomboBox.SelectedValue);
        }

        private void DevolverDatos(Rutas ruta)
        {
            IdTextBox.Text = ruta.RutaId.ToString();
            NombreRutatextBox.Text = ruta.NombreRuta.ToString();
            CobradorIdcomboBox.SelectedValue = ruta.CobradorId.ToString();

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Rutas ruta = new Rutas();
            if (IdTextBox.Text.Trim() == "")
            {
                RutaerrorProvider.SetError(IdTextBox, "Especifica el Cliente Id");
                IdTextBox.Focus();
            }
            else
            {
                RutaerrorProvider.Clear();
            }
            if (IdTextBox.TextLength > 0)
            {
                if (ruta.Buscar(Validacion.ConvertirToInt(IdTextBox.Text)))
                {
                    DevolverDatos(ruta);
                    GuardarButton.Enabled = true;
                    EliminarButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("NO EXISTE RUTA ID ");
                }
            }
        }



        private void Limpiar()
        {
            IdTextBox.Clear();
            NombreRutatextBox.Clear();
            CobradorIdcomboBox.SelectedValue = 0;
            IdTextBox.Enabled = false;
            BuscarButton.Enabled = false;
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = false;
        }

        private void BtnTipTap()
        {
            BuscarButton.Enabled = true;
            IdTextBox.Enabled = true;
            GuardarButton.Enabled = false;
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Rutas ruta = new Rutas();

            if (NombreRutatextBox.TextLength == 0)
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
              if (IdTextBox.TextLength == 0)
            {
                CargarDatos(ruta);

                if (ruta.Insertar())
                {
                    MessageBox.Show("Ruta ha sido Registrada");
                }
                else
                {
                    MessageBox.Show("Ruta no ha podido ser Registrada");
                }
                Limpiar();
                BtnTipTap();

            }
            else if (IdTextBox.TextLength > 0)
            {
                ruta.RutaId = Validacion.ConvertirToInt(IdTextBox.Text);
                CargarDatos(ruta);
                if (ruta.Editar())
                {
                    MessageBox.Show("Ruta ha sido Editada");

                }
                else
                {
                    MessageBox.Show("Ruta no ha sido Editada Correctamente");
                }
                Limpiar();
                BtnTipTap();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            Rutas ruta = new Rutas();
            int id = Validacion.ConvertirToInt(IdTextBox.Text);
            if (id > 0)
            {
                CargarDatos(ruta);

                if (ruta.Eliminar())
                {
                    MessageBox.Show("Ruta se elimino Correctamente");
                }
                else
                {
                    MessageBox.Show("Ruta no se elimino Correctamente");
                }

            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Rutas ruta = new Rutas();
            int id = Validacion.ConvertirToInt(IdTextBox.Text);

            if (id > 0)
            {
                CargarDatos(ruta);
                if (ruta.Eliminar())
                {
                    MessageBox.Show("Ruta se elimino Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ruta no se elimino Correctamente");
                }

            }
        }

        private void RegistroRutas_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            GuardarButton.Enabled = false;
            EliminarButton.Enabled = false;
        }

        private void CargarComboBox()
        {
            Cobradores cobrador = new Cobradores();
            CobradorIdcomboBox.DataSource = cobrador.Listado("*", "1=1", "");
            CobradorIdcomboBox.DisplayMember = "Nombres";
            CobradorIdcomboBox.ValueMember = "CobradorId";
        }

        private void CobradorIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RutaIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Numeros(e);
        }

        private void NombreRutatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }
    }
}
