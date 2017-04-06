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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void LlenarCampos(Clientes cliente)
        {
            NombreTextBox.Text = cliente.Nombres;
            ApellidoTextBox.Text = cliente.Apellidos;
            ApodoTextBox.Text = cliente.Apodos;
            DireccionTextBox.Text = cliente.Direccion;
            ReferenciaTextBox.Text = cliente.Referencia;
            CedulaMaskedTextBox.Text = cliente.Cedula;
            CelularMaskedTextBox.Text = cliente.Celular;
            TelefonoMaskedTextBox.Text = cliente.Telefono;
            if (cliente.Sexo == 1)
            {
                MasculinoRadioButton.Checked = true;
            }
            else
            {
                FemeninoRadioButton.Checked = true;
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            if (IdTextBox.Text.Trim() == "")
            {
                ClienteerrorProvider.SetError(IdTextBox, "Especifica el Cliente Id");
                IdTextBox.Focus();
            }
            else
            {
                ClienteerrorProvider.Clear();
            }

            if (IdTextBox.TextLength > 0)
            {

                if (cliente.Buscar(Validacion.ConvertirToInt(IdTextBox.Text)))
                {
                    LlenarCampos(cliente);
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
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            ApodoTextBox.Clear();
            DireccionTextBox.Clear();
            ReferenciaTextBox.Clear();
            CedulaMaskedTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            CelularMaskedTextBox.Clear();
            IdTextBox.Enabled = false;
            MasculinoRadioButton.Checked = false;
            FemeninoRadioButton.Checked = false;
            BuscarButton.Enabled = false;
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = false;

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenarDatos(Clientes cliente)
        {
            cliente.ClienteId = Validacion.ConvertirToInt(IdTextBox.Text);
            cliente.Nombres = NombreTextBox.Text;
            cliente.Apellidos = ApellidoTextBox.Text;
            cliente.Apodos = ApodoTextBox.Text;
            cliente.Direccion = DireccionTextBox.Text;
            cliente.Referencia = ReferenciaTextBox.Text;
            cliente.Cedula = CedulaMaskedTextBox.Text;
            cliente.Telefono = TelefonoMaskedTextBox.Text;
            cliente.Celular = CelularMaskedTextBox.Text;
            if (MasculinoRadioButton.Checked)
            {
                cliente.Sexo = 1;
            }
            else
            {
                cliente.Sexo = 0;
            }
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
            Clientes cliente = new Clientes();
            if (NombreTextBox.Text.Length == 0 || ApellidoTextBox.Text.Length == 0 || DireccionTextBox.Text.Length == 0 || DireccionTextBox.Text.Length == 0 || ReferenciaTextBox.Text.Length == 0 || CedulaMaskedTextBox.Text.Length == 0 || TelefonoMaskedTextBox.Text.Length == 0 || CelularMaskedTextBox.Text.Length == 0)
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (IdTextBox.TextLength == 0)
            {
                LlenarDatos(cliente);
                if (cliente.Insertar())
                {
                    MessageBox.Show("Cliente ha sido Registrado");
                }
                else
                {
                    MessageBox.Show("Cliente no ha sido Registrado");
                }
                Limpiar();
                BtnTipTap();

            }
            else
            if (IdTextBox.TextLength > 0)
            {
                
                LlenarDatos(cliente);
                if (cliente.Editar())
                {
                    MessageBox.Show("Cliente ha sido Editado");
                }
                else
                {
                    MessageBox.Show("Cliente no ha sido Editado");
                }
                Limpiar();
                BtnTipTap();
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            if (Validacion.ConvertirToInt(IdTextBox.Text) == 0)
            {
                MessageBox.Show("Debe especifiar el ID...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (Validacion.ConvertirToInt(IdTextBox.Text) > 0)
            {
                cliente.ClienteId = Validacion.ConvertirToInt(IdTextBox.Text);
                LlenarDatos(cliente);

                if (cliente.Eliminar())
                {
                    MessageBox.Show("Cliente Eliminado.");
                }
                else
                {
                    MessageBox.Show("Cliente no ha sido Eliminado.");
                }
                Limpiar();
            }
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void ApellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void ApodoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void ReferenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void DireccionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Numeros(e);
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            GuardarButton.Enabled = false;
            EliminarButton.Enabled = false;

        }
    }
}
