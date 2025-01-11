using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        char gender;
        public char Gender
        {
            get { return gender; }
             set
            {
                if (value != 'M' && value != 'F')Console.WriteLine("Gender must be 'M' or 'F'.");
                gender = value;
            }
        }
        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, char gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate}, Gender: {Gender}";
        }
    }

}
