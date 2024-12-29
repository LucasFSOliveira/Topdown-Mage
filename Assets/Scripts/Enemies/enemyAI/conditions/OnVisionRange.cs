using BaseStateMachines;
using Enemies.generic;
using Managers;
using UnityEngine;

namespace Enemies.enemyAI.conditions
{
    public class OnVisionRange : Condition
    {
        private EnemyStats stats;
        private LevelManager levelManager;

        private void Start()
        {
            stats = GetComponent<EnemyStats>();
            levelManager = GameObject.FindWithTag("LevelManagerHolder").GetComponent<LevelManager>();
        }

        public override bool IsMet()
        {
            float distance = Vector3.Distance(levelManager.Player.transform.position, transform.position);
            if (distance < stats.VisionRange) return true;
            return false;
        }
    }
}