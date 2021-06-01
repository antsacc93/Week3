using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Polimorfismo.Classi
{
    public abstract class Persona
    {
        public String Nome { get; set; }
        public String Cognome { get; set; }
        public abstract double CalcolaStipendio(int anniAnzianità);

        public virtual string Stampa()
        {
            return "Nome: " + Nome + " Cognome: " + Cognome;
        }
    }
}
