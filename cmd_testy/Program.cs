﻿using System;
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
            ankieta_test.UtworzPytanie(300);
        }

        class Ankieta
        {
            public void UtworzPytanie(int m)
            {
                Pytanie[] pytanie = new Pytanie[m];
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
                    tresc_pytn[i] = p + "_" + (i+1).ToString() + ": " + "Tresc_pytania_" + (i+1).ToString();
                }

                for (int i = 0; i < m; i++)
                {
                    //Pytanie obiekty_pyt_nazwa = new Pytanie(1, "Która godzina?", 2, "11:32");
                    //Console.WriteLine(i.ToString());
                    pytanie[i] = new Pytanie(i, tresc_pytn[i], rand.Next(1, 5), DateTime.Today.ToString());
                    //pytanie[i] = new Pytanie("jakiś tekst");
                }

                for (int i = 0; i < obiekty_pyt_nazwy.Length; i++)
                {
                    Console.WriteLine(" " + obiekty_pyt_nazwy[i]);
                    Console.WriteLine(" " + pytanie[i].NumerPytania);
                    Console.WriteLine(" " + pytanie[i].TrescPytania);
                    Console.WriteLine(" " + pytanie[i].NumerOdpowiedzi);
                    Console.WriteLine(" " + pytanie[i].TrescOdpowiedzi);
                    Console.WriteLine("\n\n");
                }
                Console.ReadKey();
            }
        }

        class Pytanie
        { 
            public Pytanie(string TrescPytania)
            {
                this.TrescPytania = TrescPytania;
            }

            public Pytanie(int NumerPytania, string TrescPytania, int NumerOdpowiedzi, string TrescOdpowiedzi)
            {
                this.NumerPytania = NumerPytania;
                this.TrescPytania = TrescPytania;
                this.NumerOdpowiedzi = NumerOdpowiedzi;
                this.TrescOdpowiedzi = TrescOdpowiedzi;
            }

            public int NumerPytania { get; set; }
            public string TrescPytania { get; set; }
            public int NumerOdpowiedzi { get; set; }
            public string TrescOdpowiedzi { get; set; }
        }
    }
}