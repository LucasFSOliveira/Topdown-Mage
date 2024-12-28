using System;
using BaseStateMachines;
using Enemies.enemyTypes.generic;
using Managers;
using UnityEngine;

namespace Enemies.enemyTypes.enemyAI.conditions
{
    public class OnVisionRange : Condition
    {
        private EnemyStats stats;
        private Transform enemyTransform;
        private LevelManager levelManager;

        private void Start()
        {
            stats = GetComponent<EnemyStats>();
            enemyTransform = GetComponent<Transform>();
            levelManager = GameObject.FindWithTag("LevelManagerHolder").GetComponent<LevelManager>();
        }

        public override bool IsMet()
        {
            float distance = Vector3.Distance(levelManager.Player.transform.position, enemyTransform.position);
            if (distance < stats.VisionRange) return true;
            return false;
        }
    }
}