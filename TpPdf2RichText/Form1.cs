using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpPdf2RichText
{
    public partial class frmRichTextBox : Form
    {
        public frmRichTextBox()
        {
            InitializeComponent();
        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            Font viejaFuente;
            Font nuevaFuente;

            //Obtengo la fuente actual
            viejaFuente = rtxteditor.SelectionFont;

            if (viejaFuente.Bold) {
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Bold);
            }
            else {
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Bold);
            }


            rtxteditor.SelectionFont = nuevaFuente;

            rtxteditor.Focus();
        }








        public void AplicarTamanioText(string textsize) {

            float nuevoTam = Convert.ToSingle(textsize);

            FontFamily actualFuenteFamily;
            Font nuevaFuente;
            // de la seleccion actual del richtextbox obtengo la familia
            actualFuenteFamily = rtxteditor.SelectionFont.FontFamily;

            nuevaFuente = new Font(actualFuenteFamily, nuevoTam);
            rtxteditor.SelectionFont = nuevaFuente;

        }





        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            Font viejaFuente;
            Font nuevaFuente;

            //Obtengo la fuente actual
            viejaFuente = rtxteditor.SelectionFont;

            if (viejaFuente.Bold)
            {
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Underline);
            }
            else
            {
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Underline);
            }


            rtxteditor.SelectionFont = nuevaFuente;

            rtxteditor.Focus();
        }

        private void btnCursiva_Click(object sender, EventArgs e)
        {
            Font viejaFuente;
            Font nuevaFuente;

            //Obtengo la fuente actual
            viejaFuente = rtxteditor.SelectionFont;

            if (viejaFuente.Bold)
            {
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Italic);
            }
            else
            {
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Italic);
            }


            rtxteditor.SelectionFont = nuevaFuente;

            rtxteditor.Focus();
        }

        private void btnCentrado_Click(object sender, EventArgs e)
        {
            if (rtxteditor.SelectionAlignment == HorizontalAlignment.Center)
            {
                rtxteditor.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                rtxteditor.SelectionAlignment = HorizontalAlignment.Center;
            }

            rtxteditor.Focus();
        }

        private void txtTamanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valido si se preciono una tecla que no es un numero para que solo se puedan ingresar nuemeros


            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
                e.Handled = true;
            else if(e.KeyChar ==13){
                if(txtTamanio.Text.Length > 0)  AplicarTamanioText(txtTamanio.Text); 

                e.Handled = true;
                rtxteditor.Focus();
            }
        }

        private void txtTamanio_Validated(object sender, EventArgs e)
        {
            //El Evento Validated ocurre despues de la validacion (Validating)
            //Llama al metodo aplicartamañotext y como parametro pasa,
            //La propiedad text del objeto sender(objeto que disparo el vento)
            //Del cual se hace un cast del tipo Textobox
            // es lo mismo que pasarle un txtTamanio.text
            AplicarTamanioText(((TextBox)sender).Text);
            rtxteditor.Focus();

        }

        private void rtxteditor_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                rtxteditor.LoadFile("Test.rtf");
            }
            catch (System.IO.FileNotFoundException) {
                MessageBox.Show("Nose puedo encontrar el archivo");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                rtxteditor.SaveFile("Test.rtf");
            }
            catch (System.Exception err) {
                MessageBox.Show(err.Message);
            }
        }
    }
}
