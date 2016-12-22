using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class GoldbachAssignment
    {
        public static void Run()
        {
            int start;
            int end;

            int a = 0;
            int b = 0;

            // Goldbach's Conjecture Assignment
            
            Console.Write("Enter the lower limit: ");
            start = Convert.ToInt32(Console.ReadLine());
            start = Validation.GoldbachCheckStart(start);

            Console.Write("Enter the upper limit: ");
            end = Convert.ToInt32(Console.ReadLine());
            end = Validation.GoldbachCheckEnd(start, end);

            for (int i = start; i <= end; i += 2)
            {
                for (int j = 2; j <= i/2; j++)
                {                                                                       
                    if (Validation.CheckPrime(j) == true)
                    {
                        b = i - j;
                        if (Validation.CheckPrime(b) == true)
                        {
                            a = j;
                            Console.WriteLine(i.ToString() + " = " + a.ToString() + " + " + b.ToString());                            
                        }
                        else
                            continue;                                                 
                    }                   
                }
            }
            Console.ReadLine();
            
        }     
        
        
    }
}
