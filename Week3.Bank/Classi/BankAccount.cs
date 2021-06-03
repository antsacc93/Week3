using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Bank.Classi
{
    public class BankAccount : IBankAccount
    {
        private static int accountNumberSeed = 1234;
        
        public string Titolare { get; set; }
        public double Saldo {
            get {
                double saldo = 0;
                foreach(Transazione transazione in _transazioni)
                {
                    saldo += transazione.Importo;
                }
                return saldo;
            }
        }
        public string NumeroConto { get; }

        private IList<Transazione> _transazioni = new List<Transazione>();

        public BankAccount(string titolare, double saldoIniziale)
        {
            NumeroConto = accountNumberSeed.ToString();
            accountNumberSeed++;

            Titolare = titolare;
            if(saldoIniziale > 0)
            {
                Deposito(DateTime.Now, saldoIniziale, "Apertura conto corrente");
            }
        }

        public void Deposito(DateTime data, double importo, string causale)
        {
            if(importo > 0)
            {
                var deposito = new Transazione(data, importo, causale);
                _transazioni.Add(deposito);

                //_transazioni.Add(new Transazione(data, importo, causale));
            }else
            {
                Console.WriteLine("L'importo deve essere positivo");
            }
        }

        public void Prelievo(DateTime data, double importo, string causale)
        {
            if(importo > 0)
            {
                if(Saldo - importo < 0)
                {
                    Console.WriteLine("Non puoi prelevare così tanto");
                    return;
                }
                var prelievo = new Transazione(data, -importo, causale);
                _transazioni.Add(prelievo);

            }else
            {
                Console.WriteLine("Importo deve essere positivo");
            }
        }

        public string GetEstrattoConto()
        {
            var estrattoConto = new StringBuilder();
            estrattoConto.Append("Data \t Importo \t Causale \n");
            foreach(var transazione in _transazioni)
            {
                estrattoConto.Append(transazione.ToString());
            }
            estrattoConto.Append($"------- Totale \t \t: {Saldo} \n");
            return estrattoConto.ToString();
        }

        

        public virtual void TransazioneFineMese()
        {
            
        }
    }
}
