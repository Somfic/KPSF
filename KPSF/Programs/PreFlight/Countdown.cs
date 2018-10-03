using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KPSF.Programs.PreFlight
{
    /// <summary>
    /// Simple class to count down, nothing more, nothing less.
    /// </summary>
    public static class Countdown
    {
        /// <summary>
        /// Start the countdown with the number of seconds, if none given, defaults to 3.
        /// </summary>
        /// <param name="countdown">Amount of seconds to count down.</param>
        public static void Run(int countdown = 3)
        {

            //Count down from the given parameter.
            for (int i = countdown; i >= 0; i -= 1)
            {
                Thread.Sleep(1000);
                Output.Output.WriteGame("T - " + i);
            }

            Thread.Sleep(1000);
        }
    }
}
