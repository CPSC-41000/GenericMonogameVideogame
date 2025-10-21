using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{

    public class Wall : GameObject
    {
        public Wall(ref ComponentArrayMap map, ref Texture2D texture,
            ref Rectangle rectangle,ref Vector2 position)
        : base(ref map)
        {
            Sprite _sprite = new Sprite(texture, rectangle);
            Vector2 _position = position;
            float _uniformScale = 1.0f;

            Component _GraphicsComponent = new BasicGraphicsComponent(_sprite, _position, _uniformScale);
            map.AddComponent(Component.TypeID.Graphics, ref _GraphicsComponent);
            //Component _GraphicsComponent = new BasicGraphicsComponent(ref texture, index,
            //                               ref rectangleManager, 0, 4.0f);

            Component _GameplayComponent = new BasicGameplayComponent(_position);
            map.AddComponent(Component.TypeID.Gameplay, ref _GameplayComponent);

            //GameplayComponent obj = (GameplayComponent)map
            //    .AddComponent(Component.TypeID.Gameplay, ref _GameplayComponent);
        }

        public void AddCollisionComponent(CollisionAABB box1)
        {
            Component refC = box1;
            _map.AddComponent(Component.TypeID.Collision, ref refC);
        }

        public ref Vector2 GetPosition()
        {
            return ref ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay)).position;
        }

        internal void SetPosition(Vector2 pos)
        {
            ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay)).position = pos;
        }
    }
}