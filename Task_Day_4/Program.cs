using System.Security.Cryptography;

namespace Task_Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Employee_1  = new Employee
            {
                Id = 1,
                Name = "Mina Youssef",
                Department = "web development",
                Salary = 10000,
                DOB = new DateTime(2003, 11, 19)
            };

            Employee Employee_2 = new Employee
            {
                Id = 2,
                Name = "Rofa Youssef",
                Department = "IT",
                Salary = 16000,
                DOB = new DateTime(2001, 9, 1)
            };
            Employee_1.PrintData();
            Employee_2.PrintData();
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime DOB { get; set; }
        public void PrintData()
        {
            Console.WriteLine("Employee ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine($"Salary: " + Salary);
            Console.WriteLine("Date of Birth: " + DOB.ToString("dd-MM-yyyy"));
            Console.WriteLine("********************************************");
        }
    }
}