using System;
using System.Threading;
using System.Windows.Forms;

namespace Lekcja8
{
    public partial class Form1 : Form
    {
        /*
         * Napisać program obliczający całkę oznaczoną z funkcji sinh(X) 
         * w zadanym przez użytkownika przedziale całkowania metodą Monte Carlo. 
         * Obliczenia zrównoleglić. Funkcja obliczająca całkę powinna przyjmować 
         * wszystkie najważniejsze parametry potrzebne do obliczeń.
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lowerLimit = 0;
            double upperLimit = 0;
            int amountOfPoints = 50000000;
            DateTime timer;
            rtbResult.Text = "";

            try
            {
                lowerLimit = Convert.ToDouble(textBox1.Text);
                upperLimit = Convert.ToDouble(textBox2.Text);
                if (lowerLimit > upperLimit)
                {
                    throw new Exception("\"od\" musi byc mniejsze niż \"do\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            timer = DateTime.Now;
            rtbResult.Text += "Integral without optimization: ";
            rtbResult.Text += calcSinHipIntegral(lowerLimit, upperLimit, amountOfPoints) + "\n";
            rtbResult.Text += "Time: " + (DateTime.Now - timer).TotalSeconds + "\n\n";

            timer = DateTime.Now;
            rtbResult.Text += "Integral with optimization: ";
            rtbResult.Text += calcSinHipIntegral(lowerLimit, upperLimit, amountOfPoints, 8) + "\n";
            rtbResult.Text += "Time: " + (DateTime.Now - timer).TotalSeconds;
        }


        public double calcSinHipIntegral(double lowerLimit, double upperLimit, int amountOfPoints)
        {
            Random rand = new Random();
            int pointsUnderGraph = 0;
            double maxY = calcMySinH(upperLimit);
            double area;

            for (int i = 0; i < amountOfPoints; i++)
            {
                double x = lowerLimit + (upperLimit - lowerLimit) * rand.NextDouble();
                double y = rand.NextDouble() * maxY;

                if (y <= calcMySinH(x))
                {
                    pointsUnderGraph++;
                }
            }

            area = (upperLimit - lowerLimit) * maxY * ((double)pointsUnderGraph / amountOfPoints);
            return area;
        }

        public double calcSinHipIntegral(double lowerLimit, double upperLimit, int amountOfPoints, int countOfThreads)
        {
            int pointsUnderGraph = 0;
            double maxY = calcMySinH(upperLimit);
            double area;
            object lockObj = new object();
            Thread[] threads = new Thread[countOfThreads];

            for (int i = 0; i < countOfThreads; i++)
            {
                threads[i] = new Thread(() =>
                {
                    Random rand = new Random();
                    int localPointsUnderGraph = 0;
                    for (int j = 0; j < amountOfPoints / countOfThreads; j++)
                    {
                        double x = lowerLimit + (upperLimit - lowerLimit) * rand.NextDouble();
                        double y = rand.NextDouble() * maxY;

                        if (y <= calcMySinH(x))
                        {
                            localPointsUnderGraph++;
                        }
                    }

                    lock (lockObj)
                    {
                        pointsUnderGraph += localPointsUnderGraph;
                    }
                });

                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            area = (upperLimit - lowerLimit) * maxY * ((double)pointsUnderGraph / amountOfPoints);
            return area;
        }

        private double calcMySinH(double x)
        {
            return ((Math.Pow(Math.E, x) - Math.Pow(Math.E, -1 * x)) / 2);
        }

    }
}
