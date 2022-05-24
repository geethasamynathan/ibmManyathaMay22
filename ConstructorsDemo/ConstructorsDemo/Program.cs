// See https://aka.ms/new-console-template for more information
using ConstructorsDemo;

Console.WriteLine("Hello, World!");
//approach:1
//Sample sample = new Sample();

//approach:2
Sample s1;
s1= new Sample();
s1.aa();


//approach :3

Sample sample2 = new Sample();
sample2.aa();
Sample sample3 = new Sample(456);
sample3.aa();
sample3.y = 900;
Sample sample4 = new Sample(sample3);
