using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_and_switch
{
    internal class Program
    {
        enum Days { monday, tuesday, wednesday, thursday, friday, saturday, sunday }
        static void Main(string[] args)
        {
            // if else statement
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());  

            if (num < 0 ) 
            {
                Console.WriteLine("The number is -ve");
            }
            else if (num > 0 ) 
            {
                Console.WriteLine("The number is +ve");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
            Console.ReadLine();

            // switch statement

            Days today = Days.sunday;
            switch (today) 
            {
            case Days.sunday:
                    Console.WriteLine("It's sunday");
                    break;
                         case Days.monday:
                    Console.WriteLine("It's monday");
                    break;
                case Days.tuesday:
                    Console.WriteLine("It's tuesday");
                    break;
                case Days.wednesday:
                    Console.WriteLine("It's wednesday");
                    break;
                case Days.thursday:
                    Console.WriteLine("It's thursday");
                    break;
                case Days.friday:
                    Console.WriteLine("It's friday");
                    break;
                case Days.saturday:
                    Console.WriteLine("It's saturday");
                    break;
                default:
                    Console.WriteLine("None of them");
                    break;

            }
            Console.ReadLine();
        }
    }
}
