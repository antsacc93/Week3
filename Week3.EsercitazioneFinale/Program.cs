using System;
using Week3.EsercitazioneFinale.Classi.Entities;
using Week3.EsercitazioneFinale.Classi.Gestore;

namespace Week3.EsercitazioneFinale
{
    class Program
    {
        static void Main(string[] args)
        {
            char continua = 'y';
            while(continua == 'y')
            {
                Utente utente = GestoreECommerce.LogInUtente();
                if(utente != null)
                {
                    GestoreECommerce.MenuPrincipale(utente);
                }
                else
                {
                    break;
                }

                Console.WriteLine("Sei sicuro di voler uscire? y per continua gli acquisti");
                continua = Console.ReadKey().KeyChar;
            }
            
        }
    }
}
