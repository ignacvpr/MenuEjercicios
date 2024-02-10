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
    public partial class Ejercicio4 : UserControl
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double total = 0;
            
            if(rbTalleS.Checked == true)
            {
                total += 50;
                txtboxTalle.Font = new Font("Segoe Script", txtboxTalle.Font.Size);
                txtboxTalle.Font = new Font("Segoe Script", 14);
                txtboxTalle.Text = "S";
                txtBoxTotal.Font = new Font("Segoe Script", txtboxTalle.Font.Size);
                txtBoxTotal.Font = new Font("Segoe Script", 14);
                txtBoxTotal.Text ="$" + total.ToString();
            }

            if(rbBlanco.Checked == true)
            { 
                txtboxcolor.Font = new Font("Segoe Script", txtboxcolor.Font.Size);
                txtboxcolor.Font = new Font("Segoe Script", 14);
                txtboxcolor.Text = "Blanco";
            }

            if (rbNegro.Checked == true)
            {
                txtboxcolor.Font = new Font("Segoe Script", txtboxcolor.Font.Size);
                txtboxcolor.Font = new Font("Segoe Script", 14);
                txtboxcolor.Text = "Negro";
            }

            if (rbTalleM.Checked == true)
            {
                total += 100;
                txtboxTalle.Font = new Font("Segoe Script", txtboxTalle.Font.Size);
                txtboxTalle.Font = new Font("Segoe Script", 14);
                txtboxTalle.Text = "M";
                txtBoxTotal.Font = new Font("Segoe Script", txtboxTalle.Font.Size);
                txtBoxTotal.Font = new Font("Segoe Script", 14);
                txtBoxTotal.Text = "$" + total.ToString();
            }

            if (rbTalleL.Checked == true)
            {
                total += 150;
                txtboxTalle.Font = new Font("Segoe Script", txtboxTalle.Font.Size);
                txtboxTalle.Font = new Font("Segoe Script", 14);
                txtboxTalle.Text = "L";
                txtBoxTotal.Font = new Font("Segoe Script", txtboxTalle.Font.Size);
                txtBoxTotal.Font = new Font("Segoe Script", 14);
                txtBoxTotal.Text = "$" + total.ToString();
            }
        }
    }
}
