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
            try
            {
                double a = Convert.ToDouble(tbA.Text);
                double b = Convert.ToDouble(tbB.Text);
                double c = Convert.ToDouble(tbC.Text);
                double p = 1.0 / 2.0 * (a + b + c);
                double areaTringle = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                tbRezult.Text = areaTringle.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show($"Pan napisał błęd.\n{ex.Message}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(tbRadius.Text);
                double areaCircle = Math.Sqrt(Math.Pow(r, 2) * Math.PI);
                tbCircle.Text = areaCircle.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show($"Pan napisał błęd.\n{ex.Message}");
            }
        }
    }
}
