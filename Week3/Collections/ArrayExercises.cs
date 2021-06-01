using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Collections
{
    class ArrayExercises
    {
        //Array non sono collections, non fa parte di System.Collections
        public static void Run()
        {
            //Dichiarazione + inizializzazione
            int[] myArray = { 1, 2, 3 };
            //Dichiarazione
            int[] myArray2 = new int[5] { 1, 2, 3, 4, 5};
            
            //Numero elemento
            int numeroElementi = myArray.Length;
            Console.WriteLine("Il mio array conteine {0}", numeroElementi);

            //Modificare il numero di elementi
            Array.Resize(ref myArray2, 3);
            Console.WriteLine("Il mio array contiene {0}", myArray2.Length);
            for(int pos = 0; pos < myArray2.Length; pos++)
            {
                Console.WriteLine("Elemento in {0}: {1}", pos + 1, myArray2[pos]);
            }
            //dal momento che array estende IEnumerable posso usare il foreach
            foreach(int value in myArray2)
            {
                Console.WriteLine("Elmento: {0}", value);
            }
            int[] myArray3 = { 34, 23, 56, 12 };
            Array.Sort(myArray3);
            foreach(int value in myArray3)
            {
                Console.WriteLine("Elemento: {0}", value);
            }
            Console.WriteLine(myArray3);

            int[] myArray4 = new int[3];
            myArray4[0] = 1;
            myArray4[1] = 3;
            //myArray[10] = 20; genera un'eccezione "OutOfRange"
        }

    }
}
