using UnityEngine;

namespace BaseStateMachines
{
    public class StateMachineBehaviour : MonoBehaviour
    // apply to a GameObject to create a state machine, custom it through the inspector
    {
        [SerializeField] private State startingState;

        private StateMachine stateMachine;
        private StateMachine StateMachine
        {
            get
            {
                if (stateMachine != null) { return stateMachine; }
                stateMachine = new StateMachine(startingState);
                return stateMachine;
            }
        }

        private void Update() => StateMachine.Tick();

        public void ChangeState(State state) => StateMachine.ChangeState(state);
    }
}
