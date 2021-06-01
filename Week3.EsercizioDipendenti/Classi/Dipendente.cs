using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercizioDipendenti.Classi
{
    public class Dipendente
    {
        public String Matricola { get; set; }
        public double Stipendio { get; set; }
        public double TariffaStraordinario { get; set; }

        //Costruttore con parametri
        public Dipendente(string matricola, double stipendio, double tariffaStraordinario) {
            Matricola = matricola;
            Stipendio = stipendio;
            TariffaStraordinario = tariffaStraordinario;
        }

        public virtual double Paga(int oreStraordinario)
        {
            return Stipendio + oreStraordinario * TariffaStraordinario;
        }

        public override string ToString()
        {
            return $"Matricola Dipendente: {Matricola} - Stipendio Base: {Stipendio} euro" +
                $" Tariffa straordinario: {TariffaStraordinario} euro/h";
        }
    }
}
