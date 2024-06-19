using combatSystem.abilitySystem.abilities;
using combatSystem.abilitySystem.abilities.ProjectileScripts;
using UnityEngine;

namespace combatSystem.abilitySystem
{
    public static class AbilityCasting
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public static void CastProjectile(IProjectileAbility ability, IStats stats, Vector3 targetPosition)
        {
            Vector3 direction = targetPosition - stats.Transform.position;
            GameObject projectileInstance = Object.Instantiate(ability.ProjectilePrefab, stats.Transform.position, Quaternion.identity);
            projectileInstance.transform.right = direction;
            AbilityProjectile abilityProjectile = projectileInstance.GetComponent<AbilityProjectile>();
            if (abilityProjectile != null)
            {
                abilityProjectile.Initialize(stats, ability.DamageMultiplier * stats.MagicPower, ability.Speed, ability.Lifetime, targetPosition);
            }
        }
    }
}