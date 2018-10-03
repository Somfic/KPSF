using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KPSF.Variables;

using KRPC.Client.Services.MechJeb;
using KRPC.Client.Services.SpaceCenter;
using Service = KRPC.Client.Services.MechJeb.Service;

namespace KPSF.Programs.Flight.Tests
{
    public static class CapusleTest
    {   
        public static void Run()
        {
            GameConnection.connection.SpaceCenter().LaunchVesselFromVAB("CapsuleTest",false);
            loop:
            try { GameConnection.GetVessel(); } catch { goto loop; }

            Service MJ = new Service(GameConnection.connection);
            LandingAutopilot landingAutoPilot = MJ.LandingAutopilot;
            landingAutoPilot.DeployChutes = false;
            landingAutoPilot.DeployGears = true;
            landingAutoPilot.TouchdownSpeed = 1;

            Output.Output.WriteGame("Capsule test flight");

            GameConnection.vesselControl.Gear = true;

            GameConnection.vesselControl.ActivateNextStage();
            GameConnection.vesselControl.Throttle = 0;
            GameConnection.vesselControl.SAS = true;
            GameConnection.vesselControl.SASMode = KRPC.Client.Services.SpaceCenter.SASMode.StabilityAssist;
            GameConnection.vesselControl.RCS = true;

            for (int i = 3; i > 0; i = i - 1)
            {
                Thread.Sleep(1000);
                Output.Output.WriteGameDebug("T - " + i);
            }
            Thread.Sleep(1000);

            GameConnection.vesselControl.Throttle = 1;
            Thread.Sleep(1000);
            GameConnection.vesselControl.Gear = false;
            Thread.Sleep(5000);
            GameConnection.vesselControl.Throttle = 0;
            Thread.Sleep(1500);
            landingAutoPilot.LandUntargeted();
            landingAutoPilot.Enabled = true;
            while(landingAutoPilot.Enabled)
            {
                landingAutoPilot.TouchdownSpeed = Math.Max(VesselVariables.altitude.Surface / 3.5 - 20, 2);
                GameConnection.vesselControl.Gear = true;
            }           
        }
    }
}
