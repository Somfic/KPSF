using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using KPSF.Variables;
using KRPC.Client.Services.UI;

namespace KPSF.Output
{
    public static class Output
    {
        public static void WriteGame(string text)
        {
            Service ui = GameConnection.connection.UI();
            text = $"<size=22>{text}</size>";
            ui.Message(text, 10, MessagePosition.TopLeft);
        }

        public static void WriteGameDebug(string text)
        {
            Service ui = GameConnection.connection.UI();
            text = $"<size=22><color=#f4aa42>{text}</color></size>";
            ui.Message(text, 10, MessagePosition.TopRight);
        }
    }
}
