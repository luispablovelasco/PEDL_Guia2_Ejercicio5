using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEDL_Guia2_Ejercicio5
{
    public partial class Form1 : Form
    {
        Random random = new Random(); //Creamos un objeto random
        //Utilizamos una lista de C# con elemnetos de tipo random
        //Los valores de la lista ya estarán predeterminados

        List<string> iconos = new List<string>()
        {
            "!","!","N","N",",",",","k","k","b","b","v","v","W","W","z","z"
        };

        //primer label al que se le ha dado click
        Label primerclick = null;
        //Segundo label al que se ha dado click
        Label segundoclick = null;

        //Metodo para asignar iconos a los label
        private void Asignar()
        {
            //Realiza esta accion para cada label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int numrandom = random.Next(iconos.Count);
                    iconLabel.Text = iconos[numrandom];
                    iconos.RemoveAt(numrandom);
                }
                iconLabel.ForeColor = iconLabel.BackColor; //Ocultamos los iconos
            }
        }

       private void VerificaGana()
        {

        }
        public Form1()
        {
            InitializeComponent();
            Asignar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); //Detenemos el timer
            primerclick.ForeColor = primerclick.BackColor; //Color de fondo click 1
            segundoclick.ForeColor = segundoclick.BackColor; //Color de fondo click 2
            primerclick = null; //Retorna el primer click a null
            segundoclick = null; //Retorna el segundo click a null
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null) 
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //Si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //Registra si el label ha sido seleccionado
            //Si ese label en concreto ha sido seleccionado (No está nulo)

            if (clickedLabel != null)
            {
                //El Forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //Llama la metodo de Verificar Ganador
                if (primerclick == null)
                {
                    //Si no ha habido un click antes, se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //El colo de ForeColor en negro
                    primerclick.ForeColor = Color.Black;
                    return;

                }

                //Si ya hay algo en primer click entonces será el segundo 
                segundoclick = clickedLabel;
                //Color en negro
                segundoclick.ForeColor = Color.Black;
                //Elemento clikeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    return;
                }
                timer1.Start();
            }
        }
    }
}
