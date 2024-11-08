using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja3
{
    public partial class ZadanieDomowe2 : Form
    {
        public ZadanieDomowe2()
        {
            InitializeComponent();
        }

        public bool IsImproper(double numerator, double denominator)
        {
            if (denominator >= numerator)
            {
                return true;
            }
            return false;
        }

        public List<string> SortSequence(Dictionary<string, double> collection)
        {
            List<string> sortedSequence = new List<string>();
            var tempList = collection.ToList();
            tempList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            tempList.ForEach(item =>
            {
                sortedSequence.Add(item.Key);
            });
            return sortedSequence;
        }

        public List<string> GetFareySequence(int number)
        {
            Dictionary<string, double> sequence = new Dictionary<string, double>();
            sequence.Add("1/1", 1);

            for (double numerator = 0; numerator <= number; numerator++)
            {
                for (double denominator = 1; denominator <= number; denominator++)
                {
                    if (IsImproper(numerator, denominator))
                    {
                        for (int i = 0; i < sequence.Count; i++)
                        {
                            if (!sequence.ContainsValue(numerator / denominator))
                            {
                                sequence.Add(numerator + "/" + denominator, numerator / denominator);
                                break;
                            }
                        }
                    }
                }
            }

            return SortSequence(sequence);
        }

        private void btnGetSequence_Click(object sender, EventArgs e)
        {
            int number = 0;
            try
            {
                number = Convert.ToInt32(tbNumber.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            rtbResult.Text = "";
            foreach (string element in GetFareySequence(number))
            {
                rtbResult.Text +=  element + "; " ;
            }
        }
    }
}
