using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter 1 for sum, 2 for sub, 3 for mul or 4 for div");
            int c = Convert.ToInt32(Console.ReadLine());

            if (c == 1)
            {
                int result = a + b;
                Console.WriteLine(result);

            }

            if (c == 2)
            {
                int result = a - b;
                Console.WriteLine(result);

            }

            if (c == 3)
            {
                int result = a * b;
                Console.WriteLine(result);

            }

            if (c == 4)
            {
                int result = a / b;
                Console.WriteLine(result);

            }

         //   else
         //   
         //       Console.WriteLine("Error:");

          //  }
            Console.ReadLine();
            
        }
    }
}
