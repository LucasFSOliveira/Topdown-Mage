﻿using BaseStateMachines;
using UnityEngine;

namespace Enemies.enemyAI
{
    public class EnemyBehaviour : MonoBehaviour
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