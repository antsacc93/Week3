using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Classi;

namespace Week3.Collections
{
    public class QueueExercises
    {

        public static void Run()
        {
            var queue = new Queue();
            
            //Inserimento elementi
            queue.Enqueue("ciao");
            queue.Enqueue(1);
            queue.Enqueue(DateTime.Today);

            Console.WriteLine("Valori inseriti {0}", queue.Count);

            foreach(object item in queue)
            {
                Console.WriteLine(item);
            }

            //Rimozione degli elementi
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("Ora la mia coda contiene {0} elementi", queue.Count);

            //Peek
            Console.WriteLine(queue.Peek());
            Console.WriteLine("La coda contiene sempre {0}", queue.Count);
        }

    }
}
