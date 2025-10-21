using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class CollisionAABB : CollisionComponent
    {
        public Func<Vector2> _getPosition;
        public Vector2 offset;

        public CollisionAABB(ref Texture2D texture, ref Rectangle rect, Func<Vector2> getPosition, Vector2 offset)
            : base(ref texture,ref rect, getPosition())
        {
            this._getPosition = getPosition;
            this.offset = offset;
        }

        public override bool CollidesWithCollisionAABB(CollisionAABB b)
        {
            Vector2 positionA = _getPosition();
            Vector2 positionB = b._getPosition();
            Vector2 offsetB = b._getPosition() + b._getPosition();

            bool isAMaxXLesser = (positionA.X + this.offset.X) < positionB.X;
            bool isAMaxYLesser = (positionA.Y + this.offset.Y) < positionB.Y;
            bool isAminXGreater = (positionA.X > (positionB.X + b.offset.X));
            bool isAminYGreater = positionA.Y > (positionB.Y + b.offset.Y);
            bool test = (isAMaxXLesser || isAMaxYLesser || isAminXGreater || isAminYGreater);
            //bool test = (((positionA.X + this.offset.X) < positionB.X) ||
            //            ((positionA.Y + this.offset.Y) < positionB.Y) || 
            //            (positionA.X >  (positionB.X + b.offset.X)) ||
            //            (positionA.Y > (positionB.Y + b.offset.Y)));
            return !test;
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
            return obj1.CollidesWithCollisionAABB(this);
        }
    }
}
