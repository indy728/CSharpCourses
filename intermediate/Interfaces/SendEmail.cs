using System;

namespace Interfaces
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending confirmation email to owner...");
        }
    }
}