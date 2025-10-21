using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch
{
    public enum DemoGameObjectTypes
    {
        Little_Guy,
        Wall,
    }
    public class DemoGameObjectFactory
    {
        public GameObject CreateGameObject(DemoGameObjectTypes GameObjectType)
        {
            GameObject res = null;
            return res; 
        }
    }
}
