using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Calciatori.Classi
{
    public class Attaccante : Calciatore
    {
        public Attaccante() { }

        public Attaccante(string nome, string cognome, int eta, int numeroMaglia, int goalSegnati) 
            : base(nome, cognome, eta, numeroMaglia)
        {
            GoalSegnati = goalSegnati;
        }

        public override Ruolo Ruolo { get; } = Ruolo.ATTACCANTE;

        public int GoalSegnati { get; set; }
    }
}
