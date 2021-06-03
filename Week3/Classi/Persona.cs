using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Classi
{
    public class Persona 
    {
        private string _nome;
        private string _cognome;
        private int _eta;

        //costruttore di Persona con parametri nome e cognome
        public Persona(string nome, string cognome, int eta)
        {
            //this._nome = nome;
            //this._cognome = cognome;
            _nome = nome;
            _cognome = cognome;
            _eta = eta;
        }

        //costruttore no-arg
        public Persona() { }

        public String Nome { get { return this._nome; } set { this._nome = value; } }
        public String Cognome { get { return this._cognome; } set { this._cognome = value; } }
        public int Eta { get { return _eta; } set { _eta = value; } }

        public string FullName(string _nome, string _cognome) {
            this._nome = _nome;
            this._cognome = _cognome;
            return _nome + _cognome;
        }
        
        public override string ToString()
        {
            return _nome + _cognome;
        }

        public class Polmone
        {
            public String Tessuto { get; set; }
        }
    }
}
