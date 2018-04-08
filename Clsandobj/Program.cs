using System;

namespace Clsandobj
{
    class Message
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Clsandobj
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            msg.HelloWorld();
        }
    }
}
