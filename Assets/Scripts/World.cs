using System.Collections.Generic;
using Enemies;
using UnityEngine;

public class World : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab; 
    private List<GameObject> herosPreFab;
    private List<GameObject> enemiesPreFab;
    [SerializeField] private EnemySpawner enemySpawner;

    public GameObject Player { get; private set; }

    private void Awake()
    {
        herosPreFab = new List<GameObject>();
        enemiesPreFab = new List<GameObject>();
        AddHero(playerPrefab);
        Player = playerPrefab;
    }

    public void AddHero(GameObject hero)
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
}