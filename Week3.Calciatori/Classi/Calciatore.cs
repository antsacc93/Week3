using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Calciatori.Classi
{
    public enum Ruolo
    {
        ATTACCANTE,
        PORTIERE,
        CENTROCAMPISTA,
        DIFENSORE
    }

    public abstract class Calciatore : Atleta
    {
        public Calciatore() { }
        public Calciatore(string nome, string cognome, int eta, int numeroMaglia) 
            : base(nome, cognome, eta)
        {
            NumeroMaglia = numeroMaglia;           
        }

        public abstract Ruolo Ruolo { get; }

        public virtual int NumeroMaglia { get; set; }

    }
}
