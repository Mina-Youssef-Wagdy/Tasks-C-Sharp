namespace Task_4
{
   

        internal class Program
        {
            static void Main(string[] args)
            {
                #region Employee_1
                Employee Employee_1 = new Employee();

                Employee_1.Id = 1;
                Employee_1.Name = "Mina Youssef";
                Employee_1.Department = "web development";
                Employee_1.Salary = 10000;
                Employee_1.DOB = new DateTime(2003, 11, 19);

                #endregion

                #region Employee_2

                Employee Employee_2 = new Employee();

                Employee_2.Id = 2;
                Employee_2.Name = "Rofa Youssef";
                Employee_2.Department = "IT";
                Employee_2.Salary = 16000;
                Employee_2.DOB = new DateTime(2001, 9, 1);
                #endregion

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


