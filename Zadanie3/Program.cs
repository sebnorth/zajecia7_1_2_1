using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj5\pliki10\zaj5012021\tekst.txt";
            string s;
            int suma_literek_aA_w_pliku = 0;
            int suma_literek_aA_w_linii = 0;
            FileStream plik = new FileStream(nazwa, FileMode.Open, FileAccess.Read, FileShare.None);
            System.IO.StreamReader odczyt = new StreamReader(plik);
            while ((s = odczyt.ReadLine()) != null)
            {
                suma_literek_aA_w_linii = 0;
                foreach (char znak in s)
                {
                    if (znak == 'a' || znak == 'A') suma_literek_aA_w_linii++;
                }
                Console.WriteLine("Suma liter a w linii wynosi {0}", suma_literek_aA_w_linii);
                suma_literek_aA_w_pliku += suma_literek_aA_w_linii;

            }

            odczyt.Close();
            plik.Close();
            Console.WriteLine("Suma tych liczb wynosi {0}", suma_literek_aA_w_pliku);
            Console.ReadKey();
        }
    }
}
