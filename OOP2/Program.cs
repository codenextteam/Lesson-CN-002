

using OOP2;

Student student1 = new Student();

student1.FullName = "Ramin";

student1.PhoneNumber = "+994556767";
student1.Point = 45.7;
student1.AgeControl(10);

Teacher teacher1 = new Teacher();
teacher1.FullName = "Murad";
teacher1.PhoneNumber = "+994553443232";
teacher1.Majority = "C#";

Director director1 = new Director();
director1.FullName = "Abbas";
director1.Directory = "Bash muellim";

PersonManager personManager = new PersonManager();

//Polymorphism => cox bicimlilik
personManager.Add(student1);
personManager.Add(teacher1);
personManager.Add(director1);



