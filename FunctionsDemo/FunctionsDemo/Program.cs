// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Addition();
Addition2(45, 89);
int x, y;
//Another way to call Addition2()
Console.WriteLine(" Enter the value a and y");
x=Convert.ToInt32(Console.ReadLine());
y=Convert.ToInt32(Console.ReadLine());
Addition2(x, y);
/// <summary>
/// example for Function without argument and without return
/// </summary>
 static void Addition()
{
    int num1, num2, additionResult;
    Console.WriteLine("Enter the 2 integer values form num1 and Num2");
        num1=Convert.ToInt32(Console.ReadLine());
    num2=Convert.ToInt32(Console.ReadLine());
    additionResult = num1 + num2;
    Console.WriteLine(" Addition Result = "+additionResult);
}

/// <summary>
/// example for Function with arguments and without return
/// </summary>
static void Addition2(int a, int b )
 
{
    int total = a + b;
    Console.WriteLine("Addition result ="+total);

}
