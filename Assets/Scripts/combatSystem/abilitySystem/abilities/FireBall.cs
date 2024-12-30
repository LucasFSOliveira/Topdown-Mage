using System;
using UnityEngine;

namespace combatSystem.abilitySystem.abilities
{
    [Serializable]
    public class FireBall : Ability, IProjectileAbility
    {
        [SerializeField] private GameObject projectilePrefab;
        [SerializeField] private float damageMultiplier = 1f;
        [SerializeField] private float fireBallCooldown = 2f;
        [SerializeField] private float projectileSpeed = 5f;
        [SerializeField] private float projectileLifetime = 3f;

        private void Awake()
        {
            BaseCooldown = fireBallCooldown;
        }

        public GameObject ProjectilePrefab => projectilePrefab;
        public float DamageMultiplier => damageMultiplier;
        public float Speed => projectileSpeed;
        public float Lifetime => projectileLifetime;

        protected override void Execute(IStats stats, Vector3 targetPosition)
        {
            Debug.Log($"Fireball casted towards {targetPosition}.");
            AbilityCasting.CastProjectile(this, stats, transform.position, targetPosition);
        }
    }
}