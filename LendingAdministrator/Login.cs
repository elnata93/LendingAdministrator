using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace LendingAdministrator
{
    public partial class Login : Form
    {
        public string Usuario { get; set; }
        public string contrasena { get; set; }

        public Login()
        {
            InitializeComponent();
            this.Usuario = "";
            this.contrasena = "";
        }


        public Login(string usuario, string contrasena)
        {
            this.Usuario = usuario;
            this.contrasena = contrasena;
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            if (user.Login(usuarioTextBox.Text, ContrasenaTextBox.Text) == true)
            {
                Principal menu = new Principal();
                menu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectas");
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                    // MessageBox.Show(" SOLO SE ACEPTAN LETRAS ", " Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
                        
        }

        private void ContrasenaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
