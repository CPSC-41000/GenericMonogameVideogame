using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class CollisionCapsule : CollisionComponent
    {
        Vector2 startPoint;
        Vector2 endPoint;
        float radius;

        public CollisionCapsule(ref Texture2D texture, ref Rectangle rect, Vector2 pos) 
            :base(ref texture, ref rect, pos)
        {
        }

        public override bool CollidesWithCollisionAABB(CollisionAABB collisionAABB)
        {
            throw new NotImplementedException();
        }

        public override bool CollidesWithCollisionBox(CollisionBox collisionBox)
        {
            throw new NotImplementedException();
        }

        public override bool CollidesWithCollisionCapsule(CollisionCapsule collisionAABB)
        {
            throw new NotImplementedException();
        }

        public override bool CollidesWithCollisionSphere(CollisionSphere collisionAABB)
        {
            throw new NotImplementedException();
        }

        public override bool Visits(CollisionComponent obj1)
        {
            throw new NotImplementedException();
        }
    }
}
