﻿using System.Threading.Tasks;

namespace UniversalTCPClient
{
    public static class Task
    {

        public static System.Threading.Tasks.Task Delay(double milliseconds)
        {
            var tcs = new TaskCompletionSource<bool>();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += (obj, args) => tcs.TrySetResult(true);
            timer.Interval = milliseconds;
            timer.AutoReset = false;
            timer.Start();
            return tcs.Task;
        }
    }
}
