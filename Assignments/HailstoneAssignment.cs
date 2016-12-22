using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class HailstoneAssignment
    {
        public static void Run()
        {
            int start = 0;
            int end = 0;

            int cycleLength = 0;
            int cycleValue = 0;

            Console.Write("Enter the starting number of the range: ");
            start = Convert.ToInt32(Console.ReadLine());
            start = Validation.CheckStart(start);

            Console.Write("Enter the ending number of the range: ");
            end = Convert.ToInt32(Console.ReadLine());
            end = Validation.CheckEnd(start, end);

            cycleValue = Hailstone.HailstoneValue(start, end);
            cycleLength = Hailstone.HailstoneCounter(start, end);

            Console.WriteLine("Value: " + cycleValue);
            Console.Write("Longest Cycle: " + cycleLength.ToString());
            Console.ReadLine();
        }
    }
    class Hailstone
    {
        // returns largest counter in hailstone sequence
        public static int HailstoneCounter(int s, int e)
        {
            int n;
            int counter;
            int largestCounter = 0;

            for (int i = s; i < e + 1; i++)
            {
                n = i;
                counter = 0;
                while (n != 1)
                {
                    if (n % 2 == 0)
                        n /= 2;
                    else if (n % 2 != 0)
                        n = 3 * n + 1;
                    counter++;
                }
                if (counter > largestCounter)
                    largestCounter = counter;
            }
            return largestCounter;
        }

        // returns value of the largest counter in hailstone sequence
        public static int HailstoneValue(int s, int e)
        {
            int n;
            int largestValue = 0;
            int counter;
            int largestCounter = 0;

            for (int i = s; i < e + 1; i++)
            {
                n = i;
                counter = 0;
                while (n != 1)
                {
                    if (n % 2 == 0)
                        n /= 2;
                    else if (n % 2 != 0)
                        n = 3 * n + 1;
                    counter++;
                }
                if (counter > largestCounter)
                {
                    largestCounter = counter;
                    largestValue = i;
                }
            }
            return largestValue;
        }
    }
}
