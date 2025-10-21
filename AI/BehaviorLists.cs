using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch
{
    public class BehaviorLists
    {
        public BehaviorLists() 
        {
            _current = 0;
            actions = new List<Action>();
        }

        public void AddBehavior(Action action)
        {
            actions.Add(action);
            _current++;
        }

        public void ActivateNextAction()
        {
            actions[_current].Invoke();
        }

        public void SetNextAction(int i)
        {
            _current = i;
        }

        int _current = 0;
        List<Action> actions;
    }
}
