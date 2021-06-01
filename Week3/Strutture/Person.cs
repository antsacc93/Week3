using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Strutture
{
    public struct Person
    {
        public string Name;
        public string Surname;
        public int Age;
        
        //costruttore della struct
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

    }
}
