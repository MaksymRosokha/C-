using System.Security.Cryptography;

namespace Kolokwium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sin = Convert.ToDouble(textBox1.Text);
                textBox2.Text = calcSin(sin).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public double calcSin(double x)
        {
            double precision = 100;
            double result = 0;

            for (double i = 0; i < precision; i++)
            {
                result = result + (Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1)) / calcFactorial(2 * i + 1);
            }

            return result;
        }

        public double calcFactorial(double x)
        {
            double sum = 1;
            for (int i = 1; i <= x; i++)
            {
                sum *= i;
            }
            return sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double lowerLimit = Convert.ToDouble(textBox5.Text);
                double upperLimit = Convert.ToDouble(textBox6.Text);
                double area = calcSinIntegral(lowerLimit, upperLimit, 0.001);

                textBox3.Text = area.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public double calcSinIntegral(double lowerLimit, double upperLimit, double height)
        {
            double result = 0;
            for (double i = lowerLimit; i <= upperLimit; i += height)
            {
                result += obiczPoleTrapezu(calcSin(i), calcSin(i + height), height);
            }
            return result;
        }

        Object obj = new Object();

        public double calcSinIntegralWithThreads(double lowerLimit, double upperLimit, double height)
        {
            Thread[] threads = new Thread[Environment.ProcessorCount];
            double area = 0;

            for (int core = 0; core < threads.Length; core++)
            {
                threads[core] = new Thread((object obj) =>
                {
                    int threadIndex = (int)obj;
                    double result = 0;
                    for (double i = lowerLimit; i <= upperLimit; i += height)
                    {
                        result += obiczPoleTrapezu(calcSin(i), calcSin(i + height), height);
                    }
                    lock (obj)
                    {
                        area = area + result;
                    }

                });
                threads[core].Start(core);

            }

            for (int c = 0; c < threads.Length; c++)
            {
                threads[c].Join();
            }

            return area;
        }

        public double obiczPoleTrapezu(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }
    }
}
