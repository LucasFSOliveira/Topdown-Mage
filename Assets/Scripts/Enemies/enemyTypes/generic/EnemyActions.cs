using System;
using Managers;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies.enemyTypes.generic
{
    public class EnemyActions : MonoBehaviour, IEnemyActions
    {
        private NavMeshAgent navMeshAgent;
        private LevelManager levelManager;
        public void Initialize(LevelManager levelManagerParameter)
        {
            this.levelManager = levelManagerParameter; 
            navMeshAgent = GetComponent<NavMeshAgent>();
            if (navMeshAgent == null)
            {
                Debug.LogError("NavMeshAgent component is missing on the enemy.");
            }
        }

        public void MoveToPlayer()
        {
            if (levelManager == null || levelManager.Player == null)
            {
                Debug.LogError("World or Player is not assigned.");
                return;
            }

            Vector3 playerPosition = levelManager.Player.transform.position;
            navMeshAgent.SetDestination(playerPosition);
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