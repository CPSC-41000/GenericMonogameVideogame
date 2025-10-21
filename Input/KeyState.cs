using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch
{
    public enum KeyState : int
    {
        UNPRESSED = 0,
        JUSTPRESSED = 1,
        JUSTRELEASED = 2,
        HELD = 3,
    }
}
