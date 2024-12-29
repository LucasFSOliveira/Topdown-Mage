using System;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies.generic
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class EnemyActions : MonoBehaviour, IEnemyActions
    {
        [SerializeField] private EnemyStats stats;
        [SerializeField] private LayerMask targetLayer;
        [SerializeField] private string targetTag;
        private NavMeshAgent agent;

        public void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        public void SearchFor()
        {
            //agent.speed = stats.MovementSpeed;
            //agent.SetDestination(playerPosition);
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

        public void Idle()
        {
            throw new NotImplementedException();
        }
    }
}