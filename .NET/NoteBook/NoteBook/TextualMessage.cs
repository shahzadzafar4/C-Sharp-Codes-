using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    class TextualMessage : IPageable
    {
        protected PageData myData;
        protected string message;

        public virtual IPageable Input()
        {
            Console.WriteLine("Please Input your name: ");
            myData.author = Console.ReadLine();
            Console.WriteLine("Please Input the Message Title: ");
            myData.title = Console.ReadLine();
            Console.WriteLine("Please Input the Message: ");
            message = Console.ReadLine();
            return this;
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("//----------------------------Message----------------------------//");
            Console.WriteLine("Title: " + myData.title);
            Console.WriteLine("Auther: " + myData.author);
            Console.WriteLine("Message: \n \n" + message);
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
