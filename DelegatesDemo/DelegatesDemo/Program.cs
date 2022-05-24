// See https://aka.ms/new-console-template for more information
using DelegatesDemo;




//MyDelegate mydelegate = new MyDelegate(sampleDelegateDemo.Add);
//////singlecast Delegate
////mydelegate(34, 23);

////Multicast Delegate
//mydelegate += sampleDelegateDemo.Difference;
//mydelegate(30, 20);


//mydelegate -= sampleDelegateDemo.Add;
//mydelegate(78, 45);
/*
PrintDelegate printDelegate = sampleDelegateDemo.printMessage;
printDelegate();
printDelegate.Invoke();*/

/*
Func ==>  it takes one or more input parameter and returns one out parameter
    Action ==> it takes one or more input parameter and returns nothing. maximum 16 input parameters
    Predicate  ==> maximumn 1 input parameter and ite will always return boolean value.

*/


AddNumbersDelegate delegate1 =new AddNumbersDelegate(DelegateTypes.AddNumbers);
AddNumbersDelegate2 delegate2 = new AddNumbersDelegate2(DelegateTypes.AddNumbersResult);
CheckStringLength CheckString = new CheckStringLength(DelegateTypes.CheckLength);

Console.WriteLine(  "result ="+ delegate1(23, 56.34f, 67.8989));
delegate2(45, 78.34f, 56.34353);
Console.WriteLine(   CheckString("Geetha"));