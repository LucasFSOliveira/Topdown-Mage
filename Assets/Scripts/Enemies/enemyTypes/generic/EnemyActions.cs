using System;
using Managers;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies.enemyTypes.generic
{
    public class EnemyActions : MonoBehaviour, IEnemyActions
    {
        private NavMeshAgent agent;
        private LevelManager levelManager;
        public void Initialize(LevelManager levelManagerParameter)
        {
            this.levelManager = levelManagerParameter; 
            agent = GetComponent<NavMeshAgent>();
            if (agent == null)
            {
                Debug.LogError("NavMeshAgent component is missing on the enemy.");
            }
        }

        public void MoveToPlayer()
        {
            if (levelManager?.Player is null)
            {
                Debug.LogError("World or Player is not assigned.");
                return;
            }

            Vector3 playerPosition = levelManager.Player.transform.position;
            agent.SetDestination(playerPosition);
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