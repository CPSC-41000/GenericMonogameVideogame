using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class LeftKey : KeyType
    {
        public LeftKey(Keys key, ref BindList list) 
            : base(key)
        {
            SubscriberList subscriberList = new SubscriberList();
            subscriberList.AddAction(() => Debug.WriteLine("Hit the Space bar"));

            input.AddInputSubscriber(KeyState.JUSTPRESSED, ref subscriberList);

            subscriberList = new SubscriberList();
            input.AddInputSubscriber(KeyState.UNPRESSED, ref subscriberList);

            subscriberList = new SubscriberList();
            subscriberList.AddAction(() => Debug.WriteLine("Space Released"));
            input.AddInputSubscriber(KeyState.JUSTRELEASED, ref subscriberList);

            subscriberList = new SubscriberList();
            subscriberList.AddAction(() => Debug.WriteLine("Space HELD"));
            input.AddInputSubscriber(KeyState.HELD, ref subscriberList);

            handler.AddKeyInput(ref input);
            handler.SetActiveState(0);

            list.AddEventHandler(Keys.Left, ref handler);
        }

    }
}
