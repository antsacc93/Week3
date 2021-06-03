using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Calciatori.Classi
{
    public class Arbitro : Atleta
    {
        public Arbitro() { }

        public Arbitro(string nome, string cognome, int eta, int anniCarriera) : base(nome, cognome, eta)
        {
            AnniCarriera = anniCarriera;
        }

        public int AnniCarriera { get; set; }
    }
}
