// See https://aka.ms/new-console-template for more information
using System.Collections;

/*
Hashtable ht=new Hashtable();
ht.Add(1, "Fransy");
ht[2] = "Tian";
ht.Add(3, "Himanshu");
ht.Add(4, "Hrithik");

foreach (DictionaryEntry item in ht)
{
    Console.WriteLine($"{ item.Key} - {item.Value}");
}

Console.WriteLine(ht.Contains("3"));

string[] names = new string[5];
ht.Values.CopyTo(names, 0);

Console.WriteLine(" Array values are");
foreach (var item in names)
{
    Console.WriteLine(item);
}

int [] numbers=new int[5];
ht.Keys.CopyTo(numbers, 0);

Console.WriteLine(" Array values (Keys) are");
foreach (var item in numbers)
{
    Console.WriteLine(item);
}
*/

SortedList<int,string> sl = new SortedList<int,string>();
sl.Add(7, "Saturday");
sl.Add(2, "Monday");
sl.Add(1, "Sunday");
sl.Add(3,"Tuesday");
sl.Add(5, "Thursday");
sl.Add(4, "Wednesday");
sl.Add(6, "Friday");
foreach (KeyValuePair<int, string>  item in sl)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}