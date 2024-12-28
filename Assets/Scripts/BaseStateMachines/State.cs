using System.Collections.Generic;
using UnityEngine;

namespace BaseStateMachines
{
    public class State : MonoBehaviour, IState
    {
        [SerializeField] List<Transition> transitions = new List<Transition>();

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

        public void Enter() => gameObject.SetActive(true);

        public void Exit() => gameObject.SetActive(false);
    }
}
