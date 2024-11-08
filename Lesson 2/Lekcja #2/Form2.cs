using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja__2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function culcs area of circle
        /// </summary>
        /// <param name="r">promień</param>
        /// <returns></returns>
        public double culcAreaOfCircle(double r)
        {
            return Math.Sqrt(Math.Pow(r, 2) * Math.PI);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(tbRadius.Text);
                tbCircle.Text = culcAreaOfCircle(r).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pan napisał błęd.\n{ex.Message}");
            }
        }

        /// <summary>
        /// Culcs the area of tringle
        /// </summary>
        /// <param name="a">Pierwsza strona trójkąta</param>
        /// <param name="b">Druga strona trójkąta</param>
        /// <param name="c">Trzecia strona trójkąta</param>
        /// <returns></returns>
        public double culcAreaOfTringle(double a, double b, double c)
        {
            double p = 1.0 / 2.0 * (a + b + c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public string culcAreaOfTringle(string a, string b, string c)
        {
            double aa = Convert.ToDouble(tbA.Text);
            double bb = Convert.ToDouble(tbB.Text);
            double cc = Convert.ToDouble(tbC.Text);
            double p = 1.0 / 2.0 * (aa + bb + cc);
            double areaTringle = Math.Sqrt(p * (p - aa) * (p - bb) * (p - cc));

            return areaTringle.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*double a = Convert.ToDouble(tbA.Text);
                double b = Convert.ToDouble(tbB.Text);
                double c = Convert.ToDouble(tbC.Text);
                tbRezult.Text = culcAreaOfTringle(a, b, c).ToString();*/

                tbRezult.Text = culcAreaOfTringle(tbA.Text, tbB.Text, tbC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pan napisał błęd.\n{ex.Message}");
            }
        }
    }
}
