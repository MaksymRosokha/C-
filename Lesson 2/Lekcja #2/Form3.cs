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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public double obiczPoleTrapezu(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double h = Convert.ToDouble(tbH.Text);
            tbRezult.Text = obiczPoleTrapezu(a, b, h).ToString();
        }
    }
}
