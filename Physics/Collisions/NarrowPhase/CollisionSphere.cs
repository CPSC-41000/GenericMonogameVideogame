using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class CollisionSphere : CollisionComponent
    {
        float radius;
        Vector2 center;

        public CollisionSphere(ref Texture2D texture, ref Rectangle rect, ref Vector2 pos, float radius, Vector2 center)
            :base(ref texture, ref rect, pos)
        {
        }

        public override bool CollidesWithCollisionAABB(CollisionAABB B)
        {
            // TODO
            return false;
        }

        public override bool CollidesWithCollisionBox(CollisionBox B)
        {
            // TODO
            return false;
        }

        public override bool CollidesWithCollisionCapsule(CollisionCapsule B)
        {
            // TODO
            return false;
        }

        public override bool CollidesWithCollisionSphere(CollisionSphere B)
        {
            bool res;
            // Construct a vector between centers, and get length squared
            Vector2 centerVector = B.center - this.center;

            // Recall that the length squared of v is the same as v dot v
            float distSquared = Vector2.Dot(centerVector, centerVector);

            // Is distSquared < sum of radii squared?
            if (distSquared < ((this.radius + B.radius) * (this.radius + B.radius)))
                res = true;
            else
                res = false;

            return res;
        }

        public override bool Visits(CollisionComponent obj1)
        {
            return obj1.CollidesWithCollisionSphere(this);
        }
    }
}
