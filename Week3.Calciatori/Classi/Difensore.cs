using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Calciatori.Classi
{
    public class Difensore : Calciatore
    {
        public Difensore() { }
        public Difensore(string nome, string cognome, int eta, int numeroMaglia, int avversariPlaccati) 
            : base(nome, cognome, eta, numeroMaglia)
        {
            AvversariPlaccati = avversariPlaccati;
        }

        public override Ruolo Ruolo { get; } = Ruolo.DIFENSORE;
        public int AvversariPlaccati { get; set; }
    }
}
