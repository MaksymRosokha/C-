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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string calcFibon(int index)
        {
            string result = "";

            int[] fib = new int[index + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= index; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            for (int i = 0; i <= index; i++)
            {
                result += fib[i] + "; ";
            }

            return result;
        }

        public long calcFibonRec(int index)
        {
            if (index == 0)
            {
                return 0;
            }
            if (index == 1)
            {
                return 1;
            } else
            {
                return calcFibonRec(index - 1) + calcFibonRec(index - 2);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(textBox1.Text);
                if (index < 0)
                {
                    throw new Exception("Finger can not be lass than 0");
                }

                textBox2.Text = calcFibonRec(index).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
