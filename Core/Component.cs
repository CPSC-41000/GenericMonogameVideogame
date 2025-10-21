using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    // Dummy Class to be inherited
    public class Component
    {
        public enum TypeID : int
        {
            Audio = 0,
            Collision = 1,
            Gameplay = 2,
            Graphics = 3,
            Physics = 4,
            SIZE = 5,
        }

        public virtual void Update(GameTime gameTime)
        {
            
        }

    }
}
