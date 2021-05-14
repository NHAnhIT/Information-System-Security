using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TT
{
    class RunStopTime
    {
        static void Main(string[] args)
        {
            StopTime stopWatch = new StopTime();
            stopWatch.StartTime();
            while (true)
            {
                Thread.Sleep(1000);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key.Equals(ConsoleKey.R))
                    {
                        stopWatch.ResetTime();
                    }
                    if (key.Key.Equals(ConsoleKey.Spacebar))
                    {
                        stopWatch.PauseTime();
                    }
                }
                stopWatch.CountTime();
                stopWatch.ShowTime(20, 20);
            }
            Console.ReadLine();
        }

    }
}
