using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class DayAssignment
    {
        public static void Run()
        {
            int year;
            int month;
            int day;
            int leapYearDay;
            string dayOfWeek;

            Console.Write("Enter a year between 1900 and 2100: ");
            year = Convert.ToInt32(Console.ReadLine());
            year = Validation.CheckYear(year);
            leapYearDay = Validation.CheckLeapYear(year);

            Console.Write("Enter a month between 1 and 12 ");
            month = Convert.ToInt32(Console.ReadLine());
            month = Validation.CheckMonth(month);

            Console.Write("Enter a day ");
            day = Convert.ToInt32(Console.ReadLine());
            day = Validation.CheckDay(day, leapYearDay, month);

            dayOfWeek = Convert.ToString(Day.DayCalculation(year, month, day));
            dayOfWeek = DateTime.Day(dayOfWeek);

            Console.Write("The day is " + dayOfWeek);
            Console.ReadLine();
        }
    }
    class Day
    {
        public static int DayCalculation(int year, int month, int day)
        {
            // calculation variables part 1
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            // calculation variables part 2
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;
            int r = 0;

            // convert user inputted variable to correct algorithm format
            year = Year(month, year);
            a = Month(month);
            b = day;
            c = year % 100;
            d = year / 100;

            // calculate weekday
            w = (13 * a - 1) / 5;
            x = c / 4;
            y = d / 4;
            z = w + x + y + b + c - 2 * d;
            r = z % 7;
            r = (r + 7) % 7;

            return r;

        }

        public static int Month(int m)
        {
            return ((m + 9) % 12) + 1;
        }

        public static int Year(int m, int y)
        {
            if (m == 1 || m == 2)
            {
                y -= 1;
            }
            return y;
        }
    }
}
