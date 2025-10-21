using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class InputManager
    {
        public static void Create()
        {
            instance = new InputManager();
            
        }

        public static void Destroy()
        {
            instance = null;
        }

        private InputManager()
        {
            //bindLists = new();
            bindLists = new BindList[(int)Demo.Name.SIZE];
        }

        //public static void AddEventHandler(Keys key, ref EventHandler handler)
        //{
        //    instance._keys[instance.count] = key;
        //    instance._handlers[instance.count] = handler;
        //    instance.count = instance.count + 1;
        //}

        public static void Update(GameTime gameTime)
        {
            instance._state = Keyboard.GetState();

            instance.activeBindList.HandleKeyboardState(Keyboard.GetState());
        }

        public static void AddBindList(Demo.Name id, ref BindList bindlist)
        {
            instance.bindLists[(int)id] = bindlist;
        }

        public static void SetActiveBindList(int bindList)
        {
            instance.activeBindList = instance.bindLists[bindList];    
        }

        BindList activeBindList;
        //List<BindList> bindLists;
        
        BindList[] bindLists;
        private KeyboardState _state;
        static InputManager instance;
    }
}
