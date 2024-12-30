using System.Collections;
using BaseStateMachines;
using UnityEngine;

namespace Enemies.enemyAI.states
{
    public class Patrol : State
    {
        private Coroutine idleCoroutine;
        private bool targetReached;
        [SerializeField] private float patrolRadius;
        [SerializeField] private float idleTime;

        public override void Enter()
        {
            targetReached = false;
            gameObject.SetActive(true);
            idleCoroutine = enemyActions.StartCoroutine(PatrolRoutine());
        }

        public override void Exit()
        {
            gameObject.SetActive(false);
            if (idleCoroutine != null)
            {
                enemyActions.StopCoroutine(idleCoroutine);
                idleCoroutine = null;
            }
        }

        public override void Execute()
        {
            if (targetReached)
            {
                enemyActions.StopCoroutine(idleCoroutine);
                targetReached = false;
                idleCoroutine = enemyActions.StartCoroutine(PatrolRoutine());
            }
        }

        private IEnumerator PatrolRoutine()
        {
            while (targetReached == false)
            {
                Vector2 finalPosition = enemyActions.SetRandomPosition(patrolRadius);
                while (Vector2.Distance(transform.position, finalPosition) > 0.1f)
                {
                    enemyActions.MoveToTargetPosition(finalPosition);
                    yield return null;
                }

                yield return new WaitForSeconds(idleTime);
                targetReached = true;
            }
        }
        
    }
}