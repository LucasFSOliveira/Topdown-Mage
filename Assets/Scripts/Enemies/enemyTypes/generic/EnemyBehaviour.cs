using Managers;
using UnityEngine;

namespace Enemies.enemyTypes.generic
{
    public class EnemyBehaviour : MonoBehaviour
    {
        private LevelManager levelManager;
        [SerializeField] private EnemyActions actions;
        [SerializeField] private EnemyStats stats;

        public void Initialize(LevelManager levelManagerParameter)
        {
            levelManager = levelManagerParameter;
        }

        private void Update()
        {
            if (levelManager is null)
            {
                GameObject levelManagerHolder = GameObject.FindWithTag("LevelManagerHolder");
                levelManager = levelManagerHolder.GetComponent<LevelManager>();
            }

            actions.MoveToPlayer(levelManager.Player.transform.position, stats.MovementSpeed);
        }

        private void OnDestroy()
        {
            levelManager.RemoveEnemy(gameObject);
        }
    }
}