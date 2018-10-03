using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPSF.Variables;
using KPSF.Services;

using KRPC.Client.Services.Trajectories;
using System.Threading;
using KRPC.Client.Services.SpaceCenter;

namespace KPSF.Programs.Flight
{
    public static class Ascent
    {
        private static double WantedSpeed { get {
                return (Math.Pow(VesselVariables.altitude.Sea, 0.7) * 1.5) + 30;
            }
        }

        public static void Run(double Apoapsis)
        {
            Output.Output.WriteGame("Ascending to " + string.Format("{0:N0}", Apoapsis) + " meters.");
            Autostage.Engage();

            PID ascentPID = new PID(0.4, 0.001, 0.1, 0, 1);

            double highestQ = 0;

            while (true)
            {
                Thread.Sleep(20);

                GameConnection.vesselControl.Throttle = 1;
                if (VesselVariables.dynamicPressure.Q > highestQ + 1) { highestQ = VesselVariables.dynamicPressure.Q; }

                if (VesselVariables.dynamicPressure.Q < highestQ - 1) { break; }
                if (VesselVariables.altitude.Sea > Apoapsis) { break; }
            }

            Output.Output.WriteGameDebug("Following terminal velocity.");

            while(true)
            {
                if (VesselVariables.altitude.Sea > Apoapsis) { break; }
                GameConnection.vesselControl.Throttle = (float)ascentPID.Update(VesselVariables.speed.Terminal, VesselVariables.speed.Vertical);
            }

            Output.Output.WriteGameDebug("Completed.");
        }
    }
}
