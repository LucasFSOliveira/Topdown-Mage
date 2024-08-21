using UnityEngine;

namespace Enemies
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private World world;

        private void Start()
        {
            InvokeRepeating(nameof(SpawnEnemy), 0f, 5f);
        }

        private void SpawnEnemy()
        {
            GameObject enemyObject = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            Enemy enemy = enemyObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.Initialize(world);
            }
        }
    }
}