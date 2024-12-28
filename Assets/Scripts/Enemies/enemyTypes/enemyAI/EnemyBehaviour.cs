using BaseStateMachines;
using Enemies.enemyTypes.generic;
using UnityEngine;
using IState = Unity.VisualScripting.IState;

namespace Enemies.enemyTypes.enemyAI
{
    public class EnemyBehaviour : MonoBehaviour
    // apply to a GameObject to create a state machine, custom it through the inspector
    {
        [SerializeField] private State startingState;
        [SerializeField] private EnemyActions actions;

        private StateMachine stateMachine;

        public StateMachine StateMachine
        {
            get
            {
                if (stateMachine != null) { return stateMachine; }
                stateMachine = new StateMachine(startingState);
                return stateMachine;
            }
        }
        private string currentState;
        public string CurrentState => CurrentState;
        
        private void Update()
        {
            StateMachine.Tick();
            currentState = GetComponent<EnemyBehaviour>().StateMachine.CurrentState.GetType().Name;
            switch (currentState)
            {
                case "Idle":
                    Debug.Log("Idle");
                    actions.Idle();
                    break;
                case "Chase":
                    Debug.Log("Chase");
                    actions.Chase();
                    break;
                case "Attack":
                    Debug.Log("Attack");
                    actions.Attack();
                    break;
                case "Dead":
                    Debug.Log("Dead");
                    actions.Die();
                    break;
            }
        }

        public void ChangeState(State state) => StateMachine.ChangeState(state);
    }
}
