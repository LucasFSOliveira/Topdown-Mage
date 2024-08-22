namespace Enemies
{
    public interface IEnemyActions
    {
        void MoveToPlayer();
        void Attack();
        void TakeDamage(float amount);
        void Die();
    }
}