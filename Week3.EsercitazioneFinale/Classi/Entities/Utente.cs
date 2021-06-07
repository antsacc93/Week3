using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercitazioneFinale.Classi.Entities
{
    public class Utente
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String NomeCognome { get; set; }
        public Carrello Carrello { get; set; } = new Carrello();
    }
}
