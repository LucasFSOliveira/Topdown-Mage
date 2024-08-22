using System.Collections.Generic;
using Enemies;
using UnityEngine;

namespace Managers
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private GameObject playerPrefab; 
        private List<GameObject> herosPreFab;
        private List<GameObject> enemiesPreFab;
        [SerializeField] private List<GameObject> enemySpawnersPrefab;
        [SerializeField] private List<GameObject> enemySpawners;
    
        public GameObject Player { get; private set; }

        private void Awake()
        {
            herosPreFab = new List<GameObject>();
            enemiesPreFab = new List<GameObject>();
            AddHero(playerPrefab);
            Player = playerPrefab;
        
            foreach (var enemySpawner in enemySpawners)
            {
                enemySpawner.GetComponent<EnemySpawner>().Initialize(this);
            }
        }

        private void AddHero(GameObject hero)
        {
            herosPreFab.Add(hero);
        }

        public void AddEnemy(GameObject enemy)
        {
            enemiesPreFab.Add(enemy);
        }

        public void RemoveHero(GameObject hero)
        {
            herosPreFab.Remove(hero);
        }

        public void RemoveEnemy(GameObject enemy)
        {
            enemiesPreFab.Remove(enemy);
        }
        
        private void SpawnEnemySpawners()
        {
            foreach (var enemySpawner in enemySpawnersPrefab)
            {
                var spawnpoint = new Vector3(Random.Range(0, 10), Random.Range(0, 10), -4);
                GameObject spawner = Instantiate(enemySpawner, spawnpoint, Quaternion.identity);
                spawner.GetComponent<EnemySpawner>().Initialize(this);
                enemySpawners.Add(spawner);
            }
            
            
        }
    }
}