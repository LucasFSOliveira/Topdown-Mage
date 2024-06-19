namespace combatSystem.healthSystem
{
    interface IDamageable
    {
        void TakeDamage(float damage);
        public bool IsPlayer();
        public bool IsAlive();
    }
}