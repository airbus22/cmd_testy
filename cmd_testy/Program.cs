using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmd_testy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pytanie pyt = new Pytanie();
            //lbl1.Text = pyt.Ciag(401);

            Ankieta ankieta_test = new Ankieta();
            ankieta_test.UtworzPytanie(15);
        }

        public class Ankieta
        {
            public string Test { get; set; }

            public void UtworzPytanie(int m)
            {
                string p = "Pytanie";
                Random rand = new Random();
                string[] obiekty_pyt_nazwy = new string[m];
                string[] tresc_pytn = new string[m];

                for (int i = 0; i < m; i++)
                {
                    obiekty_pyt_nazwy[i] = p + "_" + (i + 1).ToString();
                }

                for (int i = 0; i < m; i++)
                {
                    tresc_pytn[i] = p + "_" + (i + 1).ToString() + ": " + "Tresc_pytania_" + i.ToString();
                }

                for (int i = 0; i < obiekty_pyt_nazwy.Length; i++)
                {
                    Console.WriteLine(obiekty_pyt_nazwy[i]);
                    //Console.WriteLine(Pytanie_1.);
                }
                Console.ReadKey();

                for (int i = 1; i < m; i++)
                {
                    //Pytanie obiekty_pyt_nazwa = new Pytanie(1, "Która godzina?", 2, "11:32");
                    Pytanie obiekty_pyt_nazwa = new Pytanie(i, tresc_pytn[i], rand.Next(1, 5), DateTime.Today.ToString());
                }
            }
        }

        public class Pytanie
        {
            //public string L { get; private set; }

            //public string Ciag(int m)
            //{                        
            //    for (int i = 1; i < m; i++)
            //    {                
            //        if (i <= 1)
            //        {
            //            L = i.ToString();
            //        }
            //        else
            //        {
            //            L = L + ", " + i;
            //        }
            //    }            
            //    return L;
            //}

            public Pytanie(int NumerPytania)
            {

            }

            public Pytanie(int NumerPytania, string TrescPytania, int NumerOdpowiedzi, string TrescOdpowiedzi)
            {
                this.NumerPytania = NumerPytania;
                this.TrescPytania = TrescPytania;
                this.NumerPytania = NumerPytania;
                this.TrescOdpowiedzi = TrescOdpowiedzi;
            }

            int NumerPytania
            {
                //get
                //{
                //    return this.NumerPytania;
                //}
                set
                {
                    NumerPytania = value;
                }
            }
            
            //int NumerPytania { get; set; }
            string TrescPytania { get; set; }
            int NumerOdpowiedzi { get; set; }
            string TrescOdpowiedzi { get; set; }
        }
    }
}