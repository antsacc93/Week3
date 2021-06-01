using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Polimorfismo
{
    public class Violino : Strumento
    {
        public int NumeroCorde { get; set; }
        public override string Nome { get; set; }

        public override void Accorda()
        {
            Console.WriteLine("Sto accordando un violino di {0} corde", NumeroCorde);
        }

        public override void PausaTempo()
        {
            Console.WriteLine("Pausa tempo di un violino");
        }
    }
}
