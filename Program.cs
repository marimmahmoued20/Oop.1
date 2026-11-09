
using System;

class Employee
{
    // Q1: Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Q3: Encapsulation
    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value >= 0)
            {
                salary = value;
            }
            else
            {
                Console.WriteLine("Salary cannot be negative!");
            }
        }
    }

    // Q2: Display Employee Information
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Employee Information:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Monthly Salary: " + Salary);
    }

    // Q2: Calculate Annual Salary
    public decimal CalculateAnnualSalary()
    {
        return Salary * 12;
    }
}

// Q4: Inheritance
class Manager : Employee
{
    public decimal Bonus { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine("Manager Information:");

        base.DisplayInfo();

        Console.WriteLine("Bonus: " + Bonus);
        Console.WriteLine("Annual Salary with Bonus: " +
            (CalculateAnnualSalary() + Bonus));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating Employee Objects
        Employee employee1 = new Employee()
        {
            Name = "Ahmed",
            Age = 25,
            Salary = 5000
        };

        Employee employee2 = new Employee()
        {
            Name = "Sara",
            Age = 30,
            Salary = 7000
        };

        // Creating Manager Object
        Manager manager = new Manager()
        {
            Name = "Mohamed",
            Age = 35,
            Salary = 10000,
            Bonus = 2000
        };

        // Display Employee 1
        employee1.DisplayInfo();
        Console.WriteLine("Annual Salary: " +
            employee1.CalculateAnnualSalary());

        Console.WriteLine("------------------------");

        // Display Employee 2
        employee2.DisplayInfo();
        Console.WriteLine("Annual Salary: " +
            employee2.CalculateAnnualSalary());

        Console.WriteLine("------------------------");

        // Display Manager
        manager.DisplayInfo();
    }
}
