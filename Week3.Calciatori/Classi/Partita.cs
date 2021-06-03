using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Calciatori.Classi
{
    public class Partita
    {

        private Atleta _arbitro = new Arbitro()
        {
            Nome = "Luca",
            Cognome = "Rocchi",
            Eta = 34,
            AnniCarriera = 10
        };
        public Atleta Arbitro { get { return _arbitro; } }

        private Atleta _guardalinea = new Arbitro("Mario", "Collina", 57, 30);
        public Atleta GuardaLinea { get { return _guardalinea; } }


        private IDictionary<int, Calciatore> _squadraInCasa = new Dictionary<int, Calciatore>()
        {
            [1] = new Portiere("Gianluigi", "Buffon", 40, 20),
            [7] = new Attaccante("Cristiano", "Ronaldo", 32, 7, 35),
            [19] = new Centrocampista("Mario", "Rossi", 25, 19, 5),
            [11] = new Difensore()
        };
        public IDictionary<int, Calciatore> SquadraInCasa {get { return _squadraInCasa; } }

        public static Partita GetElementiPartita()
        {
            return new Partita();           
        }
    }
}
