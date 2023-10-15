using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    class NoteBookLogger
    {
        private NoteBook trackkedNoteBook;
        private bool Logging = true;

        NoteBookLogger(NoteBook trackkedNoteBook)
        {
            this.trackkedNoteBook = trackkedNoteBook;
        }

        private void PrintAdded(string typeItemAdded)
        {

        }

        private void PrintDeleted(string idOfDeleted)
        {

        }
        private void IncorrectCommand(string MessageToPrint)
        {

        }

        public void ToggleLogging(bool isLoggingon)
        {

        }

        private void Attach()
        {

        }

        private void Detach()
        {

        }
    }
}
