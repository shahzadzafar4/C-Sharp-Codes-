using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
     class Program
    {
        static void Main(string[] args)
        {
            NoteBook notebook = new NoteBook();

            const string ExitProgramKeyword = "exit";
            string commandPrompt = "Please Enter " + notebook.show + ", " + notebook._new + ", or " + notebook.delete;

            Console.WriteLine(NoteBook.IntroMessage);
            Console.WriteLine(commandPrompt);

            string input = "";

            do
            {
                input = Console.ReadLine();

                string[] commands = input.Split();
                try
                {


                    // get the first command show, new, or delete
                    // and pass the second command to the function 
                    notebook[commands[0]]((commands.Length > 1) ? commands[1] : "");
                }
                catch (KeyNotFoundException)
                {
                    if(input !=ExitProgramKeyword)
                    { 
                    Console.WriteLine(commandPrompt);
                    }
                }
            }
            while (input != ExitProgramKeyword);

            Console.WriteLine(NoteBook.OutroMessage);



            Console.ReadLine();
        }
    }
}
