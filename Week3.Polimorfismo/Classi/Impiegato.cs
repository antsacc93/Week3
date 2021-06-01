using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Polimorfismo.Interfacce;

namespace Week3.Polimorfismo.Classi
{
    public class Impiegato : Persona, ITassabile
    {
        public double StipendioBase { get; set; }
        public double Tassa { get; set; }

        public override double CalcolaStipendio(int anniAnzianità)
        {
            return anniAnzianità * StipendioBase;
        }

        public double RicalcolaTassazione()
        {
            return Tassa;
        }
    }
}
