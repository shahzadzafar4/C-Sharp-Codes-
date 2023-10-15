using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{

    class NoteBook
    {
        public const string IntroMessage = "***WelCome to the NoteBook version 1.0.0***";
        public const string OutroMessage = "***Thanks for using NoteBook version 1.0.0***";

        List<IPageable> pages = new List<IPageable>();

        public delegate void SimpleFunction(string command);
        public delegate void BooleanFunction(bool isOn);

        public event SimpleFunction ItemAdded, ItemRemoved, InputBadCommand;
        public event BooleanFunction loggingToggled;

        private Dictionary<string, SimpleFunction> commandLineArgs = new Dictionary<string, SimpleFunction>();
        public string show = "show", _new = "new", delete = "delete";


        public SimpleFunction this[string command]
        {
            get
            {
                return commandLineArgs[command];
            }
        }

        /// <summary>
        /// Create a new notebook with input key words for command instead of defauld 
        /// </summary>
        /// <param name="commandLine">index 0 Show, 1 = New, 2 = Delete. </param>
        public NoteBook()
        {
            commandLineArgs.Add(show, Show);
            commandLineArgs.Add(_new, New);
            commandLineArgs.Add(delete, Delete);
        }


        public NoteBook(params string[] commandLineKeywords) : this()
        {
            for (int i = 0; i < commandLineKeywords.Length; i++)
            {
                // if nothin is input jump into next junction

                if (commandLineKeywords[i] == "")    // string v = commandLineKeywords[i] = ""; ***That was to solve temporary error***
                {
                    continue;
                }
                switch (i)
                {
                    // show
                    case 0:
                        commandLineArgs.Remove(show);
                        commandLineArgs.Add(show = commandLineKeywords[i], Show);
                        break;

                    // new
                    case 1:
                        commandLineArgs.Remove(_new);
                        commandLineArgs.Add(_new = commandLineKeywords[i], New);
                        break;

                    // delete
                    case 2:
                        commandLineArgs.Remove(delete);
                        commandLineArgs.Add(delete = commandLineKeywords[i], Delete);
                        break;
                }

            }

        }
        private void New(string command)
        {
            switch (command)
            {
                case "":
                    Console.WriteLine("New Command***");
                    Console.WriteLine("Message        create new message page");
                    Console.WriteLine("List           create new list page");
                    Console.WriteLine("Image          create new image page");
                    break;

                case "message":
                    pages.Add(new TextualMessage().Input());
                    if(ItemAdded != null)
                    {
                        ItemAdded("Textual Message");
                    }
                    break;

                case "list":
                    pages.Add(new MessageList().Input());
                    if (ItemAdded != null)
                    {
                        ItemAdded("List of Messages");
                    }
                    break;

                case "image":
                    pages.Add(new Image().Input());
                    if (ItemAdded != null)
                    {
                        ItemAdded("Image");
                    }
                    break;

                default:
                    if(InputBadCommand != null)
                    {
                        InputBadCommand("You didn't enter message, list, image. Please try again ");
                    }
                    break;
            }
        }

        private void Show(string command)
        {
            switch (command)
            {
                case "":
                    Console.WriteLine("Show Command***");
                    Console.WriteLine("Pages                   Lists all the created pages");
                    Console.WriteLine("Id of a page            Display that page");

                    break;

                case "pages":
                    Console.WriteLine("//----------------------------Pages----------------------------//");
                    for (int i = 0; i <= pages.Count; i++)
                    {
                        Console.WriteLine("Id: " + i + pages[i].MyData.title);
                    }
                    break;

                default:
                    int number;

                    if (int.TryParse(command, out number))
                    {
                        Console.WriteLine("Showing Page " + number);
                        if (number < pages.Count)
                        {
                            pages[number].Output();
                        }
                        else
                        {
                            if (InputBadCommand != null)
                            {
                                InputBadCommand("Your numer is outside of the range pages number . Please try again ");
                            }
                        }
                    }
                    if (InputBadCommand != null)
                    {
                        InputBadCommand("You didn't enter number for pages. Please try again ");
                    }
                break;
            }
        }

        private void Delete(string command)
        {
            switch (command)
            {
                case "":
                    Console.WriteLine("Show Command***");
                    Console.WriteLine("All                  Delete all the created pages");
                    Console.WriteLine("Id of a page         Delete that page");

                    break;

                case "all":
                    if (ItemRemoved != null)
                    {
                        ItemRemoved("");
                    }
                    break;

                default:
                    int number;

                    if (int.TryParse(command, out number))
                    {
                        if(number<pages.Count)
                        {
                            pages.RemoveAt(number);
                            if (ItemRemoved != null)
                            {
                                ItemAdded(number + "");
                            }
                        }
                        else
                        {
                            if (InputBadCommand != null)
                            {
                                InputBadCommand("Your numer is outside of the range pages number . Please try again ");
                            }
                        }
                    }
                    if (InputBadCommand != null)
                    {
                        InputBadCommand("You didn't enter number for pages. Please try again ");
                    }

                break;
            }
        }
    }
}
