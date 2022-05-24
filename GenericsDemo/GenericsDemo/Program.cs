// See https://aka.ms/new-console-template for more information
/*
//Generic Method with same datatype
int a = 900; 
int b = 200;

string x1 = "Hello";
string y1 = "Welcome";
Console.WriteLine($" Before swap a={a} \t b={b} ");
Console.WriteLine($" Before swap x1={x1} \t y1={y1} ");
//calling Generic Method
swap<int>(ref a, ref b);
swap<string> (ref x1,ref  y1);

Console.WriteLine($" After swap a={a} \t b={b} ");
Console.WriteLine($" After swap x1={x1} \t y1={y1} ");

//example for Generic Method
static void swap<T> (ref T x, ref T y)
{
    T tmp;
    tmp= x;
    x= y; 
    y= tmp;
}
*/
/*
//Example:2

//exmaple for Generic Method for different datatype:

static void GenericMethod1<Type1, Type2>(Type1 x, Type2 y)
{
    Console.WriteLine($" Type1 variable value {x} \t type2  value ={y}");
}


GenericMethod1<int, string>(56, "Priyanshi");
GenericMethod1<char, float>('A', 56.343435f);

   */
/*
//Example :3 Generic Class

using GenericsDemo;

GenericDemoClass<int,string> demo=new GenericDemoClass<int, string>(101, "Geetha");
demo.Display();
GenericDemoClass<int, int> demo2 = new GenericDemoClass<int, int>(100, 200);
demo2.Display();

*/
/*
//example :4 Generic Delegate

using GenericsDemo;
Numberchanger<int> numberchanger1 = new Numberchanger<int>(TestDelegateDemo. AddNum);
Numberchanger<int> numberchanger2 = new Numberchanger<int>(TestDelegateDemo.MultiplyNum);
Console.WriteLine(  numberchanger1(400));
Console.WriteLine(  numberchanger2(67));

*/

using GenericsDemo;
//example :5
//Compare 2 values
CompareTwoObjects compare = new CompareTwoObjects();
Console.WriteLine("Both the values are  equal :" + compare.AreEqual<int>(2,5));
Console.WriteLine(  "Both the values are  equal :"+ compare.AreEqual<string>("A","A"));