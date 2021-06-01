using System;
using System.Collections;
using Week3.Polimorfismo.Classi;
using Week3.Polimorfismo.Interfacce;

namespace Week3.Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona persona = new Persona(); non posso istanziare oggetti di una classe astratta
            Persona impiegato = new Impiegato()
            {
                Nome = "Luca",
                Cognome = "Bianchi",
                StipendioBase = 1000
            };
            Persona studente = new Studente()
            {
                Nome = "Mario",
                Cognome = "Rossi",
                TitoloStudioAcquisito = "Diploma"
            };

            Console.WriteLine(impiegato.Stampa());
            Console.WriteLine(studente.Stampa());


            Console.WriteLine($"Lo stipendio dello studente {studente.Stampa()} è: {studente.CalcolaStipendio(0)}");
            Console.WriteLine($"Lo stipendio dell'impiegato {impiegato.Stampa()} è: {impiegato.CalcolaStipendio(3)}");

            Studente studente2 = new Studente()
            {
                Nome = "Giulia",
                Cognome = "Rossi",
                TitoloStudioAcquisito = "Magistrale"
            };
            studente2.IsDiplomato();

            ITassabile impiegatoTassabile = new Impiegato() { 
                Nome = "Pippo",
                Cognome = "Baudo",
                StipendioBase = 1200,
                Tassa = 30.0
            };
            Persona pers = (Persona)impiegatoTassabile;
            pers.CalcolaStipendio(3);


            Impiegato impiegato2 = (Impiegato)impiegatoTassabile;
            impiegato2.RicalcolaTassazione();

            impiegatoTassabile.RicalcolaTassazione();
            ArrayList v;


            ITassabile studenteUniversitario = new StudenteUniversitario();
            studenteUniversitario.Tassa = 340.7;

        }
    }
}
