using System;

namespace Exercises
{
    public class StackOverflow
    {
        public string Title;
        public string Description;
        private DateTime _createdAt = DateTime.Now;
        private int _votes = 0;
        
        public void Upvote()
        {
            _votes += 1;
        }
        public void Downvote()
        {
            _votes -= 1;
        }

        public void GetPostDetails()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Created At: " + _createdAt);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Votes: " + _votes);
        }
    }
}