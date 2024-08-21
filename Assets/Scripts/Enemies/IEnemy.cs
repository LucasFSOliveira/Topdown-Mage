namespace Enemies
{
    public interface IEnemy
    {
        void MoveToPlayer();
        void Attack();
        void TakeDamage(float amount);
        void Die();
    }
}