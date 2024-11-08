using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                MessageBox.Show($"Nr {i}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread th = new Thread(() =>
                {
                    MessageBox.Show($"Nr {i}");
                });
                th.IsBackground = true;
                th.Start();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() =>
            {
                double licznik = 0;
                while (true)
                {
                    licznik += 0.000001;
                }
            });
            th.IsBackground = true;
            th.Start();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parallel.For(0, 5, (int i) =>
            {
                MessageBox.Show($"Nr {i}");
            });
        }

        object obj = new object();

        private void button5_Click(object sender, EventArgs e)
        {
            double x = 0;

            Parallel.For(0, 2, (int i) =>
            {
                if (i == 0)
                {
                    lock (obj)
                    {
                        for (int c = 0; c < 100000; c++)
                        {
                            x = x + 0.0001;
                        }
                    }
                }
                else
                {
                    lock (obj)
                    {
                        for (int c = 0; c < 100000; c++)
                        {
                            x = x - 0.0001;
                        }
                    }
                }
            });


            //Thread th1 = new Thread(() =>
            //{
            //    for (int i = 0; i < 999; i++)
            //    {
            //        x++;
            //    }
            //});
            //th1.IsBackground = true;
            //th1.Start();

            //Thread th2 = new Thread(() =>
            //{
            //    for (int i = 0; i < 999; i++){
            //        x--;
            //    }
            //});
            //th2.IsBackground = true;
            //th2.Start();

            

            Console.WriteLine(x);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double[] x = {0,0};

            Parallel.For(0, 2, (int i) =>
            {
                if (i == 0)
                {

                    for (int c = 0; c < 100000; c++)
                    {
                        x[i] = x[i] + 0.0001;
                    }
                }
                else
                {
                    for (int c = 0; c < 100000; c++)
                    {
                        x[i] = x[i] - 0.0001;
                    }
                }
            });
            Console.WriteLine(x.Sum());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime t1 = DateTime.Now;

            Console.WriteLine(calcSinIntegral(1, 3, 0.00000001));
            Console.WriteLine("Czas obliczeń = " + (DateTime.Now - t1).TotalSeconds);

            t1 = DateTime.Now;
            Console.WriteLine(calcSinIntegral(1, 3, 0.00000001, 8));
            Console.WriteLine("Czas obliczeń = " + (DateTime.Now - t1).TotalSeconds);
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
        
        
        public double calcSinIntegral(double lowerLimit, double upperLimit, double height, int threads)
        {
            double d = (upperLimit - lowerLimit) / Convert.ToDouble(threads);
            double[] result = new double[threads];

            Parallel.For(0, threads, (int i) =>
            {
                result[i] = calcSinIntegral(lowerLimit +d * Convert.ToDouble(i), lowerLimit  + d * Convert.ToDouble(i) +d, height);
            });

            return result.Sum();
        }
    }
}
