using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
     class MessageList : TextualMessage
    {
        private enum BulletType { Dashed, Numbered, Star }
        private BulletType bulletType;

        public override IPageable Input()
        {
            Console.WriteLine("Please Input your name: ");
            myData.author = Console.ReadLine();
            Console.WriteLine("Please Input the Message Title: ");
            myData.title = Console.ReadLine();
            Console.WriteLine("What type of bullet point would you like to use?? ");
            Console.WriteLine("Please Enter dashed, numbered or star***");

            bool goodInput = false;
            while (!goodInput)
            {
                goodInput = true;

                switch(Console.ReadLine())
                {
                    case "dashed":
                        bulletType = BulletType.Dashed;
                        break;

                    case "numbered":
                        bulletType = BulletType.Numbered;
                        break;

                    case "star":
                        bulletType = BulletType.Star;

                        break;

                    default:
                        Console.WriteLine("''Error'' Please Enter dashed, numbered or star***");
                        goodInput = false;
                        break;
                }
            }

            Console.WriteLine("Start typeing your list,  Every time you press enter, a new item will be created:");
            Console.WriteLine("Press Enter with a blank list type of end your list \n");

            // write list 
            bool finishList = false;
            int i = 1;
            while (!finishList)
            {
                string input = Console.ReadLine();

                // if they enter nothing our list will be finished 

                if (input=="")
                {
                    finishList = true;
                }
                else
                {
                    switch(bulletType)
                    {
                        case BulletType.Dashed:
                            message += "_ " + input + " \n";
                            break;
                        case BulletType.Numbered:
                            message += i + ". " + input + " \n";
                            break;
                        case BulletType.Star:
                            message += "* " + input + " \n";
                            break;
                    }
                }

            }


            return this;
        }
    }
}
