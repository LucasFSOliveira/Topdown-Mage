using UnityEngine;

namespace combatSystem.abilitySystem.abilities
{
    public interface IProjectileAbility
    {
        GameObject ProjectilePrefab { get; }
        float DamageMultiplier { get; }
        float Speed { get; }
        float Lifetime { get; }
    }
}