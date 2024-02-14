using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string Name, int Age)
        {
            age = Age;
            name = Name;
        }
        public string Print(string Name, int Age)
        {
            return ($"Hello my name is {Name}! I am {Age} years old");
        }
    }
}
