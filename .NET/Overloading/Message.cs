using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operators
{
    public class Message
    {
        string BodyOfText = "Here is the body of this text message...", title;
        int id;
        public const string COMPANY_NAME = "**Company NAme**";
        readonly string vision = "No. 1 in the world";
        public void SetMessage(string message)
        {

        }

        public static Message operator +(Message x, Message y)
        {
            Message message = new Message();
            message.BodyOfText = x.BodyOfText + y.BodyOfText;
            message.title = x.title + y.title;
            return message;
        }
    }
}