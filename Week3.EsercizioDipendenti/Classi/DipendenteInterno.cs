using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercizioDipendenti.Classi
{
    public class DipendenteInterno : Dipendente
    {
        public int Malattia { get; set; }

        public DipendenteInterno(string matricola, double stipendio, double tariffaStraordinario) 
            : base(matricola, stipendio, tariffaStraordinario)
        {
        }

        public void PrendiMalattia(int giorniMalattia)
        {
            Malattia = giorniMalattia;
        }

        public override double Paga(int oreStraordinario)
        {
            return base.Paga(oreStraordinario) - (Malattia * 15);
        }

        public override string ToString()
        {
            return base.ToString() + $"\nGiorni di malattia richiesti: {Malattia}";
        }
    }
}
