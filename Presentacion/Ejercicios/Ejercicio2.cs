using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoClase1Csharp.Ejercicios
{
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        double areaCirculo;
        double radioCirculo;
        double longitudCirculo;
        double resultadoarea;
        double resultadoradio;
        double resultadolong;
        public string titulo2;
        double PI = 3.1416;

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            AsignarDatos();
            CalcularCirculo();
        }

        private void AsignarDatos()
        {
            areaCirculo =Convert.ToDouble(txtarea.Text);
            radioCirculo = Convert.ToDouble(txtradio.Text);
            longitudCirculo = Convert.ToDouble(txtlong.Text);

        }

        private void CalcularCirculo()
        {
            resultadoradio = Math.Sqrt(areaCirculo / PI);
            labelrestradio.Text = resultadoradio.ToString("N2");
            resultadoarea = PI * (Math.Pow(radioCirculo, 2));
            resultadolong = 2 * PI * radioCirculo;
            lblresultadolong.Text = resultadolong.ToString("N2");
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            lblEjercicio2.Text = titulo2;
        }
    }
}
