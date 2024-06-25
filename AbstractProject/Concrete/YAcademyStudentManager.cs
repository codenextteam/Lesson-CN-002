using AbstractProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject.Concrete
{
    internal class YAcademyStudentManager(ICheckStudentService checkStudentService) : BaseStudentManager
    {
        private readonly ICheckStudentService _studentService = checkStudentService;
        public override void Add(Student student)
        {
            if (_studentService.CheckStudentAge((short)(DateTime.Now.Year - student.Birthday.Year)))
            {
                base.Add(student);
            }
            else
                throw new Exception("yash heddi uygun deyil");    
           
        }
    }
}
