using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
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
}
