using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoClase1Csharp.Ejercicios
{
    public partial class Ejercicio5 : UserControl
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        int numero1;
        int numero2;
        public string titulo;

        private void btnCalcularPar_Click(object sender, EventArgs e)
        {
            asignarValores();
            calcularPares();
        }

        private void asignarValores()
        {
            numero1 = Convert.ToInt32(txtNro1.Text);
            numero2 = Convert.ToInt32(txtNro2.Text);
        }

        private void calcularPares()
        {
            if (numero1 % 2 == 0 && numero2 % 2 == 0)
            {
                txtResultadoPar.Text = "Ambos numeros son pares";
            }


            else if (numero1 % 2 == 0)
            {
                txtResultadoPar.Text = "El numero 1 es par.";
            }
            else if (numero2 % 2 == 0)
            {
                txtResultadoPar.Text = "El numero 2 es par.";
            }
           
            else
            {
                txtResultadoPar.Text = "Ningun numero es par";
            }
        }

        private void Ejercicio5_Load(object sender, EventArgs e)
        {
            lblEjercicio5.Text = titulo;
        }
    }
}
