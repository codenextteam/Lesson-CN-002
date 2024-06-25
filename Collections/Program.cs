

//string[] names = new string[] { "Murad", "Ebdulcemil", "Rumil"};
//names[3] = "Orxan";

//string[] names = new string[5];
//names[0] = "Murad";
//names[1] = "Ebdulcemil";
//names[2] = "Sureyya";
//names[3] = "Gulshen";
//names[4] = "Fereh";
//names = new string[8];
//names[5] = "Rumil";

//Console.WriteLine(names[0]);
//Console.WriteLine(names[1]);
//Console.WriteLine(names[2]);
//Console.WriteLine(names[3]);
//Console.WriteLine(names[4]);
//Console.WriteLine(names[5]);




//Console.WriteLine(names[3]);

//Collections 

List<string> nameList = new List<string>();
nameList.Add("Murad");
nameList.Add("Rumil");
nameList.Add("Sureyya");
nameList.Add("Gulshen");

nameList.Remove(nameList[1]);
//nameList.Capacity = 30;
//Console.WriteLine(nameList.Contains(nameList[2]));


//Console.WriteLine(nameList[0]);
//Console.WriteLine(nameList[1]);
//Console.WriteLine(nameList[2]);

foreach (var item in nameList)
{
    Console.WriteLine(item);
}


Console.WriteLine(nameList.Count);

