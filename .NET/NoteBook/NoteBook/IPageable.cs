using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    public struct PageData
    {
        public string title, author;
    }

    public interface IPageable
    {
        PageData MyData { get; set; }

        // How we are going to input our item
        IPageable Input();

        // How do we do out put 
        void Output();

    }
}
