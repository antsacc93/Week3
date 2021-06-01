using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Polimorfismo.Interfacce;

namespace Week3.Polimorfismo.Classi
{
    public class StudenteUniversitario : ITassabile//: Studente
    {
        public double Tassa { get; set; }

        public double RicalcolaTassazione()
        {
            return Tassa * 10;
        }
    }
}
