﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KPSF.Services;
using KPSF.Variables;

namespace KPSF.Programs.Flight
{
    /// <summary>
    /// Landing program.
    /// </summary>
    public static class Landing
    {
        private static double g { get { return GameConnection.vessel.Orbit.Body.SurfaceGravity; } }
        private static double maxDec { get { return 0.9 * ((GameConnection.vessel.AvailableThrust / GameConnection.vessel.Mass) - g); } }
        private static double stopDistance { get { return 10 + Math.Pow(VesselVariables.speed.Vertical, 2) / (2 * maxDec); } }
        private static double idealThrottle { get { return stopDistance / VesselVariables.altitude.Surface; } }
        private static double impactTime { get { return (VesselVariables.altitude.Surface-10) / Math.Abs(VesselVariables.speed.Vertical); } }

        /// <summary>
        /// Lands the vessel, untargeted.
        /// </summary>
        public static void Run()
        {   
            //Create a new PID for the controlled decent part.
            PID pid = new PID(0.06, 0.0001, 0.1, 0, 1);

            //Print out we're ready to burn.
            Output.Output.WriteGame("Awaiting freefall.");

            //Wait until we're actually going downwards.
            while (VesselVariables.speed.Vertical > -1) {
                Thread.Sleep(20); //Don't overkill it.
            }

            //Print out we're ready to burn.
            Output.Output.WriteGame("Preparing for hoverslam.");

            //Free fall until we're at 80 needed throttle%.
            while (idealThrottle < 0.8) {

                //Point retrograde.
                GameConnection.vesselControl.SAS = true;
                GameConnection.vesselControl.SASMode = KRPC.Client.Services.SpaceCenter.SASMode.Retrograde;

                //If somehow our stop-distance is lower than our actual distance, break.
                if(stopDistance - 10 > VesselVariables.altitude.Surface) { break; }

                Thread.Sleep(20); //Don't overkill it.
            }

            //Print that we should be burning now and set the throttle to the calculated value.
            Output.Output.WriteGame("Burning.");
            GameConnection.vesselControl.Throttle = (float)idealThrottle;

            //While we're going above 20m/s, point retrograde while burning.
            while (Math.Abs(VesselVariables.speed.Vertical) > 30) {

                //Point retrograde
                GameConnection.vesselControl.SAS = true;
                GameConnection.vesselControl.SASMode = KRPC.Client.Services.SpaceCenter.SASMode.Retrograde;

                Thread.Sleep(20); //Don't overkill it.
            }

            //Print that we're now in controlled decent.
            Output.Output.WriteGame("Controlled decent 'till 120m.");

            double initAlt = VesselVariables.altitude.Surface;

            //While we're more than 80m above the surface.
            while (VesselVariables.altitude.Surface > 120) {

                Console.WriteLine(VesselVariables.altitude.Surface);

                //Set the wanted speed depending on our altitude, minimally -3 m/s.
                double wantedVel = -1 * Math.Min((VesselVariables.altitude.Surface / initAlt) * initAlt/2, 3);

                //Set the throttle to the PID value, depending on our altitude.
                float throt = (float)pid.Update(wantedVel, VesselVariables.speed.Vertical);

                //Check if we're going less than 1m/s downwards, if so, cancel the PID value for the throttle.
                if (VesselVariables.speed.Vertical > -1) { throt = 0; }

                //Set the throttle the PID value.
                GameConnection.vesselControl.Throttle = Math.Max(throt, 0.01f);

                //Point radial.
                GameConnection.vesselControl.SAS = true;
                GameConnection.vesselControl.SASMode = KRPC.Client.Services.SpaceCenter.SASMode.Radial;

                Thread.Sleep(20); //Don't overkill it.
            }

            //Print that we're done.
            Output.Output.WriteGame("Controlled decent.");

            //When we're below 80m, deploy gear.
            GameConnection.vesselControl.Gear = true;

            //Until we've completely stopped moving vertically (aka touched down).
            while(Math.Abs(VesselVariables.speed.Vertical) > 0.1) {
                
                //Set the throttle to the PID value for -1m/s.
                float throt = (float)pid.Update(-1, VesselVariables.speed.Vertical);

                //Check if we're going less than 0m/s downwards, if so, cancel the PID value for the throttle.
                if (VesselVariables.speed.Vertical > 0) { throt = 0; }

                //Set the throttle the PID value.
                GameConnection.vesselControl.Throttle = Math.Max(throt, 0.01f);

                //Point radial.
                GameConnection.vesselControl.SAS = true;
                GameConnection.vesselControl.SASMode = KRPC.Client.Services.SpaceCenter.SASMode.Radial;

                Thread.Sleep(20); //Don't overkill it.
            }

            //If we've stopped moving, cut the throttle.
            GameConnection.vesselControl.Throttle = 0f;

            //Print that we're done.
            Output.Output.WriteGame("Completed.");
        }
    }
}
