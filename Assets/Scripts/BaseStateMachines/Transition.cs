using System;
using System.Collections.Generic;
using UnityEngine;

namespace BaseStateMachines
{
    [Serializable]
    public class Transition
    {
        [SerializeField] private State nextState;
        [SerializeField] private List<Condition> conditions = new List<Condition>();
        
        public State NextState => nextState;
        
        public bool ShouldTransition()
        {
            foreach (Condition condition in conditions)
            {
                if (!condition.IsMet())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
