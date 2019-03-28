using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpPdf2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
        }


        private void ValidarOk() {

            btnOk.Enabled = (txtNombre.BackColor != Color.Red);
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Trim().Length == 0)
            {
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            ValidarOk();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String salida;

            salida = "Nombre: " + txtNombre.Text + "\r\n";
            salida += "Ocupacion: " + (string)(cbxProgramer.Checked ? "Programador" : "No es Programador")+"\r\n";
            salida += "Sexo: " + (string)(rBtnHombre.Checked ? "Hombre" : "Mujer") + "\r\n";
            txtSalida.Text = salida;
        }
    }


}
