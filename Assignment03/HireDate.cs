using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HireDate(int day, int month, int year)
        {
            if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1950 || year > DateTime.Now.Year)Console.WriteLine("Invalid date.");
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day:D}/{Month:D}/{Year}";
        }
    }
}
