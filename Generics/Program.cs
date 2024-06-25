


using Generics;


List<string> names = new List<string>();
names.Add("");

MyGeneric<int> myGeneric = new MyGeneric<int>();


myGeneric.Add(34);
myGeneric.Add(42);
myGeneric.Add(47);
myGeneric.Add(65);


Console.WriteLine(myGeneric.values[0]);
Console.WriteLine(myGeneric.values[1]);
Console.WriteLine(myGeneric.values[2]);
Console.WriteLine(myGeneric.values[3]);

MyGeneric<string> nameList = new MyGeneric<string>();

nameList.Add("Murad");
nameList.Add("Orxan");
nameList.Add("Rumil");

foreach (var item in nameList.values)
{
    Console.WriteLine(item);
}






//MyGeneric<string> myGeneric2 = new MyGeneric<string>(); 



//var ve dynamic ferqi

//variable






