using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lekcja__2
{
    public partial class ZadanieDomowe1 : Form
    {
        public ZadanieDomowe1()
        {
            InitializeComponent();
        }

        public double calcSin(double x)
        {
            int precision = 1000;
            double result = 0;
            double sum = 0;

            for (int i = 1; i <= precision; i++)
            {
                sum += (Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i - 1)) / calcFactorial(2 * i - 1);
            }
            result = sum;

            return result;
        }

        public double calcCos(double x)
        {
            int precision = 1000;
            double result = 0;
            double sum = 0;

            for (int i = 1; i <= precision; i++)
            {
                sum += (Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i)) / calcFactorial(2 * i);
            }
            result = sum;

            return result;
        }

        public double calcFactorial(double x) ///////////////////
        {
            double sum = 1;
            for (int i = 1; i <= x; i++)
            {
                sum *= i;
            }
            return sum;
        }

        public double transferDeegresToRadians(double x)
        {
            return x * Math.PI / 180;
        }

        double calcIntegralArea(double lowerLimit, double upperLimit)
        {
            int precision = 10;
            double[] i = new double[precision];
            double d = (upperLimit - lowerLimit) / precision;
            Parallel.For(0, precision, (int k) =>
            {
                i[k] = calcSin(transferDeegresToRadians(k)); //here's need to create the function that calculates definite integral
            });
            return i.Sum();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double lowerLimit = Convert.ToDouble(tbLowerLimit.Text);
                double upperLimit = Convert.ToDouble(tbUpperLimit.Text);
                tbResult.Text = Convert.ToString(calcIntegralArea(lowerLimit, upperLimit));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
