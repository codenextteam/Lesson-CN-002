using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class CustomerManager : IPersonManager<Customer>
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.FullName} adli {customer.Balance} mushteri elave olundu");
        }
    }
}
