using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Message
    {
        string BodyOfTexy = " Shahzad Zafar", Text = "You will achieve everything soon....";
        const string cpmpanyName = "ABC Industries";
        readonly string CompanyVision = "World's no 1 company";

        public void SetMessage (ref string message)
        {
            message += BodyOfTexy;
        }
        public void text (out string message1)
            {
            message1 = Text;

        }


        // overloaded method
        //  public void SetMessage(string message, string whattoset)
        //  {
        //      message = whattoset;
        //   }
    }
}
