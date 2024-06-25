using AbstractProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject.Abstract
{
    internal abstract class BaseStudentManager : IBaseManager<Student>
    {
        public virtual void Add(Student student)
        {
          
            Console.WriteLine($" {student.FullName} adli telebe elave olundu");
        }

        public void Delete(Student t)
        {
            throw new NotImplementedException();
        }

        public void Update(Student t)
        {
            throw new NotImplementedException();
        }
    }
}
