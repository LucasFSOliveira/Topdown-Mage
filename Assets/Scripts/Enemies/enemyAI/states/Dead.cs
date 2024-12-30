using System.Collections;
using BaseStateMachines;
using UnityEngine;

namespace Enemies.enemyAI.states
{
    public class Dead : State
    {
        public override void Enter()
        {
            gameObject.SetActive(true);
            enemyActions.animator.SetBool("IsDead", true);
            enemyActions.StartCoroutine(DestroyAfterDelay());
        }

        public override void Exit() => gameObject.SetActive(false);

        public override void Execute()
        {
        }

        private IEnumerator DestroyAfterDelay()
        {
            yield return new WaitForSeconds(3f);
            Destroy(gameObject);
        }
    }
}