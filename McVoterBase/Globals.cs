using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McVoterBase
{
    public class Globals
    {
        public static string nickname = "",
        apiKey = "";

        public static bool isRunning = false,
        czechCraft = false,
        craftList = false;

        public static Queue<string> serversList = new Queue<string>();

        public static int votesGathered = 0;
    }
}
