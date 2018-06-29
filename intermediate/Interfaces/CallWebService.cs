using System;

namespace Interfaces
{
    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling a web service to notify video readiness...");
        }
    }
}