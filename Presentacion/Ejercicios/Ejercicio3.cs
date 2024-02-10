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
    public partial class Ejercicio3 : UserControl
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        double peso;
        double altura;
        double IMC;
        public string titulo3;

        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            AsignarDatos();
            calcularIMC();
            IndicarEstado();
        }

        private void AsignarDatos()
        {
            
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);
        }

        private void calcularIMC()
        {
            IMC = (peso / (Math.Pow(altura, 2)));
            
            txtIMC.Text = IMC.ToString("N2");
        }

        private void IndicarEstado()
        {
            if(IMC < 18.5)
            {
                lblresultadoIMC.ForeColor = Color.LightBlue;
                lblresultadoIMC.Text = "Usted esta por debajo de su peso";
            }
             if(IMC >= 18.5 && IMC <= 24.9)
            {
                lblresultadoIMC.ForeColor = Color.DarkGreen;
                lblresultadoIMC.Text = "Usted esta saludable.";
            }
             if(IMC >= 25 && IMC <= 29.5)
            {
                lblresultadoIMC.ForeColor = Color.Yellow;
                lblresultadoIMC.Text = "Usted tiene sobrepeso.";

            }
             if (IMC > 30)
            {
                lblresultadoIMC.ForeColor = Color.Red; 
                lblresultadoIMC.Text = "Usted tiene obesidad.";
            }
             
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            lblEjercicio3.Text = titulo3;
        }

        
    }
}
