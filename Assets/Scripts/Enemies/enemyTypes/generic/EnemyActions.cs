using System;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies.enemyTypes.generic
{
    public class EnemyActions : MonoBehaviour, IEnemyActions
    {
        private NavMeshAgent agent;
        private EnemyAnimationHandler animationHandler;
        public void Start()
        {
            animationHandler = GetComponent<EnemyAnimationHandler>();
            agent = GetComponent<NavMeshAgent>();
            
            if (agent == null)
            {
                Debug.LogError("NavMeshAgent component is missing on the enemy.");
            }
            else
            {
                agent.updateRotation = false;
                agent.updateUpAxis = false;
            }
        }

        public void MoveToPlayer(Vector3 playerPosition, float movementSpeed)
        {
            agent.speed = movementSpeed;
            agent.SetDestination(playerPosition);
            animationHandler.Move(playerPosition);
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(float amount)
        {
            throw new NotImplementedException();
        }

        public void Die()
        {
            throw new NotImplementedException();
        }

        
    }
}