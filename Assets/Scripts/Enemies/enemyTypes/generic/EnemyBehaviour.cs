using Managers;
using UnityEngine;

namespace Enemies.enemyTypes.generic
{
    public class EnemyBehaviour : MonoBehaviour
    {
        private LevelManager levelManager;
        private EnemyStats stats;
        private EnemyActions actions;
        
        public void Initialize(LevelManager levelManagerParameter)
        {
            this.levelManager = levelManagerParameter;
            actions.Initialize(levelManagerParameter);
        }

        private void Update()
        {
            actions.MoveToPlayer();    
        }

        
    }
}