using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practice2._4
{
    public class AlarmClock
    {
        public event EventHandler Tick;
        public event EventHandler Alarm;

        private Thread thread;
        private bool threadEnabled = true;

        public DateTime CurrentTime { get; set; }
        public DateTime AlarmTime { get; set; }

        public void Start()
        {
            threadEnabled = true;
            thread = new Thread(() =>
            {
                while (threadEnabled)
                {
                    Tick(this, new EventArgs());
                    if (CurrentTime == AlarmTime)
                    {
                        Alarm(this, new EventArgs());
                    }
                    Thread.Sleep(1000);
                    CurrentTime = CurrentTime.AddSeconds(1);
                }
            });
            thread.Start();
        }

        public void Stop()
        {
            threadEnabled = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock();
            clock.CurrentTime = new DateTime(2020, 9, 15, 15, 35, 0);
            clock.AlarmTime = new DateTime(2020, 9, 15, 15, 35, 10);
            clock.Tick += (s, e) =>
              {
                  Console.WriteLine("TikTok");
              };
            clock.Alarm += (s, e) =>
              {
                  Console.WriteLine("Ringinging");
              };
            clock.Start();
            Console.ReadKey();
            clock.Stop();
        }
    }
}
