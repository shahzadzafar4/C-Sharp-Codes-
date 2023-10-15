using Overloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operators
{
    class Program
    {
        void Main(string[] args)
        {
            Message message = new Message();
            Message message2 = new Message();
            message.BodyOfText = "Hello";
            message2.BodyOfText = "Hey";

            message = message + message2;

            Console.WriteLine(message.BodyOfText);
            Console.ReadLine();
        }
    }
}