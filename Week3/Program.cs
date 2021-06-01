using System;
using System.Collections;
using Week3.Classi;
using Week3.Polimorfismo;
using Week3.Strutture;
//using static Week3.Classi.Persona;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region COSTRUTTORE E CLASSE ANNIDATA

            Console.WriteLine("Hello World!");
            Persona p = new Persona()
            {
                Nome = "Mario",
                Cognome = "Rossi"
            };
            Veicolo veicolo = new Veicolo();
            Persona.Polmone polmone = new Persona.Polmone();
            #endregion

            #region CLASSI VS STRUTTURE

            //Classe Persona
            Persona persona = new Persona("Carla", "Fracci", 84);
            Persona persona2 = persona;

            persona2.Nome = "Giulia";
            persona2.Eta = 70;

            Console.WriteLine($"Persona da classe -> Nome: {persona.Nome} - Eta: {persona.Eta}");
            Console.WriteLine($"Persona2 da classe -> Nome: {persona2.Nome} - Eta: {persona2.Eta} ");

            //Struttura Person
            Person person = new Person("Carla", "Fracci", 84);
            Person person2 = person;

            person2.Name = "Barbara";
            person2.Age = 70;

            Console.WriteLine($"Person da struttura -> Nome: {person.Name} - Eta: {person.Age}");
            Console.WriteLine($"Person2 da struttura -> Nome: {person2.Name} - Eta: {person2.Age}");
            #endregion

            #region POLIMORFISMO
            Console.Clear();

            //dichiarazione di violino pianoforte e chitarra di tipo strumento
            Strumento violino, pianoforte, chitarra;
            
            violino = new Violino();
            pianoforte = new Pianoforte() {
                Nome = "Pianoforte a coda",
                IsVerticale = true
            };
            chitarra = new Chitarra() { IsElettrica = true };

            Violino v = (Violino)violino;
            //trasformo la variabile violino nel tipo Violino e poi accedo a numero corde
            int num = ((Violino)violino).NumeroCorde;

            violino.Accorda();
            pianoforte.Accorda();
            chitarra.Accorda();

            v.Accorda();
            #endregion

            #region NULLABLE
            Console.Clear();
            
            int? a = 23;
            int? b = null;
            double? doubleNullable;
            DateTime? dataNullable;
            string? stringaNullable;

            if(a is int valueOfA)
            {
                Console.WriteLine("a è {0}", valueOfA);
            }
            else
            {
                Console.WriteLine("a non è un intero");
            }

            if (b.HasValue)
            {
                Console.WriteLine("b ha valore {0}", b.Value);
            }
            else
            {
                Console.WriteLine("b ha valore nullo {0}", b.GetValueOrDefault());
                try
                {
                    Console.WriteLine("b è null", b.Value);
                }
                catch (Exception)
                {
                    Console.WriteLine("Date un valore a b!");
                }
            }

            int c = 12;
            int? d;

            d = c;
            int f = (int)d;

            

            //da controllare
            if(c is int?)
            {
                Console.WriteLine("Il valore di c può essere nullable");
            }else
            {
                Console.WriteLine("c è un intero semplice");
            }

            #endregion


            ArrayList veicoli;
            Stack stack;
            Queue queue;
        }

        public static void Somma(int a, int b)
        {
            int c = a + b;
        }

        public static int Somma(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
