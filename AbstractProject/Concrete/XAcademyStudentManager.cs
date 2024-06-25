using AbstractProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject.Concrete
{
    internal class XAcademyStudentManager(ICheckStudentService checkStudentService) : BaseStudentManager
    {
        private readonly ICheckStudentService _checkStudentService = checkStudentService;
        
        public override void Add(Student student)
        {
            if(_checkStudentService.CheckStudentAge((short)(DateTime.Now.Year - student.Birthday.Year)))
                base.Add(student);
            else
                throw new Exception("yash heddi uygun deyil");
        }
    }
}
