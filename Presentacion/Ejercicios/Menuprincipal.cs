using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoClase1Csharp.Ejercicios;

namespace CursoClase1Csharp.Ejercicios
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            Ejercicio1();
        }

        private void Ejercicio1()
        {
            //Esto es para que se limpie la pantalla cuando queres iniciar otro ejercicio
            panelVisor.Controls.Clear();
            Ejercicio1 ctl = new Ejercicio1();
            ctl.titulo = btnE1.Text;
           ctl.Dock = DockStyle.Fill;  
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            Ejercicio2();
        }

        private void Ejercicio2()
        {
            panelVisor.Controls.Clear();
            Ejercicio2 ctl2 = new Ejercicio2(); 
            ctl2.titulo2 = btnE2.Text;
            ctl2.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl2);
            ctl2.Show();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            Ejercicio3();
        }

        private void Ejercicio3()
        {
            panelVisor.Controls.Clear();
            Ejercicio3 ctl3 = new Ejercicio3();
            ctl3.titulo3 = btnE3.Text;
            ctl3.Dock = DockStyle.Fill; 
            panelVisor.Controls.Add(ctl3);
            ctl3 .Show();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            Ejercicio4();
        }

        private void Ejercicio4()
        {
            panelVisor.Controls.Clear();
            Ejercicio4 ctl4 = new Ejercicio4();
            
            ctl4.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl4);
            ctl4.Show();
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            Ejercicio5();
        }

        private void Ejercicio5()
        {
            panelVisor.Controls.Clear();
            Ejercicio5 ctl5 = new Ejercicio5();
            ctl5.titulo = btnE5 .Text;
            ctl5.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl5);
            ctl5.Show();
        }

        private void Ejercicio6()
        {
            panelVisor.Controls.Clear();
            Ejercicio6 ctl6 = new Ejercicio6();
            ctl6.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl6);
            ctl6.Show();
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            Ejercicio6();
        }

    }
}
