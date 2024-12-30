using combatSystem.abilitySystem.abilities;
using combatSystem.abilitySystem.abilities.ProjectileScripts;
using UnityEngine;

namespace combatSystem.abilitySystem
{
    public static class AbilityCasting
    {
        public static void CastProjectile(IProjectileAbility ability, IStats stats, Vector3 playerPosition, Vector3 targetPosition)
        {
            Vector3 direction = targetPosition - playerPosition;
            Vector3 initialPosition = (direction * (float)0.2) + playerPosition;
            GameObject projectileInstance = Object.Instantiate(ability.ProjectilePrefab, initialPosition, Quaternion.identity);
            projectileInstance.transform.right = direction;
            AbilityProjectile abilityProjectile = projectileInstance.GetComponent<AbilityProjectile>();
            if (abilityProjectile != null)
            {
                abilityProjectile.Initialize(stats, ability.DamageMultiplier * stats.MagicPower, ability.Speed, ability.Lifetime, targetPosition);
            }
        }
    }
}