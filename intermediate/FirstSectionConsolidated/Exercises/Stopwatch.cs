using System;

namespace Exercises
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _finish;
        private bool _running = false;

        public TimeSpan Duration()
        {
            var duration = _finish - _start;
            Reset();

            return duration;
        }

        public void SetStart()
        {
            if (_running == true)
                throw new InvalidOperationException("Stopwatch is not yet running!");
        
            _start = DateTime.Now;
            _running = true;
        }
        public void SetStop()
        {
            if (_running == false)
                throw new InvalidOperationException("Stopwatch is not yet running!");

            _finish = DateTime.Now;
            _running = false;
        }

        public bool GetRunning()
        {
            return _running;
        }

        private void Reset()
        {
            _start = new DateTime();
            _finish = new DateTime();
        }
        
    }
}