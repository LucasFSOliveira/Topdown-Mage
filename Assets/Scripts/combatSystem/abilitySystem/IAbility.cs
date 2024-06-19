using UnityEngine;

namespace combatSystem.abilitySystem
{
    public interface IAbility
    {
        float Cooldown { get; }
        void Activate(IStats stats);
        void Activate(IStats stats, Vector3 targetPosition);
        bool IsOnCooldown();
    }
}