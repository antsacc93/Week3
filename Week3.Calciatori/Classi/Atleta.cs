using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Calciatori.Classi
{
    public abstract class Atleta
    {
        public String Nome { get; set; }
        public String Cognome { get; set; }
        public int Eta { get; set; }

        public Atleta(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public Atleta() { }
    }
}
