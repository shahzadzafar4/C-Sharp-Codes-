using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    class Image : IPageable
    {
        protected PageData myData;
        protected string asciiImage;

        public virtual IPageable Input()
        {
            Console.WriteLine("Please Input your name: ");
            myData.author = Console.ReadLine();
            Console.WriteLine("Please Input the Message Title: ");
            myData.title = Console.ReadLine();

            Console.WriteLine("Start inputing your image, press enter to add as many lines as you like");
            Console.WriteLine("Press Ctrl+D then enter to a single line to stop creating your image \n");
            bool finishedImage = false;
            while (!finishedImage)
            {
                string input = Console.ReadLine();
                // in C# && is short circuted
                if ((input.Length > 0) && (input[0]==4))
                {
                    finishedImage = true;
                }
                else
                {
                    asciiImage += "\t" + input + "\n";
                }
            }
            return this;
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("//----------------------------Message----------------------------//");
            Console.WriteLine("Title: " + myData.title);
            Console.WriteLine("Auther: " + myData.author);
            Console.WriteLine();
            Console.WriteLine(asciiImage);
            Console.WriteLine("//---------------------------------------------------------------//");
        }

        public PageData MyData
        {
            get
            {
                return MyData;
            }
            set
            {
                MyData = value;
            }
        }
    }
}
