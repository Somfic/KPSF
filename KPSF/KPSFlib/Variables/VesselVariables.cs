using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSF.KPSFlib.Variables
{
    public static class VesselVariables
    {
        public static Altitude altitude;
        public static Speed speed;
    }

    public class Speed
    {
        public double Vertical;
        public double Horizontal;
        public double Total;

        public void Update()
        {
            this.Vertical = SpaceCenterConnection.vesselFlightOrbitBody.VerticalSpeed;
            this.Horizontal = SpaceCenterConnection.vesselFlightOrbitBody.HorizontalSpeed;
            this.Total = SpaceCenterConnection.vesselFlightOrbitBody.Speed;
        }
    }

    public class Altitude
    {
        public double Surface;
        public double Sea;

        public void Update()
        {
            this.Sea = SpaceCenterConnection.vesselFlight.MeanAltitude;
            this.Surface = SpaceCenterConnection.vesselFlight.SurfaceAltitude;
        }
    }

    public class Apoapsis
    {
        public double Height;
        public double TimeTo;

        public void Update()
        {
            this.Height = SpaceCenterConnection.vessel.Orbit.ApoapsisAltitude;
            this.TimeTo = SpaceCenterConnection.vessel.Orbit.TimeToApoapsis;
        }
    }

    public class Periapsis
    {
        public double Height;
        public double TimeTo;

        public void Update()
        {
            this.Height = SpaceCenterConnection.vessel.Orbit.PeriapsisAltitude;
            this.TimeTo = SpaceCenterConnection.vessel.Orbit.TimeToPeriapsis;
        }
    }

    public class Encounter
    {
        public double TimeToSOIChange;

        public void Update()
        {
            this.TimeToSOIChange = SpaceCenterConnection.vessel.Orbit.TimeToSOIChange;
        }
    }
}
