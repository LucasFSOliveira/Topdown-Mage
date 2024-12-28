using System;
using Managers;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies.enemyTypes.generic
{
    public class EnemyActions : MonoBehaviour, IEnemyActions
    {
        [SerializeField] private EnemyStats stats;
        
        private LevelManager levelManager;
        public LevelManager LevelManager => levelManager;
        private NavMeshAgent agent;

        public void Start()
        {
            GameObject levelManagerHolder = GameObject.FindWithTag("LevelManagerHolder");
            levelManager = levelManagerHolder.GetComponent<LevelManager>();
            
            agent = GetComponent<NavMeshAgent>();
            agent.updateRotation = false;
            agent.updateUpAxis = false;
        }

        public void Chase()
        {
            Vector3 playerPosition = levelManager.Player.transform.position;
            agent.speed = stats.MovementSpeed;
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

        public void Idle()
        {
            throw new NotImplementedException();
        }
    }
}