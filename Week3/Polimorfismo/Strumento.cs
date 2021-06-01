using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Polimorfismo
{
    public abstract class Strumento
    {
        //private abstract _nome;
        public abstract String Nome { get; set; }

        public abstract void PausaTempo();

        public virtual void Accorda()
        {
            Console.WriteLine("Strumento generico accordato");
        }
    }
}
