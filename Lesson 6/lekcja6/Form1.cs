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

namespace lekcja6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Wyśwetlić statystykę występowania wyrazów  (bez różniania wiekości liter).
            string wyrazy = "Ala MA kota i Ala ma psa";
            string[] slowa = wyrazy.Split(' ');
            Console.WriteLine(wyrazy);
            
            foreach (string i in from w in slowa.Select(s => s.ToUpper()).Union(slowa.Select(s => s.ToUpper())) select w)
            {
                int amount = 0;
                foreach (string j in from w in slowa select w.ToUpper())
                {
                    if (i == j)
                    {
                        amount++;
                    }

                }
                Console.WriteLine(i + " => " + amount);
            }











            //oblicz();




            //int[] tablica_liczb = { -1, -2, 0, 1, 2, 3 };
            //string[] tablica_ciagow = { "6", "3", "1", "0", "-1", "3" };


            //lblResult.Text = Convert.ToString(tablica_ciagow.Select(w => Convert.ToInt32(w)).Where(w => w > 0).Sum());


            //foreach (int i in tablica_liczb.Intersect(tablica_ciagow.Select( w => Convert.ToInt32(w))))
            //{
            //    Console.Write(i + " | ");
            //}







            //int[] tab1 = { -1, -2, 0, 1, 2, 3 };
            //int[] tab2 = { 6, 3, 1, 0, -1, 3, 5 };


            //foreach (int i in tab1.Concat(tab2).Except(tab1.Intersect(tab2)))
            //{
            //    Console.Write(i + "; ");
            //}


            //Console.WriteLine(tab1.Concat(tab2).Where(x => x < 0).Sum());


            //Console.WriteLine(tab1.Intersect(tab2).Count());

            //foreach (int i in tab1.Intersect(tab2))
            //{
            //    Console.Write(i + " | ");
            //}

            //foreach (int i in tab1.Union(tab2))
            //{
            //    Console.Write(i + "; ");
            //}

            //foreach (int i in tab1.Concat(tab2))
            //{
            //    Console.Write(i + "; ");
            //}
        }


        struct liczby_opisy
        {
            public int liczba;
            public string opis;
        }


        liczby_opisy dodaj_opis(int liczba, string opis)
        {
            liczby_opisy lopis;
            lopis.liczba = liczba;
            lopis.opis = opis;
            return lopis;
        }

        void oblicz()
        {
            int[] liczby = { 0, 1, 2, 3, 9 };
            List<liczby_opisy> opisy = new List<liczby_opisy>();

            opisy.AddRange(new List<liczby_opisy> { dodaj_opis(0, "zero"), dodaj_opis(1, "jeden"), dodaj_opis(2, "dwa"),
                dodaj_opis(3, "trzy"), dodaj_opis(4, "cztery"), dodaj_opis(5, "pięć"), dodaj_opis(6, "sześć"), 
                dodaj_opis(7, "siedem"), dodaj_opis(8, "osiem"), dodaj_opis(9, "dziewięć")});


            //foreach (var x in from liczba in liczby
            //                  join opis in opisy on liczba equals opis.liczba
            //                  orderby liczba descending
            //                  select new { wartosc = liczba, opis_slowny = opis.opis })
            //{
            //    Console.WriteLine(x.wartosc + " => " + x.opis_slowny);
            //}


            //foreach (var x in from liczba in liczby join opis in opisy on liczba equals opis.liczba where liczba % 2 == 0
            //                  select new {wartosc = liczba, opis_slowny = opis.opis })
            //{
            //    Console.WriteLine(x.wartosc + " => " + x.opis_slowny);
            //}

        }
    }
}
