using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorTest
{
     internal class Student
    {
        public Student(int id, string name, string username)
        {
            Console.WriteLine("qurucu method ishledi");
        }
        public Student(int id)
        {
            
        }
        public Student(int id, string name)
        {
            
        }
        
        public Student()
        {
            
        }

    }
}
