using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CursoClase1Csharp.Ejercicios
{

    public partial class Ejercicio6 : UserControl
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }
        string operacion;
        double numero1;
        double numero2;
        double resultado;
        bool reiniciar = false;
        bool punto = true;


        private void Ejercicio6_Load(object sender, EventArgs e)
        {
            agregarBotones();
        }

        private void agregarBotones()
        {
            char[] numeros;
            numeros = "9876543210,".ToCharArray();

            foreach(char numero in numeros)
            {
                Button btnNumero = new Button();
                btnNumero.Text = numero.ToString();
                panelnumerico.Controls.Add(btnNumero);
                btnNumero.Size = new Size(55, 55);
                btnNumero.BackgroundImage = Properties.Resources.circulo2;
                btnNumero.BackgroundImageLayout = ImageLayout.Stretch;
                btnNumero.FlatStyle = FlatStyle.Flat;
                btnNumero.ForeColor = Color.White;
                btnNumero.BackColor = Color.Transparent;
                btnNumero.FlatAppearance.BorderSize = 0;
                btnNumero.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnNumero.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btnNumero.Click += BtnNumero_Click;

            }
        }

        private void BtnNumero_Click(object sender, EventArgs e)
        {
            ReiniciarProceso();
            string numero = ((Button)sender).Text;
            
            if(numero == ",")
            {
                punto = true;
                if (txtPantalla.Text.Contains(","))
                {
                    punto = false;
                }
                if(punto == true)
                {
                   if(txtPantalla.Text != "")
                    {
                        txtPantalla.Text += ",";
                    }
                }
                
            }
            else
            {
                if (txtPantalla.Text == "0")
                {
                     txtPantalla.Clear();
                }

                txtPantalla.Text += numero;

                
            }

           
        }

        private void ReiniciarProceso()
        {
            if(reiniciar == true)
            {
                txtPantalla.Text = "0";
                reiniciar = false;
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operacion = btndiv.Text;
            definirOperacion();
            
        }

        private void definirOperacion()
        {
            asignarDatos();
            
            if(numero2 > 0)
            {
                lblNro1.Text = txtPantalla.Text;
                lblOperacion.Text = operacion;
                txtPantalla.Text = "0";
                lblOperacion.Visible = true;
                lblNro1.Visible = true;
            }
        }

        private void asignarDatos()
        {
            numero1 = Convert.ToDouble(lblNro1.Text);
            numero2 = Convert.ToDouble(txtPantalla.Text);
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            Calcular();
            limpiar();
            lblOperacion.Visible = false;
            lblNro1.Visible = false;
          
        }

        private void Calcular()
        {
            asignarDatos();
            
            if(lblOperacion.Text == btndiv.Text)
            {
                dividir();
            }
            else if(lblOperacion.Text == btnmult.Text)
            {
                multiplicar();
            }
            else if(lblOperacion.Text == btnresta.Text)
            {
                restar();
            }
            else if(lblOperacion.Text == btnsuma.Text)
            {
                sumar();
            }
            else if(lblOperacion.Text == btnporcentaje.Text)
            {
                calcularporcentaje();
            }
            
            
        }
        private void calcularporcentaje()
        {
            resultado = (numero1 * numero2) / 100;
            txtPantalla.Text = resultado.ToString();
        }

        private void dividir()
        {
            resultado = numero1 / numero2;
            txtPantalla.Text = resultado.ToString();
            
        }

        private void multiplicar()
        {
            resultado = numero1 * numero2;
            txtPantalla.Text = resultado.ToString();

        }

        private void restar()
        {
            resultado = numero1 - numero2;
            txtPantalla.Text = resultado.ToString();
        }

        private void sumar()
        {
            resultado = numero1 + numero2;
            txtPantalla.Text = resultado.ToString();
        }

        private void limpiar()
        {
            reiniciar = true;
            lblOperacion.Text = "0";
            lblNro1.Text = "0";
            
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            operacion = btnmult.Text;
            definirOperacion();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = btnresta.Text;
            definirOperacion();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = btnsuma.Text;
            definirOperacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operacion = btnporcentaje.Text;
            definirOperacion();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            txtPantalla.Text = "0";
            lblOperacion.Text = "0";
            lblNro1.Text = "0"; 
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPantalla.Text);
        }

       




        


    }
}
