using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Operaciones;

namespace Componente_Calculadora
{
    public partial class Calculadora : UserControl
    {

        double primero;
        double segundo;
        double resultado;
        string operacion;


        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            switch (operacion)
            {
                case "+":

                    double suma = Operaciones.suma(primero, segundo);
                    pantalla.Text = suma.ToString();
                    break;

                case "-":

                    double resta = Operaciones.resta(primero, segundo);
                    pantalla.Text = resta.ToString();
                    break;

                case "*":

                    double multiplicacion = Operaciones.multiplicacion(primero, segundo);
                    pantalla.Text = multiplicacion.ToString();
                    break;

                case "/":
                    if (segundo != 0)
                    {
                        double division = Operaciones.division(primero, segundo);
                        pantalla.Text = division.ToString();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("No se puede realizar dividir entre 0");
                    }
                    break;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }
    }
}