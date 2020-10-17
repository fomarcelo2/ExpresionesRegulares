using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioValidaciones
{
    public partial class Form1 : Form
    {
        validaciones validar = new validaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validar.Vacio(txtNombre, errorM, "El nombre no puede estar vacío"))
                if(validar.TipoTexto(txtNombre, errorM, "Debe de ingresar texto"))
                    if (!validar.Vacio(txtCodigo, errorM, "El código no puede estar vacío"))
                        if(validar.TipoNumero(txtCodigo, errorM, "Debe de ingresar numeros"))
                             if (!validar.Vacio(txtCorreo, errorM, "El correo no puede estar vacío"))

                             {
                                  lblSalida.Text = "Todos los campos estan diligenciados";
                                  LimpiarCajas();
                             }

        }

        private void LimpiarCajas()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtCorreo.Clear();
        }
    }
}
