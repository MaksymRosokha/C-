using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja7
{
    public partial class ZadanieDomowe : Form
    {
        public ZadanieDomowe()
        {
            InitializeComponent();
        }

        public double[,] MultiplyMatrix(double[,] matrixA, double[,] matrixB)
        {
            double[,] multipliedMartix = new double[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int r = 0; r < matrixA.GetLength(1); r++)
                    {
                        multipliedMartix[i, j] += matrixA[i, r] * matrixB[r, j];
                    }
                }
            }

            return multipliedMartix;
        }

        public double[,] MultiplyMatrixWithThreads(double[,] matrixA, double[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);

            double[,] multipliedMatrix = new double[rowsA, colsB];
            Thread[] threads = new Thread[Environment.ProcessorCount];

            for (int core = 0; core < threads.Length; core++)
            {
                threads[core] = new Thread((object obj) =>
                {
                    int threadIndex = (int)obj;
                    int startRow = (rowsA / threads.Length) * threadIndex;
                    int endRow = (threadIndex == threads.Length - 1) ? rowsA : (rowsA / threads.Length) * (threadIndex + 1);

                    for (int i = startRow; i < endRow; i++)
                    {
                        for (int j = 0; j < colsB; j++)
                        {
                            for (int r = 0; r < colsA; r++)
                            {
                                multipliedMatrix[i, j] += matrixA[i, r] * matrixB[r, j];
                            }
                        }
                    }
                });
                threads[core].Start(core);
            }

            for (int c = 0; c < threads.Length; c++)
            {
                threads[c].Join();
            }

            return multipliedMatrix;
        }

        public void printMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public double[,] FillInArray(double[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-1000, 1000);
                }
            }

            return array;
        }

        private void ZadanieDomowe_Load(object sender, EventArgs e)
        {
            double[,] A = new double[700, 500];
            double[,] B = new double[500, 700];
            DateTime timer;
            FillInArray(A);
            FillInArray(B);

            timer = DateTime.Now;
            MultiplyMatrix(A, B);
            Console.WriteLine("Time without using threads: " + (DateTime.Now - timer).TotalSeconds);

            timer = DateTime.Now;
            MultiplyMatrixWithThreads(A, B);
            Console.WriteLine("Time with using threads: " + (DateTime.Now - timer).TotalSeconds);
        }

    }
}
