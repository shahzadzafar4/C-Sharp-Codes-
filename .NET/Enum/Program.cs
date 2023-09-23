using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        enum Months
        {
            January, Februuary, March, April, May , June, July,
            August, September, October, November, December
        }
        static void Main(string[] args)
        {
            Days today = Days.Monday;
            if (today == Days.Monday)
            {
                Console.WriteLine("It's monday...");
            }
            else if (today == Days.Tuesday)
            {
                Console.WriteLine("It's tuesday...");
            }


            Months Month = Months.January;
            if (Month == Months.January) 
            {
                Console.WriteLine("It's January...");
            }
            else if (Month == Months.Februuary)
            {
                Console.WriteLine("It's Febraury...");
            }


            Console.ReadLine();
        }
    } 
}

