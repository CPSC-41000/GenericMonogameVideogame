using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch
{
    public class SubscriberList
    {
        public SubscriberList() 
        {
            actionList = new ();
        }

        public void AddAction(Action action)
        {
            actionList.Add(action);
        }

        public virtual void Notify()
        {
            foreach (var item in actionList)
            {
                item();
            }
        }

        List<Action> actionList;
    }
}
