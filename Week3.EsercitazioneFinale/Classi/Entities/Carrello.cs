using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercitazioneFinale.Classi.Entities
{
    public class Carrello
    {
        public IDictionary<string, Dettaglio> Dettagli = new Dictionary<string, Dettaglio>();
        public double ImportoTotale
        {
            get
            {
                double importo = 0.0;
                foreach(var det in Dettagli)
                {
                    if(det.Value.PrezzoScontato != det.Value.PrezzoPieno)
                    {
                        importo += det.Value.PrezzoScontato;
                    }
                    else
                    {
                        importo += det.Value.PrezzoPieno;
                    }
                }
                return importo;
            }
        }

        public override string ToString()
        {
            var carrello = new StringBuilder();
            carrello.Append("Prodotti inseriti \n");
            foreach(var item in Dettagli)
            {
                carrello.Append(item.Value + "\n");
            }
            carrello.Append($"\t \t Importo totale: {ImportoTotale} euro");
            return carrello.ToString();
        }

        public Prodotto VerificaProdotto(string codice)
        {
            foreach (var item in Dettagli)
            {
                if (item.Value.Prodotto.Codice == codice)
                {
                    return item.Value.Prodotto;
                }
            }
            return null;
        }

    }
}
