using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Bank.Classi
{
    public class ContoCredito : BankAccount
    {
        public ContoCredito(string titolare, double saldoIniziale) : base(titolare, saldoIniziale)
        {
        }

        public override void TransazioneFineMese()
        {
            if(Saldo < 0)
            {
                var interesse = Saldo * 0.02;
                Prelievo(DateTime.Now, -interesse, "Tassa conto credito");
            }
        }
    }
}
