using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Polimorfismo.Classi
{
    public sealed class Studente : Persona
    {
        public String TitoloStudioAcquisito { get; set; }
        public override double CalcolaStipendio(int anniAnzianità)
        {
            if (IsDiplomato())
            {
                return 500;
            }
            return 0.0;
        }

        public bool IsDiplomato()
        {
            if(TitoloStudioAcquisito == "Diploma")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
