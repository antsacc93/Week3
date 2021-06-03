using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Generici
{
    public class Generici
    {
        public static void Run()
        {
            int a = 12;
            int b = 3;
            string c = "Ciao";
            string d = "Hello";
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            double e = 3.2;
            double f = 3.4;
            Swap(ref e, ref f);
        }

        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;           
        //    a = b;
        //    b = temp;
        //}

        //public static void Swap(ref string a, ref string b)
        //{
        //    string temp = a;           
        //    a = b;
        //    b = temp;
        //}

        public static void Swap<TValue>(ref TValue a, ref TValue b)
        {
            TValue temp = a;
            a = b;
            b = temp;
        }

        public static T Max<T> (IEnumerable<T> lista) where T : IComparable
        {
            bool isFirst = true;
            T risultato = default(T);

            foreach(T item in lista)
            {
                if (isFirst)
                {
                    risultato = item;
                    isFirst = false;
                }
                if (risultato.CompareTo(item) < 0) {
                    risultato = item;
                }
            }
            return risultato;
        }
        
    }
}
