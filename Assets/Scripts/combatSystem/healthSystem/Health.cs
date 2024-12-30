using System;
using combatSystem.healthSystem;
using UnityEngine;
// ReSharper disable All

namespace healthSystem
{
    public class Health : MonoBehaviour, IDamageable
    {
        private float maxHealth;
        public float MaxHealth => maxHealth;
        public float CurrentHealth { get; private set; }

        [SerializeField] private bool isPlayer;
        private bool IsAlive => CurrentHealth > 0;
        
        public event Action<float> OnDamageReceived;
        public event Action OnDeath;
        public event Action<float> OnHeal;

        private HealthLogger _logger;

        private void Start()
        {
            CurrentHealth = MaxHealth;
            _logger = new HealthLogger(this);
        }

        public void TakeDamage(float damage)
        {
            if (CurrentHealth <= 0) return; // Already dead

            CurrentHealth -= damage;
            OnDamageReceived?.Invoke(damage);
            if (CurrentHealth <= 0)
            {
                CurrentHealth = 0;
                OnDeath?.Invoke();
            }
        }

        public void restoreHealth(float healAmount)
        {
            CurrentHealth += healAmount;
            if (CurrentHealth > maxHealth) CurrentHealth = MaxHealth;
            OnHeal?.Invoke(healAmount);
        }

        public void setMaxHealth(float amount)
        {
            maxHealth = amount;
            CurrentHealth = maxHealth;
        }
        
        public void changeMaxHealth(float amount)
        {
            float healthDiff = amount - maxHealth;
            maxHealth += amount;
            
            if (healthDiff > 0) CurrentHealth += healthDiff;
            else if (maxHealth < CurrentHealth) CurrentHealth = maxHealth;
        }
        
        bool IDamageable.IsPlayer()
        {
            return isPlayer;
        }

        bool IDamageable.IsAlive()
        {
            return IsAlive;
        }
        
        private void OnDestroy()
        {
            _logger?.Dispose();
        }
    }
}