using UnityEngine;
using System.Collections;

namespace RPG.Core
{
    public class ActionScheduler : MonoBehaviour
    {
        MonoBehaviour lastAction;

        public void StartAction(MonoBehaviour action)
        {
            if (lastAction == action) return;
            if (lastAction != null)
            {
                print("Cancelling " + lastAction);
            }

            lastAction = action;
        }
    }
}


