namespace AssignmentEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] empArray =
            {
                new Employee("Hugo","Lopez","1111","Full Time","50","Dev"){ },
                new Employee("Juan","Juarez","2222","Part Time","100","Tester"){ },
                new Employee("Leticia","Martinez","3333","Full Time","150","Infra"){ },
                new Employee("Mariana","Alamos","4444","Part Time","200","Manager"){ },
                new Employee("Martin","Montemayor","5555","Full Time","250","Lead"){ },
                new Employee("Pamela","Esparza","6666","Part Time","300","Talent"){ },
            };
            var result = (empArray).Where(t => t.EmployeeType.Equals("Part Time"));
            foreach(var empResult in result)
            {
                Console.WriteLine("The employee matched our query is: ");
                Console.WriteLine("Full Name: " + empResult.FirstName+ " " + empResult.LastName);
                Console.WriteLine("Employee ID: " + empResult.EmployeeID);
                Console.WriteLine("Salary: " + empResult.Salary);
                Console.WriteLine("Rol: " + empResult.Role);
                Console.WriteLine(("").PadRight(24, '-'));
            }
        }
    }
}