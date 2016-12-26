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

            var result = Hailstone.Calculate(start, end);
            cycleValue = result.CycleValue;
            cycleLength = result.CycleLength;

            Console.WriteLine("Value: " + cycleValue);
            Console.Write("Longest Cycle: " + cycleLength.ToString());
            Console.ReadLine();
        }
    }
    class HailstoneResult
    {
        public int CycleValue { get; set; }
        public int CycleLength { get; set; }
    }

    class Hailstone
    {
        public static HailstoneResult Calculate(int s, int e)
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
            return new HailstoneResult
            {
                CycleValue = largestCounter,
                CycleLength = largestValue
            };
        }
    }
}
