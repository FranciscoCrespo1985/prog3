using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpPdf_
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            tbApellido.MaxLength = 25;
            tbNombre.MaxLength = 25;
            tbDireccion.MaxLength = 50;
            tbEdad.MaxLength = 3;

            tbApellido.CharacterCasing = CharacterCasing.Upper;
            tbNombre.CharacterCasing = CharacterCasing.Upper;
            tbDireccion.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim().Length == 0)
            {
                tbNombre.BackColor = Color.Red;
            }
            else
            {
                tbNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            }
            if (tbApellido.Text.Trim().Length == 0)
            {
                tbApellido.BackColor = Color.Red;
            }
            else
            {
                tbApellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            }
            if (tbDireccion.Text.Trim().Length == 0)
            {
                tbDireccion.BackColor = Color.Red;
            }
            else
            {
                tbDireccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            }
            if (tbEdad.Text.Trim().Length == 0)
            {
                tbEdad.BackColor = Color.Red;
            }
            else
            {
                tbEdad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            }

        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }          
}
