using System;

namespace sconti
{
    public static class Calcolo
    {
        public static double Sconto(double a, double b)
        {
            double sconto;
            if (a > b)
            {
                sconto = b / 2;
                b = b - sconto;
                double importoTot = a + b;
                Console.WriteLine($"l'importo da pagare è {importoTot}");
            }
            else

            {
                sconto = a / 2;
                a = a - sconto;
                double importoTot = a + b;
                Console.WriteLine($"l'importo da pagare è {importoTot}");
            }
            return sconto;
        }
    }
}
