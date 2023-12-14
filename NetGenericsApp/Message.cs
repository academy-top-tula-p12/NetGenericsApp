using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGenericsApp
{
    class Message
    {
        public string? Text { get; }
        public Message(string? text)
        {
            Text = text;
        }
    }

    class EmailMessage : Message
    {
        public EmailMessage(string? text) : base(text) { }
    }

    class SmsMessage : Message
    {
        public SmsMessage(string? text) : base(text) { }
    }

    class Messanger<T> where T : Message
    {
        void SendMessage(T message)
        {
            Console.WriteLine(message.Text);
        }
    }

    class MyClass<T, U> 
        where T : class
        where U : Message
    {

    }

    // where T : user_classes, users_interfaces,
    // keywords: class, struct, new()
}
