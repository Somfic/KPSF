using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRPC.Client.Services.Trajectories;

using KPSF.Variables;
using KRPC.Client.Services.Drawing;
using UnityEngine;

namespace KPSF.Programs.Flight.Tests
{
    public static class Trajectories
    {
        public static void Run()
        {
            KRPC.Client.Services.Trajectories.Service TR = new KRPC.Client.Services.Trajectories.Service(GameConnection.connection);

            while(true)
            {
                //Console.Clear();
                //Console.WriteLine(" TRAJECTORIES TEST ");
                //Console.WriteLine(" Impact position according to TR [WE NEED THIS ONE]:            " + TR.GetImpactPosition().ToString()); Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine(" Impact position from converted latlong according to TR (body): " + GameConnection.vessel.Orbit.Body.SurfacePosition(TR.GetImpactLatLong().Item1, TR.GetImpactLatLong().Item2, GameConnection.vessel.Orbit.Body.ReferenceFrame).ToString());
                //Console.WriteLine();
                //Console.WriteLine(" Current position according to kRPC (body):                     " + VesselVariables.position.Body.ToString()); Console.ForegroundColor = ConsoleColor.White;
                //Console.WriteLine(" Current position according to kRPC (body non rotating):        " + VesselVariables.position.BodyNonRotating.ToString()); 
                //Console.WriteLine(" Current position according to kRPC (body orbital):             " + VesselVariables.position.BodyOrbital.ToString());
                //Console.WriteLine(" Current position according to kRPC (vessel):                   " + VesselVariables.position.Vessel.ToString()); 
                //Console.WriteLine(" Current position according to kRPC (vessel orbital):           " + VesselVariables.position.VesselOrbital.ToString());
                //Console.WriteLine(" Current position according to kRPC (vessel surface):           " + VesselVariables.position.VesselSurface.ToString()); 
                //Console.WriteLine(" Current position according to kRPC (vessel surfacevel):        " + VesselVariables.position.VesselSurfaceVel.ToString());
                //Console.WriteLine();
                //Console.WriteLine(" Coordinates to position (body):                                " + GameConnection.vessel.Orbit.Body.SurfacePosition(VesselVariables.position.Latitude, VesselVariables.position.Longitude, GameConnection.vessel.Orbit.Body.ReferenceFrame).ToString());
                //Console.WriteLine(" Coordinates to position (body non rotating):                   " + GameConnection.vessel.Orbit.Body.SurfacePosition(VesselVariables.position.Latitude, VesselVariables.position.Longitude, GameConnection.vessel.Orbit.Body.NonRotatingReferenceFrame).ToString());
                //Console.WriteLine(" Coordinates to position (body orbital):                        " + GameConnection.vessel.Orbit.Body.SurfacePosition(VesselVariables.position.Latitude, VesselVariables.position.Longitude, GameConnection.vessel.Orbit.Body.OrbitalReferenceFrame).ToString());
                //Console.WriteLine(" Coordinates to position (vessel):                              " + GameConnection.vessel.Orbit.Body.SurfacePosition(VesselVariables.position.Latitude, VesselVariables.position.Longitude, GameConnection.vessel.ReferenceFrame).ToString());
                //Console.WriteLine(" Coordinates to position (vessel orbital):                      " + GameConnection.vessel.Orbit.Body.SurfacePosition(VesselVariables.position.Latitude, VesselVariables.position.Longitude, GameConnection.vessel.OrbitalReferenceFrame).ToString());
                //Console.WriteLine(" Coordinates to position (vessel surface):                      " + GameConnection.vessel.Orbit.Body.SurfacePosition(VesselVariables.position.Latitude, VesselVariables.position.Longitude, GameConnection.vessel.SurfaceReferenceFrame).ToString());
                //Console.WriteLine(" Coordinates to position (vessel surfacevel):                   " + GameConnection.vessel.Orbit.Body.SurfacePosition(VesselVariables.position.Latitude, VesselVariables.position.Longitude, GameConnection.vessel.SurfaceVelocityReferenceFrame).ToString());

                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();

                Vector3 impactposition = 2 * Services.Vectors.TupleToV3(GameConnection.vessel.Orbit.Body.SurfacePosition(TR.GetImpactLatLong().Item1, TR.GetImpactLatLong().Item2, GameConnection.vessel.Orbit.Body.NonRotatingReferenceFrame));

                Vector3 error = Services.Vectors.TupleToV3(VesselVariables.position.BodyNonRotating) - impactposition;

                Vector3 correctImpactPosition = impactposition + error;

                GameConnection.connection.Drawing().Clear();
                GameConnection.connection.Drawing().AddLine(VesselVariables.position.Body, Services.Vectors.V3ToTuple(impactposition), GameConnection.vessel.Orbit.Body.NonRotatingReferenceFrame);
            }
        }
    }
}
