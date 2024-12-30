using System.Collections;
using BaseStateMachines;
using UnityEngine;

namespace Enemies.enemyAI.states
{
    public class Attack : State
    {
        private Coroutine attackCoroutine;
        public override void Enter()
        {
            gameObject.SetActive(true);
            attackCoroutine = enemyActions.StartCoroutine(AttackRoutine());
        }

        public override void Exit()
        {
            gameObject.SetActive(false);
            if (attackCoroutine != null)
            {
                enemyActions.StopCoroutine(attackCoroutine);
                attackCoroutine = null;
            }
        }

        public override void Execute()
        {
            
        }

        private IEnumerator AttackRoutine()
        {
            while (true)
            {
                float attackSpeed = enemyActions.stats.AttackSpeed;
                enemyActions.PlayerHealth.TakeDamage(enemyActions.stats.Damage);
                enemyActions.animator.SetTrigger("Attack");
                yield return new WaitForSeconds(1f / attackSpeed);
            }
        }
    }
}