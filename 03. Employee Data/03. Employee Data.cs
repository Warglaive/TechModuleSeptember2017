using System;

namespace _03.Employee_Data
{
    public class Program
    {
       public static void Main()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var id = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}" +
                Environment.NewLine +
                "Age: {1}" + Environment.NewLine +
                "Employee ID: {2:d8}" +
                Environment.NewLine+ "Salary: {3:f2}",name, age, id, salary);
        }
    }
}