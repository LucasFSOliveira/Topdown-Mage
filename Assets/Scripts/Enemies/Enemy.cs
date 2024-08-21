using System;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public class Enemy : MonoBehaviour, IEnemy
    {
        [SerializeField] private EnemyStats stats;
        [SerializeField] private EnemyBehaviour behaviour;
        private World world;
        private NavMeshAgent navMeshAgent;

        private void Awake()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            if (navMeshAgent == null)
            {
                Debug.LogError("NavMeshAgent component is missing on the enemy.");
            }
        }

        public void Initialize(World worldParameter)
        {
            this.world = worldParameter;
        }

        public void MoveToPlayer()
        {
            if (world == null || world.Player == null)
            {
                Debug.LogError("World or Player is not assigned.");
                return;
            }

            Vector3 playerPosition = world.Player.transform.position;
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