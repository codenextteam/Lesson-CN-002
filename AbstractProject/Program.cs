



using AbstractProject.Concrete;

Student student1 = new() { Id = 1, FullName = "Cinare Ismayilli", Birthday = new DateTime(2002, 12, 27) };


Student student2 = new() { Id = 2, FullName = "Vasif Zahirov", Birthday = new DateTime(2004, 10, 17) };
Student student3 = new() { Id = 2, FullName = "Kenan ehmedov", Birthday = new DateTime(2012, 09, 11) };
CheckStudentManager checkStudentManager = new CheckStudentManager();

XAcademyStudentManager xAcademyManager = new XAcademyStudentManager(checkStudentManager);
YAcademyStudentManager yAcademyStudentManager = new YAcademyStudentManager(checkStudentManager);
ZAcademyStudentManager zAcademyStudentManager = new ZAcademyStudentManager();
zAcademyStudentManager.Add(student3);
yAcademyStudentManager.Add(student2);
xAcademyManager.Add(student1);



