using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
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

        // goldbach specific start validation
        public static int GoldbachCheckStart(int s)
        {
            while (s % 2 != 0 || s < 4)
            {
                Console.Write("Enter an even number greater than 4: ");
                s = Convert.ToInt32(Console.ReadLine());
            }
            return s;
        }

        // goldbach specific end validation
        public static int GoldbachCheckEnd(int s, int e)
        {
            while (e % 2 != 0 || e < s)
            {
                Console.Write("Enter an even number greater " + s + ": ");
                e = Convert.ToInt32(Console.ReadLine());
            }
            return e;
        }

        public static bool CheckPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;

            if (n % 2 == 0) return false; //Even number     

            for (int i = 3; i < n; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
