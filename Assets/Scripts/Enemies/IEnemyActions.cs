using UnityEngine;

namespace Enemies
{
    public interface IEnemyActions
    {
        void Chase();
        void Attack();
        void TakeDamage(float amount);
        void Die();
        void Idle();
    }
}