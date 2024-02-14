using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Family
    {
        public List<Person> people;

        public Family()
        { 
        people = new List<Person>();
        }
        public void AddPerson(string name, int age) 
        {
            Person person = new Person(name,age);
            people.Add(person);
        }
        public void SortFamily()
        {
            people.Sort();
        }
    }
}
