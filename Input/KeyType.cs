using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class KeyType
    {
        public KeyType(Keys key)
        { 
            _key = key;   
        }

        protected EventHandler handler = new();
        protected KeyInput input = new();
        protected Keys _key;
    }
}
