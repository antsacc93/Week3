using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.EsercitazioneFinale.Classi.Entities;

namespace Week3.EsercitazioneFinale.Classi.Gestore
{
    public class GestoreECommerce
    {
        private static IList<Utente> utenti = CaricaUtentiECommerce();
        private static IList<Prodotto> prodotti = CaricaProdottiECommerce();

        private static IList<Prodotto> CaricaProdottiECommerce()
        {
            IList<Prodotto> prodotti = new List<Prodotto>()
            {
                new ProdottoAbbigliamento(){
                    Codice = "PR01",
                    Descrizione = "T-Shirt",
                    Prezzo = 100,
                    PercentualeSconto = 10,
                    Brand = "Gucci",
                    Taglia = "M"
                },
                new ProdottoAlimentare()
                {
                    Codice = "PR02",
                    Descrizione = "Caffè",
                    Prezzo = 2.5,
                    PercentualeSconto = 0,
                    DataScadenza = new DateTime(2022, 3, 4)
                },
                new ProdottoElettronica()
                {
                    Codice = "PR03",
                    Descrizione = "Monitor Samsung",
                    Prezzo = 250,
                    PercentualeSconto = 20,
                    Produttore = "Samsung"
                }
            };
            return prodotti;
        }

        private static IList<Utente> CaricaUtentiECommerce()
        {
            IList<Utente> utenti = new List<Utente>()
            {
                new Utente(){NomeCognome = "Mario Rossi", Username = "mrossi", Password = "12345"}
            };
            return utenti;
        }

        internal static Utente LogInUtente()
        {
            Console.WriteLine("Inserisci i tuoi dati");
            Console.Write("Username -> ");
            string username = Console.ReadLine();
            Console.Write("Password -> ");
            string password = Console.ReadLine();
            foreach (var utente in utenti)
            {
                if (utente.Username == username && utente.Password == password)
                {
                    return utente;
                }
            }
            return null;
        }

        public static void MenuPrincipale(Utente utente)
        {
            Console.Clear();
            int scelta = 0;
            Console.WriteLine($"Bentornato {utente.NomeCognome}");
            while (scelta != 5)
            {
                
                Console.WriteLine("1. Inserisci un nuovo prodotto");
                Console.WriteLine("2. Elimina prodotto");
                Console.WriteLine("3. Modifica quantità prodotto");
                Console.WriteLine("4. Visualizza carrello");
                Console.WriteLine("5. Esci");
                bool success = int.TryParse(Console.ReadLine(), out scelta);

                AnalizzaScelta(scelta, utente);
            }
        }

        public static void AnalizzaScelta(int scelta, Utente utente)
        {
            switch (scelta)
            {
                case 1:
                    AggiungiProdottoCarrello(utente);
                    break;
                case 2:
                    EliminaProdotto(utente);
                    break;
                case 3:
                    ModificaQuantitaProdotto(utente);
                    break;
                case 4:
                    VisualizzaCarrello(utente);
                    break;
                default:
                    break;
            }
        }

        private static void ModificaQuantitaProdotto(Utente utente)
        {
            VisualizzaCarrello(utente);          
            Prodotto prodottoDaModificare = OperazioneSuProdotto("modificare", utente, out string codice);
            Console.WriteLine("Inserisci la quantità");
            bool success = int.TryParse(Console.ReadLine(), out int quantita);
            VerificaInputQuantita(ref quantita, success);
            utente.Carrello.Dettagli[codice].Quantita = quantita;

        }

        private static Prodotto OperazioneSuProdotto(string operazione, Utente utente, out string codice)
        {
            Console.Clear();
            VisualizzaCarrello(utente);
            Console.WriteLine($"Quale prodotto vuoi {operazione}? (inserisci il codice)");
            codice = Console.ReadLine();
            Prodotto prodotto = utente.Carrello.VerificaProdotto(codice);
            while (prodotto == null)
            {
                Console.WriteLine("Codice errato, inserisci il codice del prodotto che vuoi eliminare");
                codice = Console.ReadLine();
            }
            return prodotto;
        }

        private static void VisualizzaCarrello(Utente utente)
        {
            Console.Clear();
            if (utente.Carrello.Dettagli.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Il tuo carrello è vuoto");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(utente.Carrello);
            }
        }

        private static void EliminaProdotto(Utente utente)
        {
            Console.Clear();
            VisualizzaCarrello(utente);
            Console.WriteLine("Quale prodotto vuoi eliminare? (inserisci il codice)");
            string codice = Console.ReadLine();
            Prodotto prodottoDaEliminare = utente.Carrello.VerificaProdotto(codice);
            if (prodottoDaEliminare != null)
            {
                utente.Carrello.Dettagli.Remove(prodottoDaEliminare.Codice);
            }
            else
            {
                Console.WriteLine("Prodotto non presente nel tuo carrello");
            }
        }

        public static void AggiungiProdottoCarrello(Utente utente)
        {
            Console.Clear();
            //metodo che stampa i prodotti a video
            VisualizzaCatalogo();
            Console.WriteLine("Inserisci il codice del prodotto da aggiungere");
            string codice = Console.ReadLine();

            //TODO: Metodo per la ricerca del prodotto
            Prodotto prodotto = CercaProdottoPerCodice(codice);
            if (prodotto != null)
            {
                Console.WriteLine($"Hai scelto \n {prodotto}");
                Console.WriteLine("Inserisci quantità");
                bool success = int.TryParse(Console.ReadLine(), out int quantita);
                VerificaInputQuantita(ref quantita, success);
                utente.Carrello.Dettagli.Add(prodotto.Codice,
                    new Dettaglio()
                    {
                        Prodotto = prodotto,
                        Quantita = quantita
                    });
            }else
            {
                Console.WriteLine("Prodotto non presente nel catalogo");
            }
            Console.Clear();
        }

        private static void VisualizzaCatalogo()
        {
            Console.Clear();
            foreach (var prodotto in prodotti)
            {
                Console.WriteLine(prodotto);
            }
        }

        private static Prodotto CercaProdottoPerCodice(string codice)
        {
            foreach (var prodotto in prodotti)
            {
                if (prodotto.Codice == codice)
                {
                    return prodotto;
                }
            }
            return null;
        }

        private static void VerificaInputQuantita(ref int quantita, bool success)
        {           
            while (quantita < 0 || !success)
            {
                Console.WriteLine("La quantità deve essere positiva");
                success = int.TryParse(Console.ReadLine(), out quantita);
            }
        }
    }
}
