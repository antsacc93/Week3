using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Classi;

namespace Week3.Collections.Generic
{
    public class DictionaryGeneric
    {
        public static void Run()
        {
            var holidays = new Dictionary<string, DateTime>();
            holidays.Add("Natale", new DateTime(2021, 12, 25));
            holidays.Add("Ferragosto", new DateTime(2021, 08, 15));

            //dichiarazione + inizializzazione
            var holidays2 = new Dictionary<string, DateTime>
            {
                ["Natale"] = new DateTime(2021, 12, 25),
                ["Ferragosto"] = new DateTime(2021, 08, 15),
                ["Capodanno"] = new DateTime(2021, 12, 31)
            };

            if (holidays2.ContainsKey("Capodanno"))
            {
                Console.WriteLine("Festività inserita");
            }
            else
            {                
                holidays2.Add("Capodanno", new DateTime(2021, 12, 31));
            }

            var peopleDictionary = new Dictionary<int, Persona>
            {
                [1] = new Persona("Mario", "Rossi", 12),
                [2] = new Persona("Luca", "Bianchi", 56)
            };
            
            foreach(var item in peopleDictionary)
            {
                Console.WriteLine("Coppia chiave-valore: {0}-{1} ", item.Key, item.Value);
            }
        }
    }
}
