using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Bank.Classi
{
    public class ContoRisparmio : BankAccount
    {
        public ContoRisparmio(string titolare, double saldoIniziale) : base(titolare, saldoIniziale)
        {
        }

        public override void TransazioneFineMese()
        {
            if(Saldo > 500)
            {
                var credito = Saldo * 0.02;
                Deposito(DateTime.Now, credito, "Credito maturato");
            }
        }
    }
}
