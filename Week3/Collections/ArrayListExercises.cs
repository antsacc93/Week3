using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Collections
{
    public class ArrayListExercises
    {

        public static void Run()
        {
            //Definizione dell'arraylist
            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add("Prova");
            lista.Add(true);

            var value = lista[2];
            object value2 = lista[0];
            //int value3 = (int)lista[1];

            int numElementi = lista.Count;
            Console.WriteLine(numElementi);

            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }
            lista.RemoveAt(0);
            Console.WriteLine("Numero di elementi {0}", lista.Count);
            lista.AddRange(new int[] { 1, 2, 3 });
            Console.WriteLine("Numero di elementi {0}", lista.Count);
            //lista.RemoveAt(10);
        }
    }
}
