using System;

namespace Stopwatch2
{
    public class Stopwatch2
    {
        private DateTime startTime;
        private DateTime pausedTime;
        private TimeSpan pausedSpan;

        private bool isPaused;
        private bool isStarted;

        public void Start()
        {
            if (isPaused)
            {
                isPaused = false;
                pausedSpan += DateTime.Now - pausedTime;
                return;
            }

            if (isStarted)
            {
                Console.WriteLine("You cannot start the Stopwatch a second time. You will have to stop it in order to start it again.");
                return;
            }

            isStarted = true;
            pausedSpan = new TimeSpan();
            startTime = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            if (!isStarted)
            {
                throw new Exception("You cannot stop it before you start it.");
            }

            var elapsedTime = CurrentTime;
            isStarted = false;
            return elapsedTime;
        }

        public TimeSpan Pause()
        {
            if (!isStarted || isPaused)
            {
                throw new Exception("You cannot pause it before you start it or if you are already paused.");
            }
            pausedTime = DateTime.Now;
            isPaused = true;
            return CurrentTime;

        }

        public bool IsPaused()
        {
            return isPaused;
        }

        public TimeSpan CurrentTime
        {
            get
            {
                if (!isStarted)
                {
                    return new TimeSpan();
                }

                return DateTime.Now - startTime - pausedSpan;
            }
        }
    }

}