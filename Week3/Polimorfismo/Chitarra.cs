using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Polimorfismo
{
    public class Chitarra : Strumento
    {
        public bool IsElettrica { get; set; }
        public override string Nome { get { return "Chitarra"; } set { } }

        public override void Accorda()
        {
            Console.WriteLine($"Sto accordando una chitarra {IsElettrica}");
        }

        public override void PausaTempo()
        {
            Console.WriteLine($"Pausa tempo specifico di {Nome}");
        }
    }
}
