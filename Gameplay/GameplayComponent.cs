using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class GameplayComponent : Component
    {
        public Vector2 position;

        public GameplayComponent() 
        {
            position = Vector2.Zero;
        }
    }
}
