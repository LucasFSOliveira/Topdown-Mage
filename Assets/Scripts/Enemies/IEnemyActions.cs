using UnityEngine;

namespace Enemies
{
    //refactor after coding EnemyActions
    public interface IEnemyActions
    {
        void SearchFor();
        void Attack();
        void TakeDamage(float amount);
        void Die();
        void Idle();
    }
}