using UnityEngine;
using System.Collections;

namespace RPG.Core
{
    public class ActionScheduler : MonoBehaviour
    {
        IAction lastAction;

        public void StartAction(IAction action)
        {
            if (lastAction == action) return;
            if (lastAction != null)
            {
                lastAction.Cancel();
                print("Cancelling " + lastAction);
            }

            lastAction = action;
        }
    }
}


