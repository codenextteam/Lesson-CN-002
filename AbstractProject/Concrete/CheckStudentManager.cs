using AbstractProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject.Concrete
{
    internal class CheckStudentManager : ICheckStudentService
    {
        public bool CheckStudentAge(short age)
        {
            return age > 18;
        }
    }
}
