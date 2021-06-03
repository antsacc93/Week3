using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Bank.Classi
{
    public interface IBankAccount
    {
        string Titolare { get; set; }
        double Saldo { get; }
        string NumeroConto { get; }

        void Prelievo(DateTime data, double importo, string causale);
        void Deposito(DateTime data, double importo, string causale);
        string GetEstrattoConto();
        void TransazioneFineMese();

    }
}
