using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class CollisionManager
    {
        struct CollisionPair 
        {
            public CollisionComponent _obj0;
            public CollisionComponent _obj1;
            public SubscriberList _subscriberList;

            public CollisionPair(ref CollisionComponent obj0,ref CollisionComponent obj1, SubscriberList subscriberList)
            {
                _obj0 = obj0;
                _obj1 = obj1;
                this._subscriberList = subscriberList;
            }

            public bool CheckCollision()
            {
                return _obj0.Visits(_obj1);
            }

            public void ActivateCollision()
            {
                _subscriberList.Notify();
            }
        }
        public CollisionManager()
        {
            pairs = new();
        }

        public void ResolveCollisions(GameTime gameTime)
        {
            foreach(CollisionPair pair in pairs)
            {
                if(pair.CheckCollision())
                {
                    pair.ActivateCollision();
                }
            }
        }

        public void AddCollisionPair(ref CollisionComponent obj0,
        ref CollisionComponent obj1, ref SubscriberList subscribelist)
        {
            pairs.Add(new CollisionPair(ref obj0, ref obj1,subscribelist));
        }
        List<CollisionPair> pairs;
    }
}