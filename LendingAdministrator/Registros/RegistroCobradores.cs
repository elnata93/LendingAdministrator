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
    public partial class RegistroCobradores : Form
    {
        public RegistroCobradores()
        {
            InitializeComponent();
        }

        private void DevolverDatos(Cobradores cobrador)
        {
            IdTextBox.Text = cobrador.CobradorId.ToString();
            NombretextBox.Text = cobrador.Nombres;
            ApellidotextBox.Text = cobrador.Apellidos;
            DirecciontextBox.Text = cobrador.Direccion;
            TelefonotextBox.Text = cobrador.Telefono;
            CelulartextBox.Text = cobrador.Celular;
            CedulatextBox.Text = cobrador.Cedula;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Cobradores cobrador = new Cobradores();

            if (IdTextBox.Text.Trim() == "")
            {
                CobradorerrorProvider.SetError(IdTextBox, "Especifica el Cliente Id");
                IdTextBox.Focus();
            }
            else
            {
                CobradorerrorProvider.Clear();
            }

            if (IdTextBox.TextLength > 0)
            {

                if (cobrador.Buscar(Validacion.ConvertirToInt(IdTextBox.Text)))
                {
                    DevolverDatos(cobrador);
                }
                GuardarButton.Enabled = true;
                EliminarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("El id que busca no existe");
            }
        }

        private void Limpiar()
        {
            IdTextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            CelulartextBox.Clear();
            CedulatextBox.Clear();
            IdTextBox.Enabled = false;
            BuscarButton.Enabled = false;
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = false;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void CargarDatos(Cobradores cobrador)
        {
            cobrador.CobradorId = Validacion.ConvertirToInt(IdTextBox.Text);
            cobrador.Nombres = NombretextBox.Text;
            cobrador.Apellidos = ApellidotextBox.Text;
            cobrador.Direccion = DirecciontextBox.Text;
            cobrador.Telefono = TelefonotextBox.Text;
            cobrador.Celular = CelulartextBox.Text;
            cobrador.Cedula = CedulatextBox.Text;
        }

        private void BtnTipTap()
        {
            BuscarButton.Enabled = true;
            IdTextBox.Enabled = true;
            GuardarButton.Enabled = false;
            EliminarButton.Enabled = false;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cobradores cobrador = new Cobradores();

            if (NombretextBox.Text.Length == 0 && ApellidotextBox.Text.Length == 0 && DirecciontextBox.Text.Length == 0 && TelefonotextBox.Text.Length == 0 && CelulartextBox.Text.Length == 0 && CedulatextBox.Text.Length == 0)
            {
                MessageBox.Show("El campo debe estar lleno ");
            }
            else
               
            if (IdTextBox.TextLength == 0)
            {
                CargarDatos(cobrador);
                if (cobrador.Insertar())
                {
                    MessageBox.Show("Cobrador se agrego Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Cobrador no se agrego Correctamente");
                }
                BtnTipTap();
            }
            else
                if (IdTextBox.TextLength > 0)
            {
                //cobrador.CobradorId = Validacion.ConvertirToInt(CobradorIdtextBox.Text);
                CargarDatos(cobrador);
                if (cobrador.Editar())
                {
                    MessageBox.Show("Cobrador se edito Correctamente");
                    
                }
                else
                {
                    MessageBox.Show("Cobrador no se edito Correctamente");
                }
                Limpiar();
                BtnTipTap();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Cobradores cobrador = new Cobradores();
            int id = Validacion.ConvertirToInt(IdTextBox.Text);

            if (id > 0)
            {
                CargarDatos(cobrador);
                if (cobrador.Eliminar())
                {
                    MessageBox.Show("Cobrador se elimino Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Cobrador no se elimino Correctamente");
                }
            }
        }

        private void RegistroCobradores_Load(object sender, EventArgs e)
        {
            GuardarButton.Enabled = false;
            EliminarButton.Enabled = false;
        }

        private void CobradorIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Numeros(e);
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        private void DirecciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Letras(e);
        }

        
    }
}
