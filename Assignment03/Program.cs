using System.Globalization;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q3
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(1, "Ahmed", SecurityLevel.DBA, 5000m, new HireDate(30,1,2022), 'M');
            //EmpArr[1] = new Employee(2, "Khalid", SecurityLevel.Guest, 4000m, new HireDate(10, 5, 2019), 'M');
            //EmpArr[2] = new Employee(3, "Aliaa", SecurityLevel.Developer, 9000m, new HireDate(20, 3, 2020), 'F');
            #endregion

            #region Q1
            //for (int i = 0; i < 3; i++) Console.WriteLine(EmpArr[i]);
            #endregion

            #region Q2
            //HireDate hire = new HireDate(25, 09, 2024);
            //Console.WriteLine($"Hiring Date: {hire}");
            #endregion

            #region Q4
            //Array.Sort(EmpArr, Compare); // No boxing or unboxing occurs in this sorting process
            #endregion

            #region Q5
            //Console.WriteLine("Library Management System:");
            //Book ebook = new EBook("C# Programming", "Ahmed Khalid", "01110871987", 3.5);
            //Book printedBook = new PrintedBook("C++ Programming", "Khalid Ahmed", "01271189910", 400);
            //Console.WriteLine(ebook);
            //Console.WriteLine(printedBook);
            #endregion
        }
        public static int Compare(Employee e1, Employee e2)
        {
            return DateTime.Compare(
                new DateTime(e1.HireDate.Year, e1.HireDate.Month, e1.HireDate.Day),
                new DateTime(e2.HireDate.Year, e2.HireDate.Month, e2.HireDate.Day));
        }
    }
}

