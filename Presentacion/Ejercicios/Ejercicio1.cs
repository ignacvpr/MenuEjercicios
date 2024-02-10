﻿using System;
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
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        double a;
        double b;
        double c;
        double resultado;
        public string titulo;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Asignardatos();
            Calcular();
        }

        private void Asignardatos()
        {
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);
        }

        private void Calcular()
        {
            resultado = ((c + 5.0) * (Math.Pow(b, 2.0) - 3 * a * c) * (Math.Pow(a, 2.0))) / (4.0 * a);
            lblresultado.Text = resultado.ToString();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            lblEjercicio1.Text = titulo;
        }

        
    }
}
