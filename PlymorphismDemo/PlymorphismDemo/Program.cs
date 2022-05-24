// See https://aka.ms/new-console-template for more information
using PlymorphismDemo;


//FunctionOverloadingDemo functionOverloadingdemo = new FunctionOverloadingDemo();
//Console.WriteLine(functionOverloadingdemo.Add(45, 67, 25));
//Console.WriteLine(functionOverloadingdemo.Add(45, 67));
//Console.WriteLine(functionOverloadingdemo.Add(45.4544, 67.565, 25));

FunctionOverridingDemo overridingDemo = new FunctionOverridingDemo();
overridingDemo.aa();

Sample sample = new Sample();
sample.aa();
FunctionOverridingDemo demo = new Sample();
demo.aa();