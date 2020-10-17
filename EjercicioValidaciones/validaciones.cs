using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EjercicioValidaciones
{
    class validaciones
    {
        //validar si es vacio
        public Boolean Vacio(TextBox caja, ErrorProvider error, string mensaje)
        {
            if (caja.Text == "")
            {
                error.SetError(caja, mensaje);
                caja.Focus();
                return true;
            }
            else
            {
                error.Clear();
                return false;
            }
        }

        //validar si es texto+
        public Boolean TipoTexto(TextBox caja, ErrorProvider error, string mensaje)
        {
            Regex formato = new Regex("^[a-zA-Z]+$");
            if (!formato.IsMatch(caja.Text))
            {
                error.SetError(caja, mensaje);
                caja.Focus();
                return true;
            }
            else
            {
                error.Clear();
                return false;
            }
        }

        //validar si es Numero+
        public Boolean TipoNumero(TextBox caja, ErrorProvider error, string mensaje)
        {
            Regex formato = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");
            if (!formato.IsMatch(caja.Text))
            {
                error.SetError(caja, mensaje);
                caja.Focus();
                return true;
            }
            else
            {
                error.Clear();
                return false;
            }
        }
    }
}
