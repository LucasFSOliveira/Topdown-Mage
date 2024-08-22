using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab;
        private Transform spawnPoint;
        private LevelManager levelManager;

        public void Initialize(LevelManager levelManager1)
        {
            spawnPoint = GetComponent<Transform>();
            
            InvokeRepeating(nameof(SpawnEnemy), 0f, 5f);
        }

        private void SpawnEnemy()
        {
            GameObject enemyObject = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            Enemy enemy = enemyObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.Initialize(levelManager);
            }
        }
    }
}