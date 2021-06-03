using System;
using Week3.DistributoreMerendine.Classi;

namespace Week3.DistributoreMerendine
{
    class Program
    {
        static void Main(string[] args)
        {
            char continua = 'y';
            while (continua == 'y')
            {
                Console.WriteLine("Benvenuto");
                Distributore.MostraProdotti();

                int scelta = Distributore.SceltaCodice();
                Distributore.MostraProdottoSelezionato(scelta);
                Distributore.GestionePagamento(scelta, out double resto);

                Console.WriteLine("Erogazione merendina");
                Console.WriteLine($"Resto: {resto}");

                Console.WriteLine("Vuoi acquistare altre merendine? y per confermare");
                
                continua = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine("Arrivederci");
        }
    }
}
