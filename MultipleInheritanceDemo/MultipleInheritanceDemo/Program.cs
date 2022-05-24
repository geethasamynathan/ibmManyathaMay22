// See https://aka.ms/new-console-template for more information
using MultipleInheritanceDemo;

Child child =new Child();
child.aa();
child.bb();
child.cc();


IParent1 parent1 = new Child();
IParent2 parent2 = new Child();
parent1.Method1();
parent2.Method2();



