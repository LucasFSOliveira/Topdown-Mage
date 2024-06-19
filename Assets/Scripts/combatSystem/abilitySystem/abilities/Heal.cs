using System;
using UnityEngine;

namespace combatSystem.abilitySystem.abilities
{
    [Serializable]
    public class Heal : Ability
    {
        [SerializeField] private float healBase = 15f;
        [SerializeField] private float healMultiplier = 0.4f;
        [SerializeField] private float healCooldown = 5f;

        private void Awake()
        {
            BaseCooldown = healCooldown;
        }

        protected override void Execute(IStats stats, Vector3 targetPosition)
        {
            float totalHeal = stats.MagicPower * healMultiplier + healBase;
            Debug.Log($"Heal for {totalHeal}.");
        }
    }
}