using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch
{
    public class EventHandler
    {
        public EventHandler()
        {
            this.states = new();
            this.currentState = null;
        }

        public void HandleKey(bool keyPressed)
        {
            currentState.HandleKey(keyPressed);
        }

        public void AddKeyInput(ref KeyInput input)
        {
            states.Add(input);
        }

        public void SwapStates(int i)
        {
            currentState = states[i];
        }

        public void SetActiveState(int v)
        {
            currentState = states[v];
        }

        public List<KeyInput> states;
        public KeyInput currentState;
    }
}
