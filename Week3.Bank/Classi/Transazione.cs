using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Bank.Classi
{
    public class Transazione
    {
        public DateTime Data { get; set; }
        public double Importo { get; set; }
        public string Causale { get; set; }

        public Transazione(DateTime data, double importo, string causale = "")
        {
            Data = data;
            Importo = importo;
            Causale = causale;
        }

        public override string ToString()
        {
            return $"{Data.ToShortDateString()} \t {Importo} \t {Causale} \n";
        }
    }
}
