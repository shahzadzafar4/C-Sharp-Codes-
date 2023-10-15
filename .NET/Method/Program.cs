using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
     class Program
    {
        static void Main(string[] args)
        {
            // method with ref key word
            Message message = new Message();
            string PieceOfText = "Hello:";
            message.SetMessage(ref PieceOfText);
            Console.WriteLine(PieceOfText);
            Console.ReadLine();

            // method with out key word 
            Message message1 = new Message();
            string text;
            message1.text(out text);
            Console.WriteLine(text);
            Console.ReadLine();

            
           
            // overloaded method
           // message.SetMessage(PieceOfText, "What's up");
        }
    }
}
