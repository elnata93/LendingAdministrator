using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class Validacion
    {
        public static int ConvertirToInt(string numero)
        {
            int num;
            int.TryParse(numero, out num);
            return num;
        }

        public static float ConvertirToFloat(string numero)
        {
            float num;
            float.TryParse(numero, out num);
            return num;
        }

        public static void Letras(KeyPressEventArgs e)
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
                    MessageBox.Show(" SOLO SE ACEPTAN LETRAS ", " Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Numeros(KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
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
                    MessageBox.Show(" SOLO SE ACEPTAN NUMEROS ", " Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
