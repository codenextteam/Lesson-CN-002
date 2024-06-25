using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class CashierManager : IPersonManager<Cashier>
    {
        public void Add(Cashier cashier)
        {
            Console.WriteLine($"{cashier.FullName} adli {cashier.CashierCode} kassir elave olundu");
        }
    }
}
