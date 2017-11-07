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
            Ankieta ankieta_test = new Ankieta();
            ankieta_test.UtworzPytanie(5);
        }

        public class Ankieta
        {
            public string Test { get; set; }            

            public void UtworzPytanie(int m)
            {
                Pytanie[] pytanie = new Pytanie[3];
                //Pytanie[] pytanie = new Pytanie[m+1];
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
                    tresc_pytn[i] = p + "_" + (i+1).ToString() + ": " + "Tresc_pytania_" + i.ToString();
                }
                
                //for (int i = 0; i < m; i++)
                //{
                //    //Pytanie obiekty_pyt_nazwa = new Pytanie(1, "Która godzina?", 2, "11:32");
                //    //Console.WriteLine(i.ToString());
                //    //pytanie[i] = new Pytanie(i, tresc_pytn[i], rand.Next(1, 5), DateTime.Today.ToString());
                //    pytanie[i] = new Pytanie("jakiś tekst");
                //}
                pytanie[0] = new Pytanie("jakiś tekst0");
                pytanie[1] = new Pytanie("jakiś tekst1");
                pytanie[2] = new Pytanie("jakiś tekst2");

                Console.WriteLine(" " + pytanie[0]);
                Console.WriteLine(" " + pytanie[1]);
                Console.WriteLine(" " + pytanie[2]);

                //for (int i = 0; i < obiekty_pyt_nazwy.Length; i++)
                //{
                //    Console.WriteLine(" " + obiekty_pyt_nazwy[i]);
                //    Console.WriteLine(" " + pytanie[i]);
                //}
                Console.ReadKey();
            }
        }

        public class Pytanie
        {

            public Pytanie(string TrescPytania)
            {
                this.TrescPytania = TrescPytania;
            }

            public Pytanie(int NumerPytania, string TrescPytania, int NumerOdpowiedzi, string TrescOdpowiedzi)
            {
                this.NumerPytania = NumerPytania;
                this.TrescPytania = TrescPytania;
                this.NumerPytania = NumerPytania;
                this.TrescOdpowiedzi = TrescOdpowiedzi;
            }

            int NumerPytania { get; set; }
            string TrescPytania { get; set; }
            int NumerOdpowiedzi { get; set; }
            string TrescOdpowiedzi { get; set; }
        }
    }
}