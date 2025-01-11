using System.Globalization;

namespace Assignment03
{
    class Program
    {
        public static int Compare(Employee e1, Employee e2)
        {
            return DateTime.Compare(
                new DateTime(e1.HireDate.Year, e1.HireDate.Month, e1.HireDate.Day),
                new DateTime(e2.HireDate.Year, e2.HireDate.Month, e2.HireDate.Day));
        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee(1, "Ahmed", SecurityLevel.DBA, 5000m, new HireDate(30,1,2017), 'M');
            employees[1] = new Employee(2, "Khalid", SecurityLevel.Guest, 4000m, new HireDate(10, 5, 2019), 'M');
            employees[2] = new Employee(3, "Aliaa", SecurityLevel.Developer, 9000m, new HireDate(20, 3, 2020), 'F');

            Array.Sort(employees, Compare);

            foreach (var emp in employees) Console.WriteLine(emp);
            Console.WriteLine("\nLibrary Management System:");
            Book ebook = new EBook("C# Programming", "Ahmed Khalid", "01110871987", 3.5);
            Book printedBook = new PrintedBook("C++ Programming","Khalid Ahmed", "01271189910", 400);
            Console.WriteLine(ebook);
            Console.WriteLine(printedBook);
        }
    }
}

