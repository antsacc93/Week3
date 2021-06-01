using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Collections
{
    public class StackExercises
    {
        public static void Run()
        {
            Stack myStack = new Stack();

            //Aggiungi un elemento
            myStack.Push("prova");
            myStack.Push(34.56);
            myStack.Push(DateTime.Now);

            foreach(var item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Elemento rimosso");
            var objRemoved = myStack.Pop();
            Console.WriteLine(objRemoved);

            var objPeeked = myStack.Peek();
            Console.WriteLine(objPeeked);

            foreach(var item in myStack)
            {
                Console.WriteLine(item);
            }

        }

    }
}
