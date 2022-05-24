

// See https://aka.ms/new-console-template for more information
using StaticNonstaticFunctionDemo;

Console.WriteLine("Hello, World!");
FunctionDemo1.Method2();
// calling non static function using class object
FunctionDemo1 functionDemo1 = new FunctionDemo1();
functionDemo1.Method1();
