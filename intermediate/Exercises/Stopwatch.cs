using System;

namespace Exercises
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _finish;

        public TimeSpan Duration
        {
            get
            {
                var duration = _finish - _start;
                // var duration = timeSpan.Days/365;

                return duration;
            }
        }

        public void SetStart()
        {
            _start = DateTime.Now;
        }
        public DateTime GetStart()
        {
            return _start;
        }
        public void SetStop()
        {
            _finish = DateTime.Now;
        }

        public void Reset()
        {
            _start = new DateTime();
            _finish = new DateTime();
        }
        
    }
}