using System.Collections.Generic;
using combatSystem.abilitySystem.abilities;
using UnityEngine;

namespace combatSystem.abilitySystem
{
    public interface IHaveAbilities
    {
        List<IAbility> Abilities { get; }
        void ActivateAbility(int index, Vector3 targetPosition);
        void AddAbility(Ability ability);
        void RemoveAbility(Ability ability);
    }
}