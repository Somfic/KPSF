using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KPSF.Variables;
using KRPC.Client.Services.Drawing;

namespace KPSF.Variables
{
    public static class GameServices
    {
        public static KRPC.Client.Services.Drawing.Service drawingService = GameConnection.connection.Drawing();
    }
}
