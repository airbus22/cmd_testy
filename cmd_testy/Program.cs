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
            ankieta_test.UtworzPytanie(5);
        }
        
        public class Ankieta
        {
            public string Test { get; set; }      

            public void UtworzPytanie(int m)
            {                
                string p = "Pytanie";
                string[] obiekty_pyt_nazwy = new string[m];
                
                for (int i = 0; i < m; i++)
                {
                    obiekty_pyt_nazwy[i] = p + "_" + (i+1).ToString();
                }

                for (int i =0; i < obiekty_pyt_nazwy.Length; i++)
                {
                    Console.WriteLine(obiekty_pyt_nazwy[i]);
                }
                Console.ReadKey();

                //for (int i = 1; i < m; i++)
                //{
                //    Pytanie pytanie = new Pytanie();
                //}
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

            int NumerPytania { get; set; }
            string TrescPytania { get; set; }
            int NumerOdpowiedzi { get; set; }
            string TrescOdpowiedzi { get; set; }
        }
    }
}