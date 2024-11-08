using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lekcja3
{
    public partial class ZadanieDomowe1 : Form
    {
        public ZadanieDomowe1()
        {
            InitializeComponent();
        }

        public long CalcFactorial(int number)
        {
            long factor = 1;
            for (int i = 1; i <= number; i++)
            {
                factor *= i;
            }
            return factor;
        }

        public long CalcCatalanNumber (int number)
        {
            return CalcFactorial(number * 2) / (CalcFactorial(number + 1) * CalcFactorial(number));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(tbIndex.Text);
                if (index >= 0)
                {
                    for (int i = 0; i < index; i++)
                    {
                        tbResult.Text += CalcCatalanNumber(i).ToString() + "; ";
                    }
                }
                else
                {
                    MessageBox.Show("Index can not be less than 0");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("The index must be an integer");
            }
            
        }
    }
}
