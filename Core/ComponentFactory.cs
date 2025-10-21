using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch.Core
{
    public class ComponentFactory
    {
        public static Component CreateNullComponent(Component.TypeID id)
        {
            Component component = null;
            switch (id)
            {
                case Component.TypeID.Audio:
                {
                        component = new NullAudio();
                        break;
                }
                case Component.TypeID.Gameplay:
                {
                        component = new NullGameObject();
                        break;
                }
                case Component.TypeID.Graphics:
                {
                        component = new NullGraphicsComponent();
                        break;
                }
                case Component.TypeID.Physics:
                {
                        component = new NullPhysicsComponent();
                        break;
                }
                // Both shouldn't happen
                case Component.TypeID.SIZE:
                default:
                {
                    break;
                }
            }

            return component;
        }
    }
}
