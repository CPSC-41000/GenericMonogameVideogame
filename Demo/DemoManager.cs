using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class DemoManager
    {
        Demo[] demoArray;
        GraphicsDevice _device;

        public DemoManager(GraphicsDevice device) 
        {
            _device = device;
            demoArray = new Demo[(int)Demo.Name.SIZE];

            demoArray[(int)Demo.Name.Spinning] = new SpinningDemo(_device);
            demoArray[(int)Demo.Name.PerimeterRun] = new PerimeterRunDemo(_device);
            demoArray[(int)Demo.Name.SoundEffect] = new SoundEffectDemo(_device);
            demoArray[(int)Demo.Name.SoundChain] = new SoundChainDemo(_device);
            demoArray[(int)Demo.Name.Collision] = new CollisionDemo(_device);
            demoArray[(int)Demo.Name.Physics] = new PhysicsDemo(_device);

            activeDemo = null;
        }
        
        public void AddDemo(ref Demo demo)
        {
            demos.Add(demo);
        }
        
        public Demo GetActiveDemo()
        {
            return activeDemo;
        }
        
        public void SetActiveDemo(int i)
        {
            activeDemo = demoArray[i];
        }

        Demo activeDemo;
        List<Demo> demos;
    }
}
