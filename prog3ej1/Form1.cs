using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog3ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tb_1.MaxLength=25;
            tb_1.CharacterCasing = CharacterCasing.Upper;

            tb_2.Multiline = true;
            tb_2.ScrollBars = ScrollBars.Vertical;



        }
        
        private void tb_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnColorRed_Click(object sender, EventArgs e)
        {
            if (tb_1.BackColor == Color.White)
            {
                tb_1.BackColor = Color.Red;
                tb_1.ForeColor = Color.White;
            }
            else
            {
                tb_1.BackColor = Color.White;
                tb_1.BackColor = Color.Red;
                //tb_1.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void tb_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tb_2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("tiene " + tb_2.Text.Length + " caracateres");
        }
    }
}
