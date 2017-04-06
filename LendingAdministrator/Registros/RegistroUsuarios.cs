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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void LlenarCampos(Usuarios user)
        {
            NombretextBox.Text = user.Nombres;
            ApellidotextBox.Text = user.Apellidos;
            NombreUsuariotextBox.Text = user.NombreUsuario;
            ContrasenatextBox.Text = user.Contrasena;
            TipoUsuariocomboBox.Text = user.TipoUsuario;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            if (IdTextBox.TextLength > 0)
            {
                if (user.Buscar(Validacion.ConvertirToInt(IdTextBox.Text)))
                {
                    LlenarCampos(user);
                    GuardarButton.Enabled = true;
                    EliminarButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El Id no existe");
                    
                }
            }
        }

        private void Limpiar()
        {
            IdTextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            NombreUsuariotextBox.Clear();
            ContrasenatextBox.Clear();
            TipoUsuariocomboBox.Text = null;
            IdTextBox.Enabled = false;
            BuscarButton.Enabled = false;
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = false;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenarDatos(Usuarios user)
        {
            user.UsuarioId = Validacion.ConvertirToInt(IdTextBox.Text);
            user.Nombres = NombretextBox.Text;
            user.Apellidos = ApellidotextBox.Text;
            user.NombreUsuario = NombreUsuariotextBox.Text;
            user.Contrasena = ContrasenatextBox.Text;
            user.TipoUsuario = TipoUsuariocomboBox.Text;
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
            Usuarios user = new Usuarios();

            //if (NombretextBox.TextLength == 0 || NombreUsuariotextBox.TextLength == 0 || ContrasenatextBox.TextLength == 0 || TipoUsuariocomboBox.SelectedText == "")
            //{
            //    MessageBox.Show("Faltan campos por llenar ");
            //}
            //else
            if (IdTextBox.TextLength == 0)
            {
                LlenarDatos(user);
                if (user.Insertar())
                {
                    MessageBox.Show("Usuario guardado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error! no se guardo el Usuario");
                }
                Limpiar();
                BtnTipTap();
            }
            else
                if (IdTextBox.TextLength > 0)
            {
                LlenarDatos(user);
                if (user.Editar())
                {
                    MessageBox.Show("Usuario editado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error! no se edito el Usuario");
                }
                Limpiar();
                BtnTipTap();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            if (IdTextBox.TextLength > 0)
            {
                LlenarCampos(user);
                if (user.Eliminar())
                {
                    MessageBox.Show("Usuario se elimino Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Usuario no se elimino Correctamente");
                }
                Limpiar();
            }
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    //MessageBox.Show(" SOLO SE ACEPTAN LETRAS ", " Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    //MessageBox.Show(" SOLO SE ACEPTAN LETRAS ", " Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void NombreUsuariotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    //MessageBox.Show(" SOLO SE ACEPTAN LETRAS ", " Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UsuarioIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            GuardarButton.Enabled = false;
            EliminarButton.Enabled = false;
        }

        //private void AgregarImgbutton_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.InitialDirectory = "C:\\Users\\user\\Pictures";
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        ImgpictureBox.Image = Image.FromFile(openFileDialog1.FileName);
        //    }
        //}
    }
}
