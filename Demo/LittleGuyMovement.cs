using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class LittleGuyMovement : GameplayComponent
    {
        public LittleGuyMovement(ref BehaviorLists list)
        {
            _list = list;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            _list.ActivateNextAction();
        }

        BehaviorLists _list;
    }
}
