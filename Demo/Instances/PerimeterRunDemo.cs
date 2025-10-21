using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class PerimeterRunDemo : Demo
    {
        Little_Guy lil = null;
        public PerimeterRunDemo(GraphicsDevice device)
        : base(device, 5, 32, Name.PerimeterRun)
        {
            OftenReusedDemo.AddTextures0(this.textureManager, device);
            OftenReusedDemo.AddTexturesHelpers(this.textureManager, device);
            OftenReusedDemo.AddRectangles_16pxby16px_4by4(this.rectangleManager);

            Component.TypeID[] array = [Component.TypeID.Audio,
                                        Component.TypeID.Collision,
                                        Component.TypeID.Gameplay,
                                        Component.TypeID.Graphics,
                                        Component.TypeID.Physics];
            ComponentArrayMap map = new((int)Component.TypeID.SIZE, array);
            lil = new(ref map, ref textureManager.Find(2), ref rectangleManager);
            lil.SetPosition(new Vector2(0, 0));

            GameObject refG = lil;
            this.gameManager.AddObject(ref refG);

            BindList bindList = new BindList(10);
            SpaceKey space = new(Keys.Space, ref bindList);
            LeftKey left = new(Keys.Left, ref bindList);
            InputManager.AddBindList(Name.PerimeterRun, ref bindList);

            lil.SetBehavior((int)Little_Guy.Behaviors.PerimeterRun);
        }
    }
}
