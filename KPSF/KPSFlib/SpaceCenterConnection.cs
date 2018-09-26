using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KRPC.Client.Services.KRPC;
using KRPC.Client.Services.SpaceCenter;
using KRPC.Client;

namespace KPSF.KPSFlib
{
    public static class SpaceCenterConnection
    {
        public static Connection connection;
        public static KRPC.Client.Services.KRPC.Service service;
        public static Vessel vessel;
        public static Flight vesselFlight;
        public static Flight vesselFlightOrbitBody;
        public static Control vesselControl;

        public static void Connect()
        {
            connection = new Connection("KPSF");
            service = connection.KRPC();
        }

        public static void UpdateVessel()
        {
            vessel = connection.SpaceCenter().ActiveVessel;
            vesselFlight = vessel.Flight();
            vesselFlightOrbitBody = vessel.Flight(vessel.Orbit.Body.ReferenceFrame);
            vesselControl = vessel.Control;
        }

        public static void Disconnect()
        {
            connection.Dispose();
        }
    }
}
