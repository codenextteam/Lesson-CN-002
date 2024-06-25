

//classes


//DRY - Dont Repeat Yourself
//object student = new 
//{
//    firstName = 23,
//    lastName = "Khalilov",
//    phoneNumber = "+99455322222",
//    age = 23,
//    faculty = "Computer Science",
//    isGraduate = false
//};
//object student2 = new
//{
//    firstName = "EbdulHemid",
//    lastName = "Khalilov",
//    phoneNumber = "+99455322222",
//    age = 23,
//    faculty = "Computer Science",
//    isGraduate = false
//};

//string firstName = "EbdulHemid";
//string lastName = "Khalilov";
//short age = 23;
//string faculty = "Computer";
//bool isIntern = false;
//decimal scoreMoney = 0;
//bool isGraduate = false;


//string firstName2 = "Khalil";
//string lastName2 = "Khalilov";
//short age2 = 23;
//string faculty2 = "Computer";
//bool isIntern2 = true;
//decimal scoreMoney2 = 30;
//bool isGraduate2 = false;




////instance
//Student studentOne = new() 
//{
//    FirstName = "Rumil",
//    LastName = "Musayev",
//    Age = 17,
//    IsGraduate = false,
//    IsIntern = true,
//    ScoreMoney = 156.76m,
//};

//Student studentTwo = new()
//{
//    FirstName = "Cabbar",
//    LastName = "Huseynzade",
//    Age = 20,
//    IsGraduate = false,
//    IsIntern = false,
//    ScoreMoney = 0,
//};

//Student studentThree = new()
//{
//    FirstName = "Gulshan",
//    LastName = "Ezimli",
//    Age = 22,
//    IsGraduate = true,
//    IsIntern = true,
//    ScoreMoney = 75,
//};

//Student[] students = {studentOne, studentTwo, studentThree };

//setter
//studentOne.FirstName = "Rumil";
//studentOne.LastName = "Musayev";
//studentOne.Age = 17;
//studentOne.IsGraduate = false;
//studentOne.IsIntern = true;
//studentOne.ScoreMoney = 156.76m;



//for (int i = 0; i < students.Length; i++)
//{
//Console.WriteLine($"ad: {students[i].FirstName} soyad: {students[i].LastName} yash: {students[i].Age} telebedir: {students[i].IsGraduate} teqaudlu: {students[i].IsIntern} teqaudMaashi: {students[i].ScoreMoney} Azn");

//}

//getter
Teacher teacherOne = new()
{
    FirstName = "Abulfaz",
    LastName = "Aliyev",
    Age = 56,
    ScientificDegree = "Prefessor",
    WeeklyClassHours = 18,
};
Teacher teacherTwo = new()
{
    FirstName = "Zarifa",
    LastName = "Mammadova",
    Age = 59,
    ScientificDegree = null, 
    WeeklyClassHours = 22,

};
Teacher teacherThree = new()
{ 
FirstName = "Adil",
LastName = "Abilov",
Age = 32,
ScientificDegree = "Doctor of Philosophy",
WeeklyClassHours = 40,
};
Teacher[] teachers = {teacherOne, teacherTwo, teacherThree};

for (int i = 0; i < teachers.Length; i++)
{
    Console.WriteLine($"ad: {teachers[i].FirstName} soyad:{teachers[i].LastName}");
        };