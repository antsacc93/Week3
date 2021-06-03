using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Calciatori.Classi
{
    public class Centrocampista : Calciatore
    {
        public Centrocampista() { }
        public Centrocampista(string nome, string cognome, int eta, int numeroMaglia, int numeroAssist) 
            : base(nome, cognome, eta, numeroMaglia)
        {
            NumeroAssist = numeroAssist;
        }

        public override Ruolo Ruolo { get; } = Ruolo.CENTROCAMPISTA;
        public int NumeroAssist { get; set; }
    }
}
