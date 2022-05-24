// See https://aka.ms/new-console-template for more information

//arrayList Demo

using System.Collections;
ArrayList al = new ArrayList();
al.Add("Hello");
al.Add(789);
al.Add(45.23f);
DateTime dob = new DateTime(2000, 1, 31);
al.Add(dob);
foreach (var item in al)
{
    Console.WriteLine(item);
}
Console.WriteLine(" Size of al is"+al.Count);
al.Remove("Hello");
Console.WriteLine(" After removed hello from collection");
foreach (var item in al)
{
    Console.WriteLine(item);
}
Console.WriteLine(" Size of al is" + al.Count);
Console.WriteLine(" Second element of the al "+al[1]);
Console.WriteLine( "Index position of 789 = "+al.IndexOf(789));

ArrayList al2 = new ArrayList();
al2.Add("Hemanth");
al2.Add("Bharath");
al2.Add("Tarun");

al.AddRange(al2);
Console.WriteLine(" ========================\nAfter Addrange of al2  collection");
foreach (var item in al)
{
    Console.WriteLine(item);
}

al.InsertRange(1, al2);
Console.WriteLine("--------------------\n After insertRange of 1 st index position of al2  collection");
foreach (var item in al)
{
    Console.WriteLine(item);
}
al.Clear();
Console.WriteLine(" after al .Clear \n -----------------\nSize of al is" + al.Count);

Console.WriteLine(  "Geetha is Available "+ al.Contains("Geetha"));