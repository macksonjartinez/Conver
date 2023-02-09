using Microsoft.VisualBasic;

namespace Conver
{
    public partial class Conver : Form
    {
        public Conver()
        {
            InitializeComponent();
            //Vamos a poner valores por defecto para las temperaturas
            txtGradosC.Text = "0.00";
            txtGradosF.Text = "32.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void txtGradosC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(13))
            {
             
                //se pulsó la tecla Enter (Intro)
                e.Handled = true;
                //Llamamos a al metodo para convertir
                Conversion(sender);
            }
            else if(e.KeyChar == Convert.ToChar(8))
            {
                //se presionó el backspace
                e.Handled= false;
            }
            else if (e.KeyChar == '.')
            {
                TextBox objTextbox = (TextBox)sender;

                if(objTextbox.Text.IndexOf('.') != -1)
                {
                    //significa que encontró un punto
                    e.Handled = true;
                }
            }
            else if(e.KeyChar == '-' || e.KeyChar == '+')
            {
                TextBox objTextbox = (TextBox)sender;
                //Solo admitir los simbolos al inicio de la cadena
                if(objTextbox.SelectionLength == objTextbox.TextLength)
                {
                    //todo el texto está seleccionado, por tanto
                    e.Handled = false;
                }
                else if (objTextbox.TextLength != 0)
                {
                    e.Handled = true;
                }

            }
            else if(e.KeyChar < '0' || e.KeyChar > '9') 
            {
                //desechamos todos los caracteres que no son dígitos
                e.Handled = true;
            }
        }

        //Creacion del Metodo Conversion
        private void Conversion(object sender)
        {
            //Crear una variable de tipo Textbox
            TextBox objTexbox = (TextBox)sender;

            double grados; //variable auxiliar

            //Si se escribio en la caja de texto grados centigrados
            if(objTexbox == txtGradosC)
            {
                grados = Convert.ToDouble(txtGradosC.Text) * 9.0 / 5.0 + 32.0;
                txtGradosF.Text = string.Format("{0:F2}", grados);

            }
            //Si se esribió en la caja e texto grados fahrenheit
            if(objTexbox == txtGradosF)
            {
                grados = (Convert.ToDouble(txtGradosF.Text) - 32.0) * 5.0 / 9.0;
                txtGradosC.Text= string.Format("{0:F2}", grados);
            }
        }
    }
}