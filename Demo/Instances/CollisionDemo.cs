using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class CollisionDemo : Demo
    {
        Little_Guy lil = null;
        Wall rightWall = null;


        public CollisionDemo(GraphicsDevice device) :
            base(device, 6, 34, Name.Collision)
        {

            OftenReusedDemo.AddTextures0(this.textureManager, device);
            OftenReusedDemo.AddTexturesHelpers(this.textureManager, device);
            OftenReusedDemo.AddRectangles_16pxby16px_4by4(this.rectangleManager);
            OftenReusedDemo.AddTextureCollisionBox(this.textureManager, device);

            Component.TypeID[] array = [Component.TypeID.Audio,
                                        Component.TypeID.Collision,
                                        Component.TypeID.Gameplay,
                                        Component.TypeID.Graphics,
                                        Component.TypeID.Physics];
            ComponentArrayMap map = new((int)Component.TypeID.SIZE, array);

            lil = OftenReusedDemo.AddLilGuy(ref map,ref this.textureManager, ref this.rectangleManager);

            map = new((int)Component.TypeID.SIZE, array);
            rightWall = OftenReusedDemo.AddWall(ref map, ref this.textureManager, ref this.rectangleManager);

            GameObject refG = lil;
            this.gameManager.AddObject(ref refG);
            refG = rightWall;
            this.gameManager.AddObject(ref refG);

            BindList bindList = new BindList(10);
            SpaceKey space = new(Keys.Space, ref bindList);
            LeftKey left = new(Keys.L, ref bindList);
            InputManager.AddBindList(Name.Collision, ref bindList);

            SubscriberList subscriberList = new SubscriberList();
            subscriberList.AddAction(() =>
            {
                lil.SetNextAction(1);
            });

            CollisionComponent collisionComponent0 = (CollisionComponent)lil.GetComponent((int)Component.TypeID.Collision);
            CollisionComponent collisionComponent1 = (CollisionComponent)rightWall.GetComponent((int)Component.TypeID.Collision);

            collisionManager.AddCollisionPair(ref collisionComponent0,
                ref collisionComponent1,
                ref subscriberList);

            lil.SetBehavior((int)Little_Guy.Behaviors.RunIntoWall);
        }
    }
}
