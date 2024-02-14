using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                family.AddPerson(name, age);
            }
            family.SortFamily();
            Console.ReadKey();
        }
    }
}
