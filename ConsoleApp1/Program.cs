using System;
using sconti;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserire il prezzo del primo prodotto!");
            double primo_prodotto = double.Parse(Console.ReadLine());
            Console.WriteLine("inserire il prezzo del secondo prodotto!");
            double secondo_prodotto = double.Parse(Console.ReadLine());
            double risposta = Calcolo.Sconto( secondo_prodotto , primo_prodotto ); 
            Console.ReadLine();

        }
    }
}
