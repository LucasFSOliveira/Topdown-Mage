using Enemies.enemyTypes.generic;
using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab;
        private LevelManager levelManager;
        private Transform spawnPoint;

        public void Start()
        {
            levelManager = FindObjectOfType<LevelManager>();
            spawnPoint = GetComponent<Transform>();
            InvokeRepeating(nameof(SpawnEnemy), 0f, 5f);
        }

        private void SpawnEnemy()
        {
            GameObject enemyObject = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            EnemyBehaviour enemyBehaviour = enemyObject.GetComponent<EnemyBehaviour>();
            
            enemyBehaviour.Initialize(levelManager);
            levelManager.AddEnemy(enemyObject);
            
        }
    }
}