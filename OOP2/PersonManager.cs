using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine($"{person.FullName} elave olundu");
        }
    }
}
