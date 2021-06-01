using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Classi;

namespace Week3.Collections.Generic
{
    public class ListExercise
    {
        public static void Run()
        {
            var listaDiStringhe = new List<string>();
            listaDiStringhe.Add(""); //elemento in posizione 0
            listaDiStringhe.Add("mario rossi"); //elemento in posizione 1
            listaDiStringhe.Add("stringa di prova");

            listaDiStringhe.IndexOf("mario rossi");
            listaDiStringhe.Contains("");

            listaDiStringhe[1] = "antonia sacchitella";
            Console.WriteLine("Elemento in posizione 3 -> {0}", listaDiStringhe[2]);

            //inizializzazione a partire da un array
            var sourceArray = new string[] { "PrimaStringa", "SecondaStringa" };
            var listaStringhe2 = new List<string>(sourceArray);

            //inizializzazione inline
            var lista = new List<string> { "Stringa1", "Stringa2", "Stringa3" };

            var listaPersone = new List<Persona>
            {
                new Persona("Mario", "Rossi", 23),
                new Persona("Paola", "Bianchi", 44)
            };

            Console.WriteLine(listaPersone.Count);

            foreach(var persona in listaPersone)
            {
                Console.WriteLine(persona);
            }

        }

    }
}
