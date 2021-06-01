using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Classi;

namespace Week3.Collections
{
    public class HashTableExercises
    {
        public static void Run()
        {
            Hashtable table = new Hashtable();

            //Aggiungere elementi
            table.Add("stringa", 2);
            table.Add("RSSMRA", new Persona() { Nome = "Mario", Cognome = "Rossi", Eta = 25 });
            table.Add(DateTime.Today, 4);

            //recupero tutte le chiavi della hashtable
            var keys = table.Keys;
            Console.WriteLine("La tua hashtable contiene {0} chiavi", keys.Count);
            foreach(var key in keys)
            {
                Console.WriteLine(key);
            }
            //recupero tutti i valori
            var values = table.Values;
            foreach(var item in values)
            {
                Console.WriteLine(item);
            }
            //stampa chiave-valore
            foreach(DictionaryEntry item in table)
            {
                Console.WriteLine("Coppia {0} - {1}", item.Key, item.Value);
            }

            //restituisci valore a partire da una chiave
            object value = table["stringa"];
            var value2 = table["RSSMRA"];

            Console.WriteLine("Elemento individuato {0}", value);
            Console.WriteLine("Elemento trovato {0}", value2);

            //modifico il valore corrispondente alla chiave "stringa"
            table["stringa"] = DateTime.Today;

            table.Add(34.0, "double di prova");
            table.Remove("RSSMRA");

            foreach(DictionaryEntry item in table)
            {
                Console.WriteLine($"Coppia chiave {item.Key} - valore {item.Value}");
            }

        }
    }
}
