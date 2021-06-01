using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Polimorfismo
{
    public class Pianoforte : Strumento
    {
        public bool IsVerticale { get; set; }
        public override string Nome { get; set; }

        public override void Accorda()
        {
            Console.WriteLine($"Sto accordando il pianoforte {Nome}");
        }

        public override void PausaTempo()
        {
            Console.WriteLine("Pausa tempo specifica di un pianforte");
        }
    }
}
