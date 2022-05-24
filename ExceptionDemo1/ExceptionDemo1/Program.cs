// See https://aka.ms/new-console-template for more information
/*
//Example :1
int x, y, z;
try
{
    Console.WriteLine("Enter  2 integer values to divide");
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
    z = x / y;
    Console.WriteLine("diviosn x/y = " + z);
}
catch(FormatException fe)
{
    Console.WriteLine("Input is not an integer.Please enter the number");

}
catch(DivideByZeroException de)
{
    Console.WriteLine(" You are trying to divide by zero. thats not permittable");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/

/*
//Example: 2
// try catch Finally
int x, y, z;
try
{
    Console.WriteLine("Enter  2 integer values to divide");
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
    z = x / y;
    Console.WriteLine("diviosn x/y = " + z);

}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}
finally
{

    Console.WriteLine( "Good bye.");
}
*/
/*
//Example :3

static void Methoddivide()
{
    try
    {
        int x, y, z;
        Console.WriteLine("Enter  2 integer values to divide");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        z = x / y;
        Console.WriteLine("diviosn x/y = " + z);
    }
    catch(DivideByZeroException de)
    {
        Console.WriteLine("Specific Exception :" +de.TargetSite);
        throw de;
    }
    catch(Exception ex)
    {
        Console.WriteLine("General Exception " + ex.Message);
    }
    finally
    {
        Console.WriteLine(" Finally block of MethoDivide Function");
    }

}

try
{
    Methoddivide();
}
catch(Exception e)
{
    Console.WriteLine("Rethrown Exception :"+e.TargetSite);
}
finally
{
    Console.WriteLine( "Finally block of main");
}
*/

//Example :4 Custom Exception