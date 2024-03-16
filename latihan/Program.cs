using System;
public class Employee
{
    private string name; 
    public int Age { get; set; } 

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Name = "Zaki";
        emp.Age = 20;

        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Employee Age: " + emp.Age);
    }
}
