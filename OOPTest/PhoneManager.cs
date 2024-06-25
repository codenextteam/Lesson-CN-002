using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    internal class PhoneManager : ProductManager
    {
        public void AddPhone(Phone phone)
        {
            Console.WriteLine($"{phone.ProductName} elave olundu");
        }
    }
}
