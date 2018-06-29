using System;

namespace Interfaces
{
    public class Processing : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status: PROCESSING...");
        }
    }
}