using System;
using System.Collections.Generic;
using Week3.Bank.Classi;

namespace Week3.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount ba = new BankAccount("Mario Rossi", 200.00);
            ba.Deposito(DateTime.Now, 300.00, "Deposito di prova");
            ba.Prelievo(DateTime.Now, 550, "Prelievo n. 1");
            Console.WriteLine(ba.GetEstrattoConto());
            Console.WriteLine(" ---- ");
            IBankAccount contoCredito = new ContoCredito("Paolo Bianchi", 400);
            contoCredito.Prelievo(DateTime.Now, 220, "Affitto");
            contoCredito.TransazioneFineMese();
            Console.WriteLine(contoCredito.GetEstrattoConto());
            Console.WriteLine(" ---- ");
            IBankAccount contoRisparmio = new ContoRisparmio("Francesco Verdi", 900.12);
            contoRisparmio.TransazioneFineMese();
            Console.WriteLine(contoRisparmio.GetEstrattoConto());
        }
    }
}
