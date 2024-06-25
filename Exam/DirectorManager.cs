using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class DirectorManager : IPersonManager<Director>
    {
        public void Add(Director director)
        {
            Console.WriteLine($"{director.FullName} adli direktor elave olundu");
        }
    }
}
