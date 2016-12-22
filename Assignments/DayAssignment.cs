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
    class DateTime
    {
        public static string Month(string m)
        {
            switch (m)
            {
                case "1": return "January";
                case "2": return "February";
                case "3": return "March";
                case "4": return "April";
                case "5": return "May";
                case "6": return "June";
                case "7": return "July";
                case "8": return "August";
                case "9": return "September";
                case "10": return "October";
                case "11": return "November";
                case "12": return "December";
                default: throw new ArgumentOutOfRangeException();
            }

        }

        public static string Day(string r)
        {
            switch (r)
            {
                case "0": return "Sunday";
                case "1": return "Monday";
                case "2": return "Tuesday";
                case "3": return "Wednesday";
                case "4": return "Thursday";
                case "5": return "Friday";
                case "6": return "Saturday";
                default: throw new ArgumentOutOfRangeException();
            }

        }


    }

    // Purpose: consolidate error checking into single class
    class Validation
    {
        // year validation
        public static int CheckYear(int y)
        {
            while (y < 1900 || y > 2100)
            {
                Console.Write("Enter a year between 1900 and 2100: ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            return y;
        }

        // month validation
        public static int CheckMonth(int m)
        {
            while (m < 1 || m > 12)
            {
                Console.Write("Enter a month between 1 and 12 ");
                m = Convert.ToInt32(Console.ReadLine());
            }
            return m;

        }

        // day validation
        public static int CheckDay(int d, int lyd, int m)
        {
            // leap year max date validation
            if (m == 2)
            {
                while (d < 1 || d > lyd)
                {
                    Console.Write("Enter a valid day ");
                    d = Convert.ToInt32(Console.ReadLine());
                }
            }
            // 30 day max validation
            else if (m == 4 || m == 6 || m == 9 || m == 10)
            {
                while (d < 1 || d > 30)
                {
                    Console.Write("Enter a valid day ");
                    d = Convert.ToInt32(Console.ReadLine());
                }
            }
            // 31 day max validation
            else
            {
                while (d < 1 || d > 31)
                {
                    Console.Write("Enter a valid day ");
                    d = Convert.ToInt32(Console.ReadLine());
                }

            }
            return d;

        }
        // leap year validation
        public static int CheckLeapYear(int y)
        {
            int days = 0;
            if (y % 4 == 0)
            {
                if ((y % 100 != 0) || (y % 100 == 0 && y % 400 == 0))
                    days = 29;
                else
                    days = 28;
            }
            else
                days = 28;
            return days;
        }
        // validates positive starting value
        public static int CheckStart(int s)
        {
            while (s < 1)
            {
                Console.Write("Enter a starting number greater than 0: ");
                s = Convert.ToInt32(Console.ReadLine());
            }
            return s;
        }
        // validates ending value
        public static int CheckEnd(int s, int e)
        {
            while (s >= e)
            {
                Console.Write("Enter an ending number greater than " + s + ": ");
                e = Convert.ToInt32(Console.ReadLine());
            }
            return e;
        }
    }
}
