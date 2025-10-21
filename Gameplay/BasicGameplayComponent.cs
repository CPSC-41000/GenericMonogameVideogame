using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class BasicGameplayComponent : GameplayComponent
    {
        public BasicGameplayComponent(Vector2 position)
        {
            this.position = position;
        }
    }
}
