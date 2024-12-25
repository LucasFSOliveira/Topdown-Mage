using UnityEngine;

namespace Enemies
{
    public interface IEnemyActions
    {
        void MoveToPlayer(Vector3 playerPosition, float movementSpeed);
        void Attack();
        void TakeDamage(float amount);
        void Die();
    }
}