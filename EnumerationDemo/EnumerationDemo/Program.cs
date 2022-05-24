
// See https://aka.ms/new-console-template for more information
/*
//Example:1

 int x = (int)Season.winter;
 Console.WriteLine(" The value of winter Season is " + x);
int y = (int)Season.spring;
Console.WriteLine(" The value of Spring Season is " + y);
int a = (int)Season.summer;
Console.WriteLine(" The value of Summer Season is " + a);
int b = (int)Season.fall;
Console.WriteLine(" The value of Fall Season is " + b);

public enum Season { winter='c', spring, summer=201, fall }
*/
/*
//Example :2

Console.WriteLine(" GetNames()");
foreach (string s in Enum.GetNames(typeof(Days)))
{
    Console.WriteLine(s);
}
Console.WriteLine(" GetValues()");

foreach (int  d in Enum.GetValues(typeof(Days)))
{
    Console.WriteLine(d);
}
public enum Days { Sun,Mon,Tue,Wed,Thu,Fri, Sat}

*/

using EnumerationDemo;
Sample sample = new Sample();
sample.method1();