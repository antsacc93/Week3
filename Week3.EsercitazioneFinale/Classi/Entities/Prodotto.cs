using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercitazioneFinale.Classi.Entities
{
    public abstract class Prodotto
    {
        public String Codice { get; set; }
        public double Prezzo { get; set; }
        public String Descrizione { get; set; }
        public int PercentualeSconto { get; set; }

        public override string ToString()
        {
            return $"{Codice} - {Descrizione} - {Prezzo} - {PercentualeSconto}";
        }

    }
}
