using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public long[,] MultiplyMatrix(long[,] a, long[,] b)
        {
            long[,] multipliedMatrix = new long[a.GetLength(0), b.GetLength(1)];
            //long[,] tempMatrix = new long[3,2];


            //for (int i = 0; i < multipliedMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < multipliedMatrix.GetLength(1); j++)
            //    {
            //        long sum = 0;
            //        for (int n = 0; n < a.GetLength(1); n++)
            //        {
            //            for (int m = 0; m < b.GetLength(0); m++)
            //            {
            //                sum += a[n, m] * b[m, n];
            //            }
            //        }


            //        multipliedMatrix[i, j] = sum;
            //    }
            //}



            return multipliedMatrix;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            long[,] a = { { 1, 0, 2 }, { -1, 3, 1 } };
            long[,] b = { { 3 }, { 2 }, { 1 } };

            //a = FillInArray(a);
            //b = FillInArray(b);

            richTextBox1.Text = printArray(a);
            richTextBox2.Text = printArray(b);
            richTextBox3.Text = printArray(MultiplyMatrix(a, b));
        }

        public long[,] FillInArray(long[,] arr)
        {
            Random random = new Random();

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(0, 100);
                }
            }

            return arr;
        }

        public string printArray(long[,] arr)
        {
            string text = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    text += arr[i, j].ToString() + "   ";
                }
                text += "\n";
            }
            return text;
        }
    }
}
