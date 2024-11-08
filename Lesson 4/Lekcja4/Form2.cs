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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public long calcFactorial(int ilosc)
        {
            if (ilosc == 0)
            {
                return 1;
            }
            else if (ilosc < 0)
            {
                throw new Exception("Finger can not be lass than 0");
            }

            return ilosc * calcFactorial(ilosc - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ilosc = Convert.ToInt32(textBox1.Text);
                long res = calcFactorial(ilosc);
                textBox2.Text = res.ToString();
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

           
        }
    }
}
