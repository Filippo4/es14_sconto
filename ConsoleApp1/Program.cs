using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sconto;
            Console.WriteLine("inserire il prezzo del primo prodotto!");
            double primo_prodotto = double.Parse(Console.ReadLine());
            Console.WriteLine("inserire il prezzo del secondo prodotto!");
            double secondo_prodotto = double.Parse(Console.ReadLine());
            if (primo_prodotto > secondo_prodotto)
            {
                sconto = secondo_prodotto / 2;
                secondo_prodotto = secondo_prodotto - sconto;
                double importoTot = primo_prodotto + secondo_prodotto;
                Console.WriteLine($"l'importo da pagare è {importoTot}");
            }
            else

            {
                sconto = primo_prodotto / 2;
                primo_prodotto = primo_prodotto - sconto;
                double importoTot = primo_prodotto + primo_prodotto;
                Console.WriteLine($"l'importo da pagare è {importoTot}");
            }
            Console.ReadLine();
        
        }
    }
}
