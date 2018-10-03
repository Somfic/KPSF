using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using KRPC.Client.Services.KRPC;
using KRPC.Client.Services.RemoteTech;
using KRPC.Client.Services.KerbalAlarmClock;
using KRPC.Client.Services.InfernalRobotics;
using KRPC.Trajectories;

using KPSF.Variables;
using UnityEngine;
using KRPC.Client.Services.SpaceCenter;

namespace KPSF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            GameConnection.Connect();
            GameConnection.GetVessel();
            Programs.Flight.Landing.Run();  
        }
    }
}
