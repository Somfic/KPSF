using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPSF.Variables;
using KRPC.Client.Services.InfernalRobotics;

namespace KPSF.Programs.Flight.Tests
{
    public static class Robotics
    {
        public static void Run()
        {
            Service service = GameConnection.connection.InfernalRobotics();
            Console.WriteLine(service.Available);
            Console.Read();
        }
    }
}
