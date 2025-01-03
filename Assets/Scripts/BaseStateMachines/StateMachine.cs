﻿namespace BaseStateMachines
{
    public class StateMachine
    {
        public StateMachine(IState startingState) => ChangeState(startingState);

        private IState CurrentState { get; set; }
        //public IState CurrentState { get; private set; }
        //public IState PreviousState { get; private set; }

        public void ChangeState(IState state)
        {
            // Exit the current state
            CurrentState?.Exit();

            // Save the current state as the previous state
            //PreviousState = CurrentState;
            // Set the new state
            CurrentState = state;

            // Enter the new state
            CurrentState?.Enter();
        }

        public void Tick()
        {
            // Get the next state if the conditions are met to make a transition
            IState nextState = CurrentState.ProcessTransitions();

            // Make sure that there is a state to transition to this frame
            if (nextState != null)
            {
                // Transition to the state
                ChangeState(nextState);
            }
            
            CurrentState?.Execute();
        }
    }
}
