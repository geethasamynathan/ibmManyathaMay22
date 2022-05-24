// See https://aka.ms/new-console-template for more information

//List<string> Accessories = new List<string>();
//Accessories.Add("CPU");
//Accessories.Add("Monitor");


using ListDemo;
List<Employee> employees = new List<Employee>() {
new Employee(){ EmpId = 1, Name = "Hemanth", City = "Pune", Salary = 56000 },
new Employee(){ EmpId = 3, Name = "Koushik", City = "Belgam", Salary = 53000 },
new Employee(){ EmpId = 2, Name = "Pravalika", City = "Hyderabad", Salary = 59000 },
};

int eid;
Console.WriteLine("Enter the Employee id details you need");
eid=Convert.ToInt32(Console.ReadLine());
foreach (var item in employees)
{
    //if(item.EmpId==eid)
    Console.WriteLine($"{item.EmpId}\t {item.Name}\t {item.City}\t {item.Salary}");
}

Console.WriteLine(" Total Employees"+employees.Count);
