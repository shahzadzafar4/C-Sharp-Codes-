using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method 1
            int[] number = new int[5];
            number[0] = 4;
            number[1] = 5;
            number[2] = 6;
            number[3] = 7;
            number[4] = 8;
            //  for (int i = 0; i < number.Length; i++) 
            //  { 
            // Console.WriteLine(number[i]);
            //   }

            foreach (int num in number)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

            // method 2

            int[] number1 = new int[5] { 45, 85, 66, 74, 88 };
            for (int i = 0; i < number1.Length; i++)
            {
                Console.WriteLine(number1[i]);
            }

            Console.ReadLine();


            // reverse of an array
             // System.Array.Reverse(number1);

            // method 3

            int[] number2 = { 455, 865, 636, 774, 882, 75856 };
            for (int i = 0; i < number2.Length; i++)
            {
                Console.WriteLine(number2[i]);
            }

            Console.ReadLine();


            // jagged array
            int[][] numbers = new int[5][];
            numbers[0] = new int[] { 45, 85, 66, 74, 88, 936 };
            numbers[1] = new int[] { 45, 85, 66, 74 };
            numbers[2] = new int[] { 45, 85, 66 };
            numbers[3] = new int[] { 45, 85, };
            numbers[4] = new int[] { 45, 85, 66, 74, 88, 36, 376489 };

            // assign and retrive a value 
            numbers[2][2] = 4;

            Console.WriteLine(numbers[4]);
            Console.ReadLine();

            // multi dimentional array 
            // rectangular array

            int[,] multiArray = new int[5, 3];
            int[,] array2D = new int[5, 3] {
            {1,2,3 },
            {2,3,4},
            {3,4,5},
            {4,5,6},
            {5,6,7}
            };

            // assign and retrive a value 
            array2D[3, 2] = 100;
            Console.WriteLine(array2D.Length);

            Console.WriteLine(array2D);
            Console.ReadLine();
        }
    }
}
