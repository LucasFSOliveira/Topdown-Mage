using combatSystem.healthSystem;
using UnityEngine;

namespace combatSystem.abilitySystem.abilities.ProjectileScripts
{
    public class AbilityProjectile : MonoBehaviour
    {
        private float damage;
        private float speed;
        private float lifetime;
        private Vector3 targetPosition;
        private float timeCounter;

        public void Initialize(IStats stats, float damageIn, float speedIn, float lifetimeIn, Vector3 targetPositionIn)
        {
            this.damage = damageIn;
            this.speed = speedIn;
            this.lifetime = lifetimeIn;
            this.targetPosition = targetPositionIn;
            timeCounter = 0f;
        }

        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            timeCounter += Time.deltaTime;
            if (timeCounter >= lifetime) StartDestroy();
            if (transform.position == targetPosition) StartDestroy();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            IDamageable health = other.GetComponent<IDamageable>();
            if (health == null)
            {
                StartDestroy();
                return;
            }

            if (health.IsPlayer())
            {
                IStats playerStats = other.GetComponent<IStats>();
                float damageReductionFactor = (100 - playerStats.Armor) / 100;
                float totalDamage = damage * damageReductionFactor;
                health.TakeDamage(totalDamage);
            }
            StartDestroy();
        }

        void StartDestroy()
        {
            Destroy(gameObject);
            this.enabled = false;
        }
    }
}