using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using KPSF.Variables;

namespace KPSF.Services
{
    public static class Autostage
    {
        private static void Stage()
        {
            GameConnection.vesselControl.ActivateNextStage();
            Output.Output.WriteGameDebug("Staging");
            Thread.Sleep(500);
        }

        public static bool Active { get; private set; } = false;

        public static void Engage()
        {
            Output.Output.WriteGameDebug("Autostage enabled");
            Active = true;
            Task.Run(() => {
                while(Active)
                {
                    Thread.Sleep(20);
                    End:
                    Thread.Sleep(1000);
                    bool thisStageHasFueledEngines = false;
                    foreach (var item in GameConnection.vessel.Parts.InStage(GameConnection.vessel.Control.CurrentStage))
                    {
                        if (item.Engine != null && item.Engine.HasFuel) { thisStageHasFueledEngines = true; }
                    }

                    //Depleted
                    foreach (var item in GameConnection.vessel.Parts.InDecoupleStage(GameConnection.vessel.Control.CurrentStage - 1))
                    {
                        if (item.Engine != null && !item.Engine.HasFuel) { Stage(); goto End; }
                    }

                    foreach (var item in GameConnection.vessel.Parts.InStage(GameConnection.vessel.Control.CurrentStage - 1))
                    {
                        //If clamps are locked
                        if (item.LaunchClamp != null && GameConnection.vessel.Thrust != 0)
                        {
                            Stage();
                            goto End;
                        }

                        //If the next stage would activate engines
                        if (item.Engine != null && !thisStageHasFueledEngines)
                        {
                            Stage();
                            goto End;
                        }

                        //If the next stage has fairings
                        if (item.Fairing != null && VesselVariables.altitude.Sea > GameConnection.vessel.Orbit.Body.AtmosphereDepth)
                        {
                            Stage();
                            goto End;
                        }
                    }
                }
            });
        }

        public static void Disenage()
        {
            Output.Output.WriteGameDebug("Autostage disabled");
            Active = false;
        }
    }
}
