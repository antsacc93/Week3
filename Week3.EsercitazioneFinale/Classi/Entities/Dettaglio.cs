using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercitazioneFinale.Classi.Entities
{
    public class Dettaglio
    {
        public Prodotto Prodotto { get; set; }
        public int Quantita { get; set; }

        public double PrezzoPieno
        {
            get
            {
                return Prodotto.Prezzo * Quantita;
            }
        }

        public double PrezzoScontato
        {
            get
            {
                if(Prodotto.PercentualeSconto != 0)
                {
                    return (Prodotto.Prezzo - (Prodotto.Prezzo * Prodotto.PercentualeSconto)/100) * Quantita;
                }
                return Prodotto.Prezzo * Quantita;
            }
        }

        public override string ToString()
        {
            return $"{Prodotto} - {Quantita} pz - {PrezzoPieno} euro - {PrezzoScontato} euro";
        }

    }
}
