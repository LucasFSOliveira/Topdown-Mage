using System.Collections.Generic;
using Enemies.generic;
using UnityEngine;

namespace BaseStateMachines
{
    public abstract class State : MonoBehaviour, IState
    {
        [SerializeField] protected EnemyActions enemyActions;
        [SerializeField] protected List<Transition> transitions = new List<Transition>();
        
        public IState ProcessTransitions()
        {
            foreach (Transition transition in transitions)
            {
                if (transition.ShouldTransition())
                {
                    return transition.NextState;
                }
            }

            return null;
        }

        public abstract void Enter();

        public abstract void Exit();

        public abstract void Execute();
    }
}
