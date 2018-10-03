using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KRPC.Client.Services.SpaceCenter;
using UnityEngine;

namespace KPSF.Variables
{
    public static class VesselVariables
    {
        public static Altitude altitude = new Altitude();
        public static Speed speed = new Speed();
        public static Apoapsis apoapsis = new Apoapsis();
        public static Periapsis periapsis = new Periapsis();
        public static Encounter encounter = new Encounter();
        public static DynamicPressure dynamicPressure = new DynamicPressure();
        public static Engines engines = new Engines();
        public static Position position = new Position();
        public static Velocity velocity = new Velocity();
    }

    public class Velocity
    {
        public Tuple<double, double, double> Total { get { return GameConnection.vessel.Velocity(GameConnection.vessel.Orbit.Body.ReferenceFrame); } }
    }

    public class Engines
    {
        public double TWR { get { return GameConnection.vessel.AvailableThrust / (GameConnection.vessel.Mass * GameConnection.vesselFlight.GForce); } }
    }


    public class DynamicPressure
    {
        public double Q { get { return GameConnection.vesselFlight.DynamicPressure; } }

        public bool HasPassedMax()
        {
            double Qpast = GameConnection.vesselFlight.DynamicPressure;
            Thread.Sleep(100);
            if (GameConnection.vesselFlight.DynamicPressure < Qpast) { return true; }
            return false;
        }
    }

    public class Position
    {
        public Tuple<double, double, double> Body { get { return GameConnection.vessel.Position(GameConnection.vessel.Orbit.Body.ReferenceFrame); } }
        public Tuple<double, double, double> BodyNonRotating { get { return GameConnection.vessel.Position(GameConnection.vessel.Orbit.Body.NonRotatingReferenceFrame); } }
        public Tuple<double, double, double> BodyOrbital { get { return GameConnection.vessel.Position(GameConnection.vessel.Orbit.Body.OrbitalReferenceFrame); } }
        public Tuple<double, double, double> Vessel { get { return GameConnection.vessel.Position(GameConnection.vessel.ReferenceFrame); } }
        public Tuple<double, double, double> VesselSurface { get { return GameConnection.vessel.Position(GameConnection.vessel.SurfaceReferenceFrame); } }
        public Tuple<double, double, double> VesselOrbital { get { return GameConnection.vessel.Position(GameConnection.vessel.OrbitalReferenceFrame); } }
        public Tuple<double, double, double> VesselSurfaceVel { get { return GameConnection.vessel.Position(GameConnection.vessel.SurfaceVelocityReferenceFrame); } }
        public double Latitude { get { return GameConnection.vesselFlight.Latitude; } }
        public double Longitude { get { return GameConnection.vesselFlight.Longitude; } }
    }

    public class Speed
    {
        public double Vertical { get { return GameConnection.vesselFlightOrbitBody.VerticalSpeed; } }
        public double Horizontal { get { return GameConnection.vesselFlightOrbitBody.HorizontalSpeed; } }
        public double Total { get { return GameConnection.vesselFlightOrbitBody.Speed; } }
        public double Terminal { get { return GameConnection.vesselFlight.TerminalVelocity; } }
    }

    public class Altitude
    {
        public double Surface { get { return GameConnection.vesselFlight.MeanAltitude; } }
        public double Sea { get { return GameConnection.vesselFlight.SurfaceAltitude; } }
    }

    public class Apoapsis
    {
        public double Height { get { return GameConnection.vessel.Orbit.ApoapsisAltitude; } }
        public double TimeTo { get { return GameConnection.vessel.Orbit.TimeToApoapsis; } }
    }

    public class Periapsis
    {
        public double Height { get { return GameConnection.vessel.Orbit.PeriapsisAltitude; } }
        public double TimeTo { get { return GameConnection.vessel.Orbit.TimeToPeriapsis; } }
    }

    public class Encounter
    {
        public double TimeToSOIChange { get { return GameConnection.vessel.Orbit.TimeToSOIChange; } }
    }
}
