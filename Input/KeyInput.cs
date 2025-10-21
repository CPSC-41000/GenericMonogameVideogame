using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.MediaFoundation;

namespace ToeJamAndEarlFirstBatch
{
    public class KeyInput
    {
        public KeyInput()
        {
            state = KeyState.UNPRESSED;
            subscribers = new SubscriberList[4];

            for (int i = 0; i < 4; i++)
            {
                subscribers[i] = new SubscriberList();
            }
        }

        public void HandleKey(bool pressed)
        {
            // Not inherently obvious? - What do you think?
            int isPressed = pressed ? 1 : 0;
            // Ordering matters here 1 part why my in class was messed up
            subscribers[((int)state << 1) | isPressed].Notify();
            state = (KeyState)isPressed;
        }

        public void AddInputSubscriber(KeyState keyState, ref SubscriberList subscriber)
        {
            subscribers[(int)keyState] = subscriber;
        }

        public void AddAction(KeyState keyState, ref Action action)
        {
            subscribers[(int)keyState].AddAction(action);
        }

        public KeyState state;
        SubscriberList[] subscribers;
    }
}
