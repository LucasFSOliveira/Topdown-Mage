using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class LevelManager : MonoBehaviour
    {
        private List<GameObject> enemies;
        public GameObject Player { get; private set; }

        private void Awake()
        {
            enemies = new List<GameObject>();
            FindAndAssignPlayer();
        }

        public void AddEnemy(GameObject enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(GameObject enemy)
        {
            enemies.Remove(enemy);
        }

        private void FindAndAssignPlayer()
        {
            Player = GameObject.FindWithTag("Player");
            if (Player == null)
            {
                Debug.LogError("Player not found in the scene.");
            }
        }
    }
}