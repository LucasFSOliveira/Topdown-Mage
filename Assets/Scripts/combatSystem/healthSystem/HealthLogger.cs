using System;
using healthSystem;
using UnityEngine;

namespace combatSystem.healthSystem
{
    public class HealthLogger : IDisposable
    {
        private readonly Health health;

        public HealthLogger(Health health)
        {
            this.health = health;
            this.health.OnDeath += LogDeath;
            this.health.OnDamageReceived += LogDamage;
        }

        void LogDeath() => Debug.Log($"GameObject {health.name} morreu", health);
        void LogDamage(float damage) => Debug.Log($"GameObject {health.name} took {damage} damage", health);

        public void Dispose()
        {
            if (health == null) return;
            health.OnDeath -= LogDeath;
            health.OnDamageReceived -= LogDamage;
        }
    }
}