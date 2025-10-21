using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class BindList
    {
        private EventHandler[] _handlers;
        Dictionary<int, Keys> _keys;
        int _count;

        public BindList(int size) 
        {
            _handlers = new EventHandler[size];
            _keys = new();
            _count = 0;
        }

        public void AddEventHandler(Keys key, ref EventHandler handler)
        {
            _handlers[_count] = handler;
            _keys[_count] = key;
            _count++;
        }

        public void HandleKeyboardState(KeyboardState state)
        {
            for (int i = 0; i < _count; i++)
            {
                _handlers[i].HandleKey(state.IsKeyDown(_keys[i]));
            }
        }
    }
}
