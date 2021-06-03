using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.DistributoreMerendine.Classi
{
    public static class Distributore
    {
        private static IDictionary<int, Merendina> merendineCaricate = CaricaDistributore();

        private static IDictionary<int, Merendina> CaricaDistributore()
        {
            IDictionary<int, Merendina> merendine = new Dictionary<int, Merendina>()
            {
                [0] = new Merendina() { Codice = 0, Nome = "Buondì", Importo = 1.0},
                [1] = new Merendina() { Codice = 1, Nome = "Kinder Bueno", Importo = 2.0},
                [2] = new Merendina() { Codice = 2, Nome = "Ringo", Importo = 2.4},
                [3] = new Merendina() { Codice = 3, Nome = "Patatine", Importo = 1.5}
            };
            return merendine;
        }

        public static void MostraProdotti()
        {
            Console.WriteLine("Lista di prodotti presenti nel distributore");
            foreach(var item in merendineCaricate)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome} - {item.Value.Importo} euro");
            }
        }

        public static int SceltaCodice()
        {
            int codice;
            do
            {
                Console.WriteLine("Inserisci il codice prodotto");

            } while (!(Int32.TryParse(Console.ReadLine(), out codice)) || !merendineCaricate.ContainsKey(codice));
            return codice;
        }

        public static void MostraProdottoSelezionato(int codice)
        {
            Console.Write($"Hai scelto il codice {codice} \t");
            var merendinaSelezionata = merendineCaricate[codice];
            Console.WriteLine($"{merendinaSelezionata.Nome} - {merendinaSelezionata.Importo}");
        }

        public static void GestionePagamento(int codice, out double resto)
        {
            double cash = 0.0;
            double cashTot = 0.0;
            resto = 0.0;
            double importo = merendineCaricate[codice].Importo;
            Console.WriteLine("Inserisci importo");
            do
            {
                Double.TryParse(Console.ReadLine(), out cash);
                cashTot += cash;
                if(cashTot < importo)
                {
                    Console.WriteLine($"Bisogna ancora inserire {importo - cashTot}");
                }
            } while (cashTot < importo);
            resto = cashTot - importo;
        }
    }
}
