using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab;
        private LevelManager levelManager;
        private Transform spawnPoint;

        public void Awake()
        {
            levelManager = FindObjectOfType<LevelManager>();
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