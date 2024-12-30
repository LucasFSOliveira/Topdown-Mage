using Enemies.generic;
using UnityEngine;

namespace BaseStateMachines
{
    public abstract class Condition : MonoBehaviour
    {
        [SerializeField] protected EnemyActions enemyActions;
        public abstract bool IsMet();
    }
}