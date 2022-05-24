// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Two two=new Two();
//two.aa();
//two.bb();
//One One=new One();
//One.aa();

Three three = new Three();
three.aa();
three.bb();
three.ff();
 internal class One
{
    public void aa()
    {
        Console.WriteLine(" I am base class Method aa");
        cc();
    }
    private void cc()
    {
        Console.WriteLine(" I am base class private member function cc");
    }
    protected void dd()
    {
        Console.WriteLine("I am protected member function dd");
    }
}
class Two : One //Using : we are inheriting the properties of class one
{
    public void bb()
    {

        Console.WriteLine(" I am derived class Method bb");
        //dd();
    }
}
class Three : Two { 
    public void aa()
    {
        Console.WriteLine(" i amm aa from Class 3");
    }
public void ff()
    {
        Console.WriteLine(" I am ff from Class 3.");
        dd();
    }
}
