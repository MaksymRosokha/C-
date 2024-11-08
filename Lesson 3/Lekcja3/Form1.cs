using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double calcFactorial(double x)
        {
            double result = 1;
            for (double i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }

        public double calcMySin(double x)
        {
            double precision = 10;
            double result = 0;

            for (double i = 0; i < precision; i++)
            {
                result = result + (Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1)) / calcFactorial(2 * i + 1);
            }

            return result;
        }

        public double obiczPoleTrapezu(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }

        public double calcSinIntegral(double lowerLimit, double upperLimit, double height)
        {
            double result = 0;
            for (double i = lowerLimit; i <= upperLimit; i += height)
            {
                result += obiczPoleTrapezu(Math.Sin(i), Math.Sin(i + height), height);
            }
            return result;
        }

        public double calcCosIntegral(double lowerLimit, double upperLimit, double height)
        {
            double result = 0;
            for (double i = lowerLimit; i <= upperLimit; i += height)
            {
                result += obiczPoleTrapezu(Math.Cos(i), Math.Cos(i + height), height);
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lowerLimit = Convert.ToDouble(textBox1.Text);
            double upperLimit = Convert.ToDouble(textBox2.Text);

            //MessageBox.Show(Math.Round(calcHiperSinIntegral(lowerLimit, upperLimit, 0.001)).ToString());

            //MessageBox.Show(calcMyHiberSin(Math.PI).ToString());
            //MessageBox.Show(Math.Sinh(Math.PI).ToString());

            double area = calcSinIntegral(lowerLimit, upperLimit, 0.001) - calcCosIntegral(lowerLimit, upperLimit, 0.001);
            MessageBox.Show(area.ToString());
        }




        public double calcMyHiberSin(double x)
        {
            return (Math.Pow(Math.E, x) - Math.Pow(Math.E, -x)) / 2;
        }

        public double calcHiperSinIntegral(double lowerLimit, double upperLimit, double height)
        {
            double result = 0;
            for (double i = lowerLimit; i <= upperLimit; i += height)
            {
                result += obiczPoleTrapezu(calcMyHiberSin(i), calcMyHiberSin(i + height), height);
            }
            return result;
        }
    }
}
