using System;
using Week3.EsercizioDipendenti.Classi;

namespace Week3.EsercizioDipendenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Dipendente dipendenteSemplice = new Dipendente("AB001", 1200.00, 12.00);
            Console.WriteLine(dipendenteSemplice);
            Console.WriteLine("Paga: {0} euro", dipendenteSemplice.Paga(2));

            DipendenteInterno dipInterno = new DipendenteInterno("AB002", 1300.00, 13.00);
            Console.WriteLine(dipInterno);
            dipInterno.PrendiMalattia(2);
            Console.WriteLine(dipInterno);
            Console.WriteLine(dipInterno.Paga(0));
        }
    }
}


