


//Eli dayinin marketi

//nisye defteri

//adi: Nurlan Hesenov tel: 0554332323 aldigi mehsul : cola qiymet : 2.76 tarix 5.16.2024 yash: 18


//variables
//data type key = value
/* yazi tipleri - string */


string fullName = "Nurlan Hesenov";
short age = 18;
string phoneNumber = "+994554332323";
//camel case
//Common case
//upper case
//snike case
double unitPrice = 2.76;
string productName = "Cola";
DateTime buyDate = new DateTime(2024,5,16);
bool isPaid = false;

string[] lessons =  {"front", "backend", "full-stack" };

//Index lenght




//control flow => sert bloklari
//if else else if switch case

//c# operators
bool isLogin = true;

//if (isLogin == true)
//{
//    Console.WriteLine("Xosh gelmisiniz!");
//    Console.WriteLine("ad: " + fullName);
//    Console.WriteLine("yash: " + age);
//    Console.WriteLine("tel: " + phoneNumber);
//    Console.WriteLine("mehsul qiymeti: " + unitPrice);
//    Console.WriteLine("mehsul adi: " + productName);
//    Console.WriteLine("aldigi tarix: " + buyDate);
//    Console.WriteLine("odenilib: " + isPaid);

//}
//else
//{
//    Console.WriteLine("girish edin");
//}

short ageLimit = 56;

//if (ageLimit <= 18)
//{
//    Console.WriteLine("cizgi filmleri");
//}
//else if(ageLimit >18 && ageLimit <= 35)
//{
//    Console.WriteLine("dram filmleri");
//}
//else
//{
//    Console.WriteLine("yas heddine uygun film tapilmadi");
//}


switch (ageLimit)
{
    case 0:
        Console.WriteLine("yas azdi");
        break;
    case <=18:
        Console.WriteLine("cizgi filmleri");
        break;
    case <=30:
        Console.WriteLine("dram filmleri");
        break;
    default:
        Console.WriteLine("qeyd etdiyiniz yasa uygun netice tapilmadi");
        break;
}


