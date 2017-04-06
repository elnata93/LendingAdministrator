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
    public partial class RegistroPrestamos : Form
    {
        public RegistroPrestamos()
        {
            InitializeComponent();
        }

        private void CargarComboBox()
        {
            Clientes cliente = new Clientes();
            ClientecomboBox.DataSource = cliente.Listado("*", "1=1", "");
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "ClienteId";
        }


        private void RegistroPrestamos_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            GuardarButton.Enabled = false;
            EliminarButton.Enabled = false;
        }


        private void DevolverDatos(Prestamos prestamo)
        {
            IdTextBox.Text = prestamo.PrestamoId.ToString();
            ClientecomboBox.SelectedValue = prestamo.ClienteId.ToString();
            FechaIdateTimePicker.Text = prestamo.FechaInicial.ToString();
            FechaFdateTimePicker.Text = prestamo.FechaVencimiento.ToString();
            MontotextBox.Text = prestamo.Monto.ToString();
            CuotaPtextBox.Text = prestamo.Cuota.ToString();
            SemanaNotextBox.Text = prestamo.NuSemana.ToString();
            CantidadCuotatextBox.Text = prestamo.CantidadCuota.ToString();
            InterestextBox.Text = prestamo.Interes.ToString();
            PagoTotaltextBox.Text = prestamo.PagoTotal.ToString();

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Prestamos prestamo = new Prestamos();
            if (IdTextBox.Text.Trim() == "")
            {
                PrestamoserrorProvider.SetError(IdTextBox, "Especifica el Cliente Id");
                IdTextBox.Focus();
            }
            else
            {
                PrestamoserrorProvider.Clear();
            }

            if (IdTextBox.TextLength > 0)
            {

                if (prestamo.Buscar(Validacion.ConvertirToInt(IdTextBox.Text)))
                {
                    DevolverDatos(prestamo);
                    GuardarButton.Enabled = true;
                    EliminarButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El id que busca no existe");
                }
            }

        }

        private void Limpiar()
        {
            IdTextBox.Clear();
            ClientecomboBox.SelectedIndex = 0;
            MontotextBox.Clear();
            CuotaPtextBox.Clear();
            FechaIdateTimePicker.Text = string.Empty;
            FechaFdateTimePicker.Text = string.Empty;
            SemanaNotextBox.Clear();
            PagoTotaltextBox.Clear();
            IdTextBox.Enabled = false;
            BuscarButton.Enabled = false;
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = false;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void CargarDatos(Prestamos prestamo)
        {
            prestamo.PrestamoId = Validacion.ConvertirToInt(IdTextBox.Text);
            prestamo.ClienteId = Convert.ToInt32(ClientecomboBox.SelectedValue);
            prestamo.FechaInicial = FechaIdateTimePicker.Text;
            prestamo.FechaVencimiento = FechaFdateTimePicker.Text;
            prestamo.CantidadCuota = Validacion.ConvertirToFloat(CantidadCuotatextBox.Text);
            prestamo.Interes = Validacion.ConvertirToFloat(InterestextBox.Text);

            prestamo.Monto = Validacion.ConvertirToFloat(MontotextBox.Text);
            prestamo.Cuota = Validacion.ConvertirToFloat(CuotaPtextBox.Text);
            prestamo.PagoTotal = Validacion.ConvertirToFloat(PagoTotaltextBox.Text);
            prestamo.NuSemana = Validacion.ConvertirToInt(SemanaNotextBox.Text);

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
            Prestamos prestamo = new Prestamos();

            if (IdTextBox.TextLength == 0)
            {
                CargarDatos(prestamo);
                if (prestamo.Insertar())
                {
                    MessageBox.Show("Prestamo ha sido Registrado");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Prestamo no ha sido Registrado");
                }
                BtnTipTap();
            }
            else
            if (IdTextBox.TextLength > 0)
            {
                CargarDatos(prestamo);
                if (prestamo.Editar())
                {
                    MessageBox.Show("Prestamo ha sido Editado");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Prestamo no ha sido Editado");
                }
                BtnTipTap();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Prestamos prestamo = new Prestamos();
            if (Validacion.ConvertirToInt(IdTextBox.Text) == 0)
            {
                MessageBox.Show("Debe especifiar el ID...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (Validacion.ConvertirToInt(IdTextBox.Text) > 0)
            {
                prestamo.PrestamoId = Validacion.ConvertirToInt(IdTextBox.Text);
                CargarDatos(prestamo);

                if (prestamo.Eliminar())
                {
                    MessageBox.Show("Prestamo Eliminado.");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Prestamo no ha sido Eliminado.");
                }

            }
        }


        private void MontotextBox_TextChanged(object sender, EventArgs e)
        {
            Prestamos prestamo = new Prestamos();
            prestamo.Cuota = Validacion.ConvertirToFloat(MontotextBox.Text) * Validacion.ConvertirToFloat(InterestextBox.Text);
            CuotaPtextBox.Text = prestamo.Cuota.ToString();

            prestamo.PagoTotal = Validacion.ConvertirToFloat(CuotaPtextBox.Text) * Validacion.ConvertirToFloat(CantidadCuotatextBox.Text);
            PagoTotaltextBox.Text = prestamo.PagoTotal.ToString();
        }





        private void PrestamoIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Numeros(e);
        }

        private void MontotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Numeros(e);
        }

        private void CuotaPtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Numeros(e);
        }

        private void SemanaNotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Numeros(e);
        }


    }
}
