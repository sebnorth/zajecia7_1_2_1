using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {

            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj5\pliki10\zaj5012021\choinka.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Append, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);

            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            int p = 2 * n - 1;
            int x, k;

            for (int i = 1; i <= n; i++) // wiersze
            {

                x = 2 * i - 1; // ilość gwiazdek
                // spacje
                for (k = 0; k < (p - x) / 2; k++)
                {
                    zapis.Write(" ");
                }

                // krzyżyki 
                for (k = 0; k < x; k++)
                {
                    zapis.Write("*");
                }


                // spacje
                for (k = 0; k < (p - x) / 2; k++)
                {
                    zapis.Write(" ");
                }


                // nowa linia
                zapis.WriteLine();
            }

            
            // zapis.WriteLine(suma);
            zapis.Close();
            plik.Close();
            Console.ReadKey();
        }
    }
}
