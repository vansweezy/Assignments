using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class EasterSundayAssignment
    {
        public static void Run()
        {
            // Easter Sunday Assignment
            int year;
            string month;
            int day;

            Console.Write("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToString(EasterSunday.EasterSundayMonth(year));
            month = DateTime.Month(month);
            day = EasterSunday.EasterSundayDay(year);
            Console.WriteLine("In " + year.ToString() + " Easter Sunday is on " +
                day.ToString() + " " + month);
            Console.ReadLine();

        }
    }

    class EasterSunday
    {

        public static int EasterSundayMonth(int y)
        {
            // Easter Sunday Computation
            int a = y % 19;
            int b = y / 100;
            int c = y % 100;
            int d = b / 4;
            int e = b % 4;
            int g = (8 * b + 13) / 25;
            int h = (19 * a + b - d - g + 15) % 30;
            int j = c / 4;
            int k = c % 4;
            int m = (a + 11 * h) / 319;
            int r = (2 * e + 2 * j - k - h + m + 32) % 7;
            int n = (h - m + r + 90) / 25;
            int p = (h - m + r + n + 19) % 32;

            // returns numerical month
            return n;
        }

        public static int EasterSundayDay(int y)
        {
            // Easter Sunday Computation
            int a = y % 19;
            int b = y / 100;
            int c = y % 100;
            int d = b / 4;
            int e = b % 4;
            int g = (8 * b + 13) / 25;
            int h = (19 * a + b - d - g + 15) % 30;
            int j = c / 4;
            int k = c % 4;
            int m = (a + 11 * h) / 319;
            int r = (2 * e + 2 * j - k - h + m + 32) % 7;
            int n = (h - m + r + 90) / 25;
            int p = (h - m + r + n + 19) % 32;

            // returns numerical day
            return p;
        }
    }
}
