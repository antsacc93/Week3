using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Calciatori.Classi
{
    public class Portiere : Calciatore
    {
        public Portiere() { }

        public Portiere(string nome, string cognome, int eta, int goalSubiti, int numeroMaglia = 1) 
            : base(nome, cognome, eta, numeroMaglia)
        {
            NumeroMaglia = numeroMaglia;
            GoalSubiti = goalSubiti;
        }

        public override Ruolo Ruolo { get; } = Ruolo.PORTIERE;
        public override int NumeroMaglia { get; set; } = 1;
        public int GoalSubiti { get; set; }
    }
}
