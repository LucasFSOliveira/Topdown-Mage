using UnityEngine;

namespace Enemies
{
    public interface IEnemyActions
    {
        void SearchFor();
        void Attack();
        void TakeDamage(float amount);
        void Die();
        void Idle();
    }
}