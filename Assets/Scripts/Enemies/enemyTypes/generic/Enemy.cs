using Enemies.enemyTypes.generic;
using Managers;
using UnityEngine;

namespace Enemies
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private EnemyBehaviour behaviour;

        public void Initialize(LevelManager levelManager)
        {
            levelManager.AddEnemy(gameObject);
            behaviour.Initialize(levelManager);
        }
    }
}