using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] FillInArray(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-100, 100);
                }
            }

            return array;
        }

        public void PrintArray(int[,] array)
        {
            string result = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result += array[i, j] + "   ";
                }
                result += " \n";
            }
            MessageBox.Show(result);
        }

        //public int[,] MultiplyArrays(int[,] a, int[,] b)
        //{
        //    int
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            int[,] a = new int[4,2];
            int[,] b = new int[2, 3];
            int[,] c = new int[4, 3];

            FillInArray(a);
            FillInArray(b);


            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    for (int r = 0; r < a.GetLength(1); r++) // a.GetLength(1) część wspólna
                    {
                        c[i, j] += a[i, r] * b[r, j];
                    }
                }
            }

            PrintArray(c);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] tab1 = { -1, -2, 0, 1, 2, 3};
            int[] tab2 = { 6, 3, 1, 0, -1, 3 };

            foreach (int i in tab1.Concat(tab2))
            {
                Console.WriteLine(i);
            }





            //foreach (var x in from w in tab1 where w < 0 select w) //linq
            //{
            //    Console.WriteLine(x);
            //}


            //foreach (var x in from w in tab1 where w < 0 orderby w select w)
            //{
            //    Console.WriteLine(x);
            //}

            //foreach (var x in from w in tab1 where w > 0 orderby w descending select w)
            //{
            //    Console.WriteLine(x);
            //}


            //Console.WriteLine(sum);

            //Console.WriteLine(tab1.Sum());

            //Console.WriteLine(tab1.Where((p) => p >= 0).Sum());

            //Console.WriteLine(tab1.Where((p) => (p % 2 == 0 && p >= 0)).Sum());

            //int min = 0;
            //int max = 0;
            //for (int i = 0;i < tab1.Length;i++)
            //{
            //    for(int j = 0; j< tab1.Length; j++)
            //    {
            //        if (min > tab1[j])
            //        {
            //            min = tab1[j];
            //        }
            //        if (max < tab1[j])
            //        {
            //            max = tab1[j];
            //        }
            //    }
            //}
            //foreach (int i in tab1)
            //{
            //    if (i != min && i != max)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //foreach (var i in from w in tab1 where w > tab1.Min() && w < tab1.Max() select w)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (var i in from w in tab1 select Math.Abs(w))
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(tab1.Where((x) => x >= 0).Average());

            //Console.WriteLine(tab1.Distinct().Count());
        }
    }
}
